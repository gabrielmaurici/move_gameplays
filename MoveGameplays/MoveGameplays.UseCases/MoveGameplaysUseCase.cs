using Microsoft.Extensions.Configuration;
using MoveGameplays.Domain.Interfaces;
using MoveGameplays.Domain.Models;
using MoveGameplays.Infraestruct;
using src.UseCases.Interfaces;

namespace MoveGameplays.UseCases.Interface
{
    public class MoveGameplaysUseCase : IMoveGameplaysUseCase
    {
        private readonly ICheckExpectedHd _checkExpectedHd;
        private readonly IEjectExternalHdService _ejectExternalHdService;
        private readonly MoveGameplaysConfigModel _moveGameplaysConfig;

        public MoveGameplaysUseCase(IConfiguration configuration, ICheckExpectedHd checkExpectedHd, IEjectExternalHdService ejectExternalHdService)
        {
            _checkExpectedHd = checkExpectedHd;
            _ejectExternalHdService = ejectExternalHdService;
            _moveGameplaysConfig = new();
            //configuration.GetSection("MoveGameplaysConfig").Bind(_moveGameplaysConfig);
        }

        public void Move(string diskDrive)
        {
            var checkHd = _checkExpectedHd.Check(diskDrive, _moveGameplaysConfig.ExternalHdName);
            if (!checkHd) return;

            string moveOptions = ShowMoveOptionsAndGetChoice();
            IMoveFiles? moveFiles = moveOptions switch
            {
                "1" => new MoveLastMp4File(),
                "9" => new MoveLast10Mp4Files(),
                _ => null
            };

            if (moveFiles == null) return;

            moveFiles.Move(moveFromFolder: $"{diskDrive}\\" + _moveGameplaysConfig.FolderGameplaysHd,
                           moveToFolder: _moveGameplaysConfig.PathGameplaysPc);

            EjectHd(diskDrive);
        }

        private static string ShowMoveOptionsAndGetChoice()
        {

            Console.WriteLine("1 - Mover última gameplay gravada.\n" +
                              "9 - Mover as últimas 10 gameplays gravadas.\n");

            var moveOptions = Console.ReadLine();
            return moveOptions!;
        }

        private void EjectHd(string diskDrive)
        {
            var eject = _ejectExternalHdService.Eject(diskDrive);
            if (eject)
                Console.WriteLine("HD ejetado com sucesso.");
            else
                Console.WriteLine("Falha ao ejetar HD");
        }
    }
}