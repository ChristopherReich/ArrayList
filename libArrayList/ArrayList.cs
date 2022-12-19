using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace libArrayList
{
    public class ArrayList<T> : IArrayList<T>
    {
        #region Properties
        public T this[int index]   // property
        {
            get // get method
            {
                if (theArray.Length > index) return theArray[index];
                else return default;
            }
            set // set method
            { 
                
                while (index >= theArray.Length)
                {
                    ExtendArray();
                }
                theArray[index] = value;
                count++; // --> STIMMT SO NOCH NICHT - DARF NICHT IMMER HOCHZÄHLEN
            }  
        }

        public int count { get; private set; }

        private T[] theArray;
        #endregion

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="size"></param>
        public ArrayList(int size = 8)
        {
            theArray = new T[size];
            count = 0;
        }

        /// <summary>
        /// Füge dem Array eine Variable hinzu
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            try
            {
                theArray[count] = item;
                
            }
            catch (IndexOutOfRangeException)
            {
                ExtendArray();
                theArray[count] = item;
            }
            finally
            {
                count++;
            }
                     
        }

        /// <summary>
        /// Initialisiert ein neues Array mit der Länge 8
        /// </summary>
        public void Clear()
        {
            theArray = new T[8];
            count = 0;
        }

        /// <summary>
        /// Entfernt ein gewähltes Item
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(T item)
        {
            if (item != null) // mit Equals vergleichen!!!!!!!!!!!!!!!!!!!!!
            {
                int idx = Array.IndexOf(theArray, item);
                if (idx <= count)
                {
                    if (this.RemoveAt(idx)) return true;
                }               
            }
            return false;      
        }

        /// <summary>
        /// Entfernt ein Element am angegebenen Index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool RemoveAt(int index)
        {
            try
            {
                int length = count - index;
                Array.Copy(theArray, index + 1, theArray, index, length);
                count--;

                if (count * 2 < theArray.Length) ReduceArray();
                return true;
            }
            catch
            {
                return false;
            }          
        }

        /// <summary>
        /// Vergrößere das Array um das Doppelte
        /// </summary>
        private void ExtendArray()
        {
            Array.Resize(ref theArray, theArray.Length * 2);
        }

        /// <summary>
        /// Verkleinerd das Array um die Hälfte
        /// </summary>
        private void ReduceArray()
        {
            Array.Resize(ref theArray, count);
        }

        /// <summary>
        /// Erweitert das Array an der Stelle 'index' um 'value'
        /// Die Arraygröße wird bei Bedarf automatisch vergrößert
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void InsertAt(int idx, T val)
        {

            while (theArray.Length < idx)
            {
                ExtendArray();
            }

            int length = theArray.Length - idx;
            Array.Copy(theArray, idx, theArray, idx + 1, length);
            theArray[idx] = val;
            count++;
        }
    }
}
