using ClassLibraryAssurance;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProjectAssurance
{
    [TestClass]
    public class UnitTestTarif
    {

        [TestMethod("ObtenirTarifOrange")]
        [DataRow(24, 1 , 0, CouleurTarif.Rouge)]
        [DataRow(24, 3, 0, CouleurTarif.Orange)]
        [DataRow(24, 3, 1, CouleurTarif.Rouge)]
        [DataRow(25, 1, 0, CouleurTarif.Orange)]
        [DataRow(25, 1, 1, CouleurTarif.Rouge)]
        [DataRow(25, 2 , 0, CouleurTarif.Vert)]
        [DataRow(25, 2, 1, CouleurTarif.Orange)]
        [DataRow(25, 2, 2, CouleurTarif.Rouge)]
        public void TestMethodObtenirTarif(int pAge, int pDuree, int pNombreAccident, CouleurTarif pExepectedResult)
        {
            // Arrangement 
            Tarif conducteur = new Tarif();
            conducteur.Age = pAge;
            conducteur.Duree = pDuree;
            conducteur.NombreAccident = pNombreAccident;

            // Action
            CouleurTarif tarif = conducteur.NomduTarif;

            //Assert
            Assert.AreEqual(pExepectedResult, tarif);

        }

        [TestMethod("ObtenirTarifRefusé")]
        [ExpectedException(typeof(Exception))]
        [DataRow(24, 1, 1)]
        [DataRow(25, 1, 2)]
        [DataRow(25, 2, 3)]

        public void TestMethodShouldExeptionRefuser(int pAge, int pDuree, int pNombreAccident)
        {
            // Arrangement 
            Tarif conducteur = new Tarif();
            conducteur.Age = pAge;
            conducteur.Duree = pDuree;
            conducteur.NombreAccident = pNombreAccident;

            // Action
            CouleurTarif tarif = conducteur.NomduTarif;


        }


    }
}