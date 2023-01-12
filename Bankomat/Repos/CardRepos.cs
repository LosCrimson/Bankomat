using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bankomat.Interfaces;

namespace Bankomat.Repos
{
    public abstract class CardRepos<T>// : IRepo<T>
    {

        public T Retrieve(Guid id, List<T> list)
        {
            foreach (T listItem in list)
            {
                //This basically no matter what object finds the Guid value in it.
                System.Reflection.PropertyInfo pi = listItem.GetType().GetProperty("Guid");
                Guid CardGuid = (Guid)pi.GetValue(listItem, null);

                if (CardGuid == id)
                {
                    return listItem;
                }
            }
            return default(T);
        }

        public List<T> RetrieveAll(Guid id, List<T> list)
        {
            List<T> filteredList = new List<T>();

            foreach (T listItem in list)
            {

                System.Reflection.PropertyInfo pi = listItem.GetType().GetProperty("guid");
                Guid CardGuid = (Guid)pi.GetValue(listItem, null);

                if (CardGuid == id)
                {
                    filteredList.Add(listItem);
                }
            }
            return filteredList;
        }
    }
}
