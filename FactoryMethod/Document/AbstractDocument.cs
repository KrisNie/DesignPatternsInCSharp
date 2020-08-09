using System.Collections.Generic;
using FactoryMethod.Page;

namespace FactoryMethod.Document
{
    public abstract class AbstractDocument
    {
        private List<AbstractPage> _pages = new List<AbstractPage>();

        // Constructor calls abstract Factory method
        public AbstractDocument() => this.CreatePages();

        public List<AbstractPage> Pages => _pages;

        // Factory Method
        public abstract void CreatePages();
    }
}