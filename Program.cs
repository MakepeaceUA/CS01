using System.Runtime.InteropServices;

namespace ConsoleApp21
{
    internal class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, string F_Text, string L_Text,int type);
        static void Main(string[] args)
        {
            string f_name = "Арсений";
            string l_name = "Севастьянов";
            string age = "18";

            MessageBox(IntPtr.Zero, f_name, "Имя",0);
            MessageBox(IntPtr.Zero, l_name, "Фамилия",0);
            MessageBox(IntPtr.Zero, age, "Возраст",0);
        }
    }
}