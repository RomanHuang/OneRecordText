// See https://aka.ms/new-console-template for more information
using OneRecordText.Utils;

var token = new OneRecordAPIHelp().GetToken();

new OneRecordAPIHelp().MyGetWebRequest("https://iccs.one-record.lhind.dev/", token);