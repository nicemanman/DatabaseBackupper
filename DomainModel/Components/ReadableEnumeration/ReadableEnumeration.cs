using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Components.ReadableEnumeration
{
    public class ReadableEnumeration<T> where T : struct, IConvertible
    {
        private readonly List<ReadableEnumerationValue> UIEnumerationValues;
        public ReadableEnumeration(List<string> readableNames)
        {
            var enumerationNames = SelectList.Of<T>();
            UIEnumerationValues = new List<ReadableEnumerationValue>();
            SetReadableList(readableNames, enumerationNames);
        }
        
        public T GetEnumItem(string readableName)
        {
            return UIEnumerationValues.Where(x => x.Name == readableName).Select(x => x.EnumerationItem).FirstOrDefault();
        }
        public string GetEnumItemName(T item)
        {
            return UIEnumerationValues.Where(x => x.EnumerationItem.Equals(item)).Select(x => x.Name).FirstOrDefault();
        }
        public List<string> GetReadableList()
        {
            return UIEnumerationValues.Select(x => x.Name).ToList();
        }

        private void SetReadableList(List<string> readableList, List<T> enumList)
        {
            if (readableList.Count() != enumList.Count()) throw new Exception("Размеры читаемого списка и перечисления не равны!");
            int index = 0;
            while (index != readableList.Count())
            {
                var value = new ReadableEnumerationValue(readableList[index], enumList[index]);
                UIEnumerationValues.Add(value);
                index++;
            }
        }

        private class ReadableEnumerationValue
        {
            public ReadableEnumerationValue(string Name, T EnumerationItem)
            {
                this.Name = Name;
                this.EnumerationItem = EnumerationItem;
            }
            public string Name { get; protected set; }
            public T EnumerationItem { get; protected set; }
        }
    }
}
