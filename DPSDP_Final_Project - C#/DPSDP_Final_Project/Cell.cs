using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPSDP_Final_Project
{
    /*This is the Cell wich is an abstract object because it is never implemented but all the Cell Type heritates from it.
     *It helps us to create Cell Types (Property,Start,Jail,...) thanks to our Factory pattern.
     */
    public abstract class Cell
    {
        #region Attributes
        public int position;
        #endregion

        #region Constructor
        public Cell() { } //the default constructor.

        public Cell(int position)
        {
            this.position = position;
        }
        #endregion

        #region Proprieties

        public int Position { get => position; set => position = value; }
        #endregion

        #region Methods
        public virtual string toString() // the absract class has the key "virtual" but the classes that inherit methods are ovverrided.
        {
            return "";
        }
        #endregion

    }
}
