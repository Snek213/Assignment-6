namespace Assignment_6
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
           
            IPersonDataSource dataSource = new PersonContextDataSource();


            Application.Run(new frmMain(dataSource));
        }
    }
}