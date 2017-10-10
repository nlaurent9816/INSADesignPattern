using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSADesignPattern.Composite
{
    class HelpLeaf : Leaf
    {
        private string helpText;
        /// <summary>
        /// Sous-classe de Leaf.
        /// Génère une un champ de menu dont l'exécution affiche un texte d'aide.
        /// Le menu est implémenté sous forme d'arbre.
        /// </summary>
        /// <param name="leafDescription">Nom du champ</param>
        /// <param name="leafKeyword">Mot-clé déclanchant l'exécution de la feuille (lors de l'utilisation de l'Observer)</param>
        /// <param name="helpText">Texte à afficher à l'exécution</param>
        public HelpLeaf(string leafDescription, string leafKeyword, string helpText) : base(leafDescription, leafKeyword)
        {
            this.helpText = helpText;
        }

        /// <summary>
        /// Affiche le texte d'aide lié à la feuille.
        /// </summary>
        /// <returns>True</returns>
        public override bool ExecuteLeaf()
        {
            Console.WriteLine("Aide de " + description + " :");
            Console.WriteLine(helpText);
            return true;
        }
    }
}
