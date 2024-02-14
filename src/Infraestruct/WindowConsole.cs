namespace src.Infraestruct
{
    public static partial class WindowConsole
    {
        public static void Open()
            => HideConsoleWindow(1);

        public static void Close()
            => HideConsoleWindow(0);

        private static void HideConsoleWindow(int show)
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, show);
        }

        [System.Runtime.InteropServices.LibraryImport("kernel32.dll")]
        private static partial IntPtr GetConsoleWindow();

        [System.Runtime.InteropServices.LibraryImport("user32.dll")]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        private static partial bool ShowWindow(IntPtr hWnd, int nCmdShow);
    }
}