using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using StartAssignment.Views;
using StartAssignment.Repository_Service;
using StartAssignment.Controllers;
using StartAssignment.Menu;


namespace StartAssignment
{
   
    class Program
    {
       
        static void Main(string[] args)
        {
            Application.Run();
        }
    }
    class Application
    {
        public static void Run()
        {
            StartMenu menu= new StartMenu();
            menu.MainMenu();  
        }
       
    }
    
}
