using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Uppg1DAL;

namespace Uppg1BLL
{
    public class ListManager<T> : IListManager<T>
    {
        private List<T> m_List;

        public ListManager()
        {
            m_List = new List<T>();
           
        }

        //Counting the current elements inside the list
        public int Count => m_List.Count;

        //Adding a new element to the List
        public bool Add(T aType)
        {
            m_List.Add(aType);
            return true;
        }

        public void OpenFile(string fileName)
        {
            m_List = Serialization.BinaryDeserialize<List<T>>(fileName);
        }

        public void SaveFile(string fileName)
        {
            Serialization.Binaryserialize<List<T>>(m_List, fileName);
        }

        //deleting an element on a specified index and replacing it with a new element
        public bool ChangeAt(T aType, int anIndex)
        {
            m_List.RemoveAt(anIndex);
            m_List.Insert(anIndex, aType);
            return true;
        }

        public bool CheckIndex(int index)
        {
            throw new NotImplementedException();
            // return m_List.BinarySearch(smthing);
        }

        //Deleting all the elements inside the list
        public void DeleteAll()
        {
            m_List.Clear();
        }

        //Deleting an element in the list with a specified index
        public bool DeleteAt(int anIndex)
        {
           m_List.RemoveAt(anIndex);
            return true;
        }

        public T GetAt(int anIndex)
        {
           // throw new NotImplementedException();
          return m_List.ElementAt(anIndex);
        }

        public string[] ToStringArray()
        {
           // throw new NotImplementedException();
            string[] ListToArray = new string[m_List.Count];
            int i = 0;
            foreach(T aType in m_List)
            {
              
                ListToArray[i++] = aType.ToString();
            }
            return ListToArray;
        }

        public List<string> ToStringList()
        {
            List<string> StringList = new List<string>();
            foreach(T aType in m_List)
            {
                StringList.Add(aType.ToString());
            }
            return StringList;
        }

        public bool XMLSerialize(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
