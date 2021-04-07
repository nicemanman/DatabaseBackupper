using System;
using System.Collections.Generic;
using System.Text;

namespace CoreSettings
{
    internal static class EnvVariablesManager
    {
        /// <summary>
        /// Функция для получения переменной среды, а если ее нет - ее создания со значением по умолчанию
        /// </summary>
        /// <param name="variableName">Имя переменной среды</param>
        /// <param name="variableDefaultValue">Значение переменной, с которой она будет создана если отсутствует</param>
        /// <returns>Значение переменной</returns>
        public static string GetVariableOrSetToDefault(string variableName, string variableDefaultValue) 
        {
            var value = Environment.GetEnvironmentVariable(variableName, EnvironmentVariableTarget.User);
            if (value == null)
            {
                Environment.SetEnvironmentVariable(variableName, variableDefaultValue, EnvironmentVariableTarget.User);
                value = variableDefaultValue;
            }
            return value;
        }

        
    }
}
