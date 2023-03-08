using System;

namespace denemesql.Models
{
    public class Fiyatlar
    {
        public int FiyatlarID { get; set; }

        public int IeeeMember { get; set; }
        public int NonIeeeMember { get; set; }
        public int IeeeStudentMember { get; set; }
        public int StudentNonIeeeMember { get; set; }
        public int EkstraPaper { get; set; }
    }
}
