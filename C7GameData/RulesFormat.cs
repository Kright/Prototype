namespace C7GameData

/*
    Rules are analagous to Civ3's BIQ and may exist as a standalone
    (e.g. in a mod) or as part of the save file. At least for now.
*/
{
    using System;
    public class C7RulesFormat {
        public string Version { get; set; }
        public C7RulesFormat() {
            Version = "v0.0early-prototype";
        }
    }
}