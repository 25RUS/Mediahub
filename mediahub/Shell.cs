using mediahub.HttpRq.POST;
using mediahub.Models.Auth;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace mediahub
{
    public class Shell
    {
        public void Hello()
        {
            Console.Write("\nMH_Shell> ");
            string cmd = Console.ReadLine();
            Exec(cmd);
        }

        void Exec(string cmd)
        {
            string[] cmdPart = cmd.Split(new char[] { ' ' });

            try
            {
            
                switch (cmdPart[0])
                {
                    case "q":
                        {

                            break;
                        }
                    case "clear":
                        {
                            Console.Clear();
                            break;
                        }
                    case "login":
                        {
                            string login = null, password = null;
                            Console.Write("Login: ");
                            login = Console.ReadLine();
                            Console.Write("\nPassword: ");

                            while (true)
                            {
                                var key = Console.ReadKey(true);//не отображаем клавишу - true
                                if (key.Key == ConsoleKey.Enter) break; //enter - выходим из цикла
                                Console.Write("");//рисуем звезду вместо нее
                                password += key.KeyChar; //копим в пароль символы
                            }

                            Auth auth = new Auth();
                            GetToken getToken = new GetToken();
                            getToken.email = cmdPart[1];
                            getToken.password = cmdPart[2];
                            auth.AuthToken(getToken);
                            break;
                        }
                    case "signup": //signup name email password confirm_password
                        {
                            HttpRq.POST.Auth auth = new HttpRq.POST.Auth();
                            Models.Auth.Reg reg = new Models.Auth.Reg();
                            reg.name = cmdPart[1];
                            reg.email = cmdPart[2];
                            reg.password = cmdPart[3];
                            reg.confirm_password = cmdPart[4];
                            Task<Models.Auth.RX.User> reginfo = auth.RegNewAcc(reg);// new Task<Models.Auth.RX.User>();
                            
                            break;
                        }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Hello();
        }
    }
}
