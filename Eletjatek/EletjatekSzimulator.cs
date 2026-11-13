using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Eletjatek
{
    internal class EletjatekSzimulator
    {
        private int[,] Matrix;
        private int OszlopokSzama;
        private int SorokSzama;

        public EletjatekSzimulator(int sorokSzama, int oszlopokSzama)
        {
            SorokSzama = sorokSzama;
            OszlopokSzama = oszlopokSzama;
            Random rnd = new Random();
            Matrix = new int[SorokSzama + 2 , OszlopokSzama + 2];
            for(var i = 1; i <= SorokSzama; i++) 
            {
                for(var j = 1; j <= OszlopokSzama; j++)
                {
                    Matrix[i, j] = rnd.Next(0, 2);
                }         
            }
        } 

        private void Megjelenit()
        {
            for (var i = 0; i <= SorokSzama + 1; i++)
            {
                for (var j = 0; j <= OszlopokSzama + 1; j++)
                {
                    Console.SetCursorPosition(j, i);
                    if(i == 0 || j == 0 || i == SorokSzama + 1 || j == OszlopokSzama + 1)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        if (Matrix[i,j] == 1)
                        {
                            Console.Write("S");
                        }
                        else if (Matrix[i,j] == 0)
                        {
                            Console.Write(" ");
                        }
                    }
                }
            }
        }


        // 6. feladat
        // 1. lépés, létrehozhatunk egy új mátrixot,
        // 2. lépés, a régi mátrix bejárása két for ciklussal első és utolsó oszlop és sor kihagyásával.
        // 3. lépés, aktuális cellának megszámoljuk hogy hány szomszédja van.
        // A következő szabályok szerint feltöltjük az új mátrixot.
        // 4. lépés, az aktuális cellát is szomszédnak számoljuk, ha értéke '1'
        // Ha túl kevés szomszéd van (kettőnél kevesebb), akkor az aktuális cella értékét nullára állítjuk.
        // Ha túl sok szomszéd van (több mint három), akkor is elpusztul az aktuális cella.
        // új sejt születése
        // 5. lépés, A régi mátrixot felülírjuk az újabbal. 

        public void KovetkzoAllapot()
        {
            int[,] ujMatrix = new int[SorokSzama + 2,OszlopokSzama + 2];
            
            for (int i = 1; i <= SorokSzama; i++)
            {
                for (int j = 1; j <= OszlopokSzama; j++)
                {
                    int szomszedokSzama = 0;
                    for (int a = -1; a <= 1; a++)
                    {
                        for (int b = -1; b <= 1; b++)
                        {
                            szomszedokSzama += Matrix[i + a, j + b];
                        }
                    }
                    szomszedokSzama -= Matrix[i, j];
                    if (Matrix[i,j] == 1 && szomszedokSzama < 2)
                    {
                        ujMatrix[i, j] = 0;
                    }
                    else if (Matrix[i,j] == 1 && szomszedokSzama > 3)
                    {
                        ujMatrix[i, j] = 0;
                    }
                    else if (Matrix[i, j] == 0 && szomszedokSzama == 3)
                    {
                        ujMatrix[i, j] = 1;
                    }
                    else
                    {
                        ujMatrix[i,j] = Matrix[i,j];
                    }
                }
            }
            Matrix = ujMatrix;
        }

        public void Run()
        {
            Megjelenit();
            KovetkzoAllapot();
            Thread.Sleep(500);
        }
    }
}
