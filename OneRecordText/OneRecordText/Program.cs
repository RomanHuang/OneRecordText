
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using OneRecordText.Model;
using OneRecordText.Model.OneRecord;
using OneRecordText.Model.OneRecordAPI;
using OneRecordText.Utils;
using System;
using System.Collections.Generic;

namespace OneRecordText
{
    class Program
    {

        static void Main(string[] args)
        {

           new  OneRecordAPIHelp().GetToken();
        }


    }
}
