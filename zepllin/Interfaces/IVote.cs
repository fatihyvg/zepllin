namespace zepllin.Interfaces
{
    public interface IVote
    {
        int VoteId
        {
            get;
            set;
        }
        long VoteNumbers
        {
            get;
            set;
        }
        int VoteContentId
        {
            get;
            set;
        }
    }
}
