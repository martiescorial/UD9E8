using System;

namespace UD9E8
{
    public class Password
    {
        private const int longitudDefecto = 8;

        private string contraseña;
        private int longitud;
        public void setLongitud(int longitud)
        {

            this.longitud = longitud;

        }

        public int getLongitud()
        {

            return this.longitud;

        }

        public String getContraseña()
        {
            return this.contraseña;
        }

        public virtual string generaPassword()
        {
            
            contraseña = "";
            for (int i = 0; i < this.longitud; i++)
            {
                Random random = new Random();

                switch (random.Next() * 3)
                {
                    case 0:
                        contraseña += (char)(random.Next() * 26 + 'A');
                        break;
                    case 1:
                        contraseña += (char)(random.Next() * 26 + 'a');
                        break;
                    case 2:
                        contraseña += (char)(random.Next() * 10 + '0');
                        break;
                }
            }
            return contraseña;
        }



        public Password()
        {
            this.longitud = longitudDefecto;
            this.contraseña = generaPassword();

        }

       
        public Password(string contraseña, int longitud)
        {
            this.contraseña = contraseña;
            this.longitud = longitud;

        }
        static void Main(string[] args)
        {
            Password contraseña1 = new Password();
            int i;
            	
            Password[] passwd = new Password[5];
            for (i = 0; i < passwd.Length; i++)
            {
                passwd[i] = new Password();
                string longCont = "Introduzca la longitud de la contraseña";
                int longitudCont = Convert.ToInt32(longCont);
                passwd[i].setLongitud(longitudCont);
            }
            
            for (i = 0; i < passwd.Length; i++)
            {
                passwd[i].generaPassword();
                Console.WriteLine("%s\t%s\t\t%s%n", (i + 1), passwd[i].getContraseña());
            }

        }

    }
}
