﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOClassePoint
{
    class Point
    {
        //Attributs de la classe Point
        private int abscisse;
        private int ordonnee;
        string nom;

        //****************
        // CONSTRUCTEURS
        //****************

        //Sans paramètre
        public Point()
        {
            this.abscisse = 0;
            this.ordonnee = 0;
        }

        //Constructeur avec deux paramètres
        public Point(int abs, int ord)
        {
            this.abscisse = abs;
            this.ordonnee = ord;
        }

        //Constructeur avec trois paramètres
        public Point(int abs, int ord, string name)
        {
            this.abscisse = abs;
            this.ordonnee = ord;
            this.nom = name;
        }

        //****************
        // MUTATEURS
        //****************

        public void setAbscisse(int abs) //permet de modifier l'abscisse du point
        {
            this.abscisse = abs;
        }

        public void setOrdonnee(int ord) //permet de modifier l'ordonnée du point
        {
            this.ordonnee = ord;
        }

        public void setNom(string name) //permet de modifier le nom du point
        {
            this.nom = name;
        }
        //****************
        // ACCESSEURS
        //****************
        public int getAbscisse() //permet de récupérer l'abscisse du point
        {
            return this.abscisse;
        }

        public int getOrdonnee() //permet de récupérer l'ordonnée du point
        {
            return this.ordonnee;
        }

        public string getNom() //permet de récupérer le nom du point
        {
            return this.nom;
        }

        //****************
        // METHODES
        //****************

        //Affiche les coordonnées du point qui appelle cette méthode
        public void afficherCoordonnees()
        {
            Console.WriteLine(this.nom + " : (" + this.abscisse + "," + this.ordonnee + ")");
        }

        //Cette fonction compare les coordonnées de 2 points.
        //Si les coordonnées sont égales, la fonction renvoie 'true', sinon elle renvoie 'false'
        public bool comparerPoint(Point pt)
        {
            bool lesPointsSontIdentiques = false;

            if(this.abscisse == pt.abscisse && this.ordonnee == pt.ordonnee)
            {
                lesPointsSontIdentiques = true;
            }

            return lesPointsSontIdentiques;
        }

    }
}