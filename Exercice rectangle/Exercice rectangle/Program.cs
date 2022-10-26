using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_rectangle
{
    //définition de la classe 

     class rectangle
    {
        //déclaration des attributs
        private int longueur;
        private int largeur;


        int longueur
        {
            get { return this.longueur; }
            set { if (value>= 0) this.longueur = value;}
        }
        int largeur
        {
            get { return this.largeur; }
            set { if (value>= 0) this.largeur = value;}
        }
        //constructeur avec 2 paramètre
        public rectangle(int p_longueur = 1 , int p_largeur = 1 )
        {
            this.longueur = p_longueur;
            this.largeur = p_largeur;
          Console.WriteLine("création d'un nouveau rectangle qui à une longueur de " + "" + p_longueur + " et une largueur de "  + p_largeur);

        }
        public int perimetre()
        {
            return (this.longueur +this.largeur)*2;
        }
         public int aire()
        {
            return this.longueur *this.largeur;
        }
        public void afficherrectangle()

        {

        }

    }

     class Program
    {
        static void Main(string[] args)
        {
            console.write("entrer la longeur du rectangle");
           int longr = int.Parse(Console.ReadLine());
            Console.Write("entrer la largeur du rectangle");
            int larg = int.Parse(Console.ReadLine());
            rectangle rec = new rectangle(longr,larg);
            rec.afficherrectangle();
            Console.Write("appeler la méthode to string")
        }
    }
}
