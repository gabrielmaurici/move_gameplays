public static class CurrentForm
{
    public static Form? Current { get; set; }

    public static void Update(Form form)
        => Current = form;
}