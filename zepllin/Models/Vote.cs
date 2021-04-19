using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using zepllin.Interfaces;

namespace zepllin.Models
{
    public class Vote : IVote
    {
        [Key]
        public int VoteId
        {
            get;
            set;
        }
        public long VoteNumbers
        {
            get;
            set;
        }
        [ForeignKey("vote_fk")]
        public int VoteContentId
        {
            get;
            set;
        }
    }
}
