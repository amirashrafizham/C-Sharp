using System;

namespace SupernaturalInheritance
{
    class Storm  //stores the essence, strength, and the title of the magician who created it.
    {
        public string Essence { get; set; } //type of storm like wind or rain
        public bool IsStrong { get; set; } //true if storm is strong
        public string Caster { get; set; } //title of magician casting the storm

        public Storm(string essence, bool isStrong, string caster)
        {
            this.Essence = essence;
            this.IsStrong = isStrong;
            this.Caster = caster;
        }

        public string Announce()
        {
            if (IsStrong)
            {
                return $"{Caster} cast a strong {Essence}";
            }
            else
            {
                return $"{Caster} cast a weak {Essence}";
            }
        }
    }
}
