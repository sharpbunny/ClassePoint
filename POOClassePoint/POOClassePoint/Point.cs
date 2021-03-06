﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOClassePoint
{
    class Point
    {
        //*****************************
        //Attributs de la classe Point
        //*****************************

        //On place les attributs en private. Ils ne seront accessibles que grâce aux méthodes de la classe Point
        private int abscisse;
        private int ordonnee;
        private string nom;

        //****************
        // CONSTRUCTEURS
        //****************

        //Sans paramètre
        public Point()
        {
            this.abscisse = 0;
            this.ordonnee = 0;
            this.nom = null;
        }

        //Constructeur qui permet de définir juste le nom du point
        public Point(string name)
        {
            this.nom = name;
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

        public void setCoordonnees(int abs, int ord) //permet de modifier les 2 coordonnées d'un point
        {
            this.abscisse = abs;
            this.ordonnee = ord;
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

        //Cette fonction permet de calculer la distance entre CE point et le point pt
        public double calculeDistance(Point pt)
        {
            double distance;
            distance = (this.abscisse-pt.abscisse)* (this.abscisse - pt.abscisse);
            distance += (this.ordonnee - pt.ordonnee) * (this.ordonnee - pt.ordonnee);
            distance = Math.Sqrt(distance);
            return distance;
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

        //Cette fonction permet de déplacer un point en lui indiquant en paramètre des coordonnées cartésiennes
        public void deplacerPoint(int abs, int ord)
        {
            this.abscisse += abs;
            this.ordonnee += ord;
        }

        //Cette fonction permet aux coordonnées de ce point de prendre les coordonnées d'un autre point
        public void egal(Point pt)
        {
            this.abscisse = pt.abscisse;
            this.ordonnee = pt.ordonnee;
        }

        //Cette fonction permet d'inverser les coordonnées
        //La valeur de l'abscisse devient celle de l'ordonnée et inversement
        public void inversementCoordonnees()
        {
            int i = 0;
            i = this.abscisse;
            this.abscisse = this.ordonnee;
            this.ordonnee = i;
        }

        //Permet de multiplier les coordonnées d'un point par un nombre
        public void multiplierCoordonnees(int multiplicateur)
        {
            this.abscisse *= multiplicateur;
            this.ordonnee *= multiplicateur;
        }

        //Permet de créer le point symétrique à pt par rapport à l'axe des abscisses
        public void symetriqueAbscisse(Point pt, int multiplicateur)
        {
            this.abscisse *= -1 * pt.abscisse;
        }

        //Permet de créer le point symétrique à pt par rapport à l'axe des ordonnées
        public void symetriqueOrdonnee(Point pt, int multiplicateur)
        {
            this.ordonnee = -1 * pt.ordonnee;
        }

        //Permet de créer le point symétrique par rapport à l'origine du plan
        public void pointSymetrique(Point pt, int multiplicateur)
        {
            this.abscisse = -1 * pt.abscisse;
            this.ordonnee = -1 * pt.ordonnee;
        }

    }
}
