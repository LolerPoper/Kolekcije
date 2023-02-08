using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definiranje ArrayList kolekcije
            ArrayList al = new ArrayList();

            // Dummy varijable i objekt
            int broj = 1;
            string ime = "ime";
            bool provjera = false;
            Klasa objekt = new Klasa(2023, "Prezime");

            // Dodavanje elemenata u ArrayList
            al.Add(ime);
            al.Add(objekt);
            al.Add(broj);
            al.Add(provjera);

            // Ispis elemenata
            Console.WriteLine("---- Ispis svih elemenata ----");
            for(int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

            al.RemoveAt(2);

            // Ispis elemenata nakon uklanjanja
            Console.WriteLine("---- Ispis svih elemenata nakon uklanjanja ----");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

            al.Insert(2, broj);

            // Ispis elemenata nakon dodavanja
            Console.WriteLine("---- Ispis svih elemenata nakon dodavanja ----");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

            // Definiranje List<T> kolekcije

            List<Klasa> listaObjekata = new List<Klasa>();

            int godina;
            string prezime;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Unesi godinu: ");
                godina = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Unesi prezime: ");
                prezime = Console.ReadLine();

                Klasa obj = new Klasa(godina, prezime);

                listaObjekata.Add(obj);
            }

            foreach (Klasa o in listaObjekata)
            {
                if (o.Godina < 2023)
                {
                    o.Ime = "Gabriel";
                    Console.WriteLine(o.Prezime);
                    Console.WriteLine(o.Ime);
                }
            }

            Console.ReadKey();

        }

        class Klasa
        {
            int godina;
            string prezime, ime;

            public Klasa(int godina, string prezime)
            {
                this.godina = godina;
                this.prezime = prezime;
            }

            public int Godina { get => godina; set => godina = value; }
            public string Prezime { get => prezime; set => prezime = value; }
            public string Ime { get => ime; set => ime = value; }

            public override string ToString()
            {
                string ispis="Godina: " + this.godina + ", Ime: " + this.ime + ", Prezime: " + this.prezime;
                return ispis;
            }
        }
    }
}