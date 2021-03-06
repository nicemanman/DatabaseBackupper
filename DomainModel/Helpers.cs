﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    /// <summary>
    /// Enum -> IEnumerable<Enum>
    /// </summary>
    public static class SelectList
    {
        public static List<T> Of<T>() where T : struct, IConvertible
        {
            Type t = typeof(T);
            if (t.IsEnum)
            {
                return Enum.GetValues(t).Cast<T>().ToList();
            }
            throw new ArgumentException("<T> must be an enumerated type.");
        }
    }
}
