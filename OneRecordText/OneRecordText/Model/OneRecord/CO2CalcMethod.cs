using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    /// <summary>
    /// CO2计算方法
    /// </summary>
    public class CO2CalcMethod : LogisticsObject
    {
        public CO2CalcMethod()
        {
            types = new List<string>() { Vocabulary.s_c_CO2CalcMethod };
        }
    }
}
