using System;
using System.Collections.Generic;

namespace UI
{
    /// <summary>
    /// Менеджер для отражения перечислений в UI
    /// </summary>
    public interface IReadableEnumsManager
    {
        List<string> GetReadableList(IEnumerable<Enum> enumList);
        void SetReadableList(List<string> readableList, IEnumerable<Enum> enumList);
        Enum GetSelectedEnum(string readableName);
        Enum GetSelectedEnumsAsFlags(List<string> readableList); //One | Two | Three...
        IEnumerable<Enum> GetSelectedEnumsAsList(List<string> readableList); //List[0], List[1]...
    }
}
