namespace recuperatoriodelparcial_tema2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  basee,altura,ongitud,areabase,arealado;
            double area, volumen, diagonal, lado;
            int contador;
            contador = 0;

            do
            {
                Console.WriteLine("Ingrese la base del prisma");
                basee = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del prisma:");
                altura = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la longitud del prisma:");
                ongitud = int.Parse(Console.ReadLine());

                if (basee > 0 || altura > 0 || ongitud > 0) ;
                areabase = CalcularBase(basee, altura);
                arealado = CalcularLado(ongitud, altura);
                area = (areabase + arealado);
                volumen = (areabase * altura);
                diagonal = raiz(basee ^ (2 + altura) ^ 2);
                double.TryParse(TextBoxArea.Text, out area);    



            } while(basee != 0);





        }

        private static double raiz(int v)
        {
            throw new NotImplementedException();
        }

        private static int CalcularLado(int ongitud, int altura)
        {
            return 3 * (ongitud * altura);
        }

        private static int CalcularBase(int basee, int altura)
        {
          return 2 * ((basee * altura) / 2);


        }
    }
}