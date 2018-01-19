using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntitis
{
    public interface IDocManager<T>
    {

        T GetDocument();
        void MoveNext(int ID);
        void MovePrev(int ID);
        void UpdateDocument(int ID);
        void CreateDocument(int ID);
        void RemoveDocument(int ID);
    }
    

}
