using System.Collections.Generic;
namespace zepllin.Interfaces
{
    public interface IDatabaseRepository<D> where D : class
    {
        IEnumerable<D> GetAllList();

        D FindAndGetById(object id);

        void InsertToDatabase(D db);

        void DeleteFromDatabase(object id);

        void UpdateFromDatabase(D updb);

        void SpUploadImage(params object[] parameters);

        void SPUpdateImages(int Id,string imgtitle,string imagewithoutseotitle,int imgcategory);

        void SpDeleteImageFromDiskAndDatabase(int ıd);

        void SpDeleteFromFolderAndDatabase(int ıd);

        void SpVoteAdd(long number,int votefkıd);

        void SpCommentAdd(string commentcontents,int commentfk,string commentusername,string commentdate);

        void SpUpdateVote(int ıd, long votecount);

        IEnumerable<D> SpImgAndCategory(int Id);

        IEnumerable<D> SpGetUserByImages(int Id);

        IEnumerable<D> SpGetByImage(int ıd, string title);

        IEnumerable<D> SpGetVotes(int ıd);

        IEnumerable<D> SpGetComments(int ıd);

        IEnumerable<D> SpGetUserByFetch(string username);

        IEnumerable<D> SpGetByCategory(int ıd);

        IEnumerable<D> SpPendingApproval(int ıd);

        IEnumerable<D> SpSearch(string term);

        IEnumerable<D> SpGetBySearchResult(string title);

        void Save();
    }
}
