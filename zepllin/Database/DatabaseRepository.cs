using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using zepllin.Interfaces;
namespace zepllin.Database
{
    #region Veritabanı Repository Önemli
    public class DatabaseRepository<D> : IDatabaseRepository<D> where D : class
    {
        private readonly DatabaseContext context;

        private readonly DbSet<D> tabledb;
        public DatabaseRepository(DatabaseContext context)
        {
            this.context = context;

            tabledb = context.Set<D>();
        }
        public IEnumerable<D> GetAllList()
        {
            return tabledb.ToArray();
        }
        public D FindAndGetById(object id)
        {
            
            return tabledb.Find(id);              
        }
        public void DeleteFromDatabase(object id)
        {
            D tables = tabledb.Find(id);
            tabledb.Remove(tables);
        }
        public void InsertToDatabase(D db)
        {
            tabledb.Add(db);           
        }
        public void UpdateFromDatabase(D updb)
        {
             tabledb.Attach(updb);
             context.Entry(updb).State = EntityState.Modified;
        }
        public void Save()
        {
            context.SaveChanges();
        }
        /*TODO Veritabanı Fotoğraf Upload Prosedürü Tamamlanması*/
        public void SpUploadImage(object[] parameters)
        {
            context.Database.ExecuteSqlRaw($"CALL sp_uploadimages (@ImageWithoutSeoTitle, " +
                $"@ImageTitle," +
                $"@ImageCategoryFk," +
                $"@ImageSrc," +
                $"@UserNormalId," +
                $"@UserName," +
                $"@UserEmail," +
                $"@ImageNewNumber,"+
                $"@ImageApprove," +
                $"@ImageEdıtor," +
                $"@ImageExifIso," +
                $"@ImageExifFNumber," +
                $"@ImageExifFocalLength," +
                $"@ImageExifLensModel," +
                $"@ImageExifMeteringMode," +
                $"@ImageExifModel," +
                $"@ImageExifShutterSpeedValue," +
                $"@ImageExifExposureMode," +
                $"@ImageExifExposureProgram," +
                $"@ImageExifExposureTime," +
                $"@ImageExifMake)",
                SqlParams("@ImageWithoutSeoTitle", parameters[0]),
                SqlParams("@ImageTitle", parameters[1]),            
                SqlParams("@ImageCategoryFk", parameters[2]),
                SqlParams("@ImageSrc", parameters[3]),
                SqlParams("@UserNormalId", parameters[4]),
                SqlParams("@UserName",parameters[5]),
                SqlParams("@UserEmail",parameters[6]),
                SqlParams("@ImageNewNumber",parameters[7]),
                SqlParams("@ImageApprove", parameters[8]),
                SqlParams("@ImageEdıtor", parameters[9]),
                SqlParams("@ImageExifIso", parameters[10]),
                SqlParams("@ImageExifFNumber", parameters[11]),
                SqlParams("@ImageExifFocalLength", parameters[12]),
                SqlParams("@ImageExifLensModel", parameters[13]),
                SqlParams("@ImageExifMeteringMode", parameters[14]),
                SqlParams("@ImageExifModel", parameters[15]),
                SqlParams("@ImageExifShutterSpeedValue", parameters[16]),
                SqlParams("@ImageExifExposureMode", parameters[17]),
                SqlParams("@ImageExifExposureProgram", parameters[18]),
                SqlParams("@ImageExifExposureTime", parameters[19]),
                SqlParams("@ImageExifMake", parameters[20]));
        }
        /*TODO Veritabanı Fotoğraf upload prosedürü*/
        public void SPUpdateImages(int Id,string imgtitle,string imagewithoutseotitle,int imgcategory)
        {
            context.Database.ExecuteSqlRaw($"CALL sp_updateimages(@ImageId,@ImageTitle,@ImageWithoutSeoTitle,@ImageCategoryFk)",SqlParams("@ImageId",Id),SqlParams("@ImageTitle",imgtitle),SqlParams("@ImageWithoutSeoTitle",imagewithoutseotitle),SqlParams("@ImageCategoryFk",imgcategory));
        }
        /*TODO Veritabanı Oy Güncelleme prosedürü*/
        public void SpUpdateVote(int ıd,long votecount)
        {
            context.Database.ExecuteSqlRaw($"CALL sp_updatevote(@VotesContentId,@VoteNumbers)",SqlParams("@VotesContentId",ıd),SqlParams("@VoteNumbers",votecount));
        }
        /*TODO Veritabanı fotoğraf silme prosedürü*/
        public void SpDeleteImageFromDiskAndDatabase(int ıd)
        {
            context.Database.ExecuteSqlRaw($"CALL sp_deleteimage(@ImageId)", SqlParams("@ImageId", ıd));
        }
        /*TODO Veritabanı klasörleri ve veritabanından silme*/
        public void SpDeleteFromFolderAndDatabase(int ıd)
        {
            context.Database.ExecuteSqlRaw($"CALL sp_deletefromfolderandatabase(@UserNormalId)", SqlParams("@UserNormalId", ıd));
        }
        /*TODO Veritabanı Oy Ekleme prosedürü*/
        public void SpVoteAdd(long number,int votefkıd)
        {
            context.Database.ExecuteSqlRaw("CALL sp_voteadd(@VoteNumber,@VoteContentId)", SqlParams("@VoteNumber", number),SqlParams("@VoteContentId",votefkıd));
        }
        /*TODO Veritabanı Yorum Ekleme prosedürü*/
        public void SpCommentAdd(string commentcontents, int commentfk,string commentusername,string commentdate)
        {
            context.Database.ExecuteSqlRaw("CALL sp_commentsadd(@CommentContents,@CommentFk,@CommentUserName,@CommentDate)", SqlParams("@CommentContents", commentcontents),SqlParams("@CommentFk",commentfk),SqlParams("@CommentUserName", commentusername),SqlParams("@CommentDate",commentdate));
        }
        /*TODO Veritabanı kategori ve title göre getirme prosedürü*/
        public IEnumerable<D> SpImgAndCategory(int Id)
        {
            return context.Set<D>().FromSqlRaw("CALL sp_ımgandtitle(@ImageId)", SqlParams("@ImageId", Id));
        }
        /*TODO Veritabanı Benzer prosedürü*/
        public IEnumerable<D> SpGetUserByImages(int Id)
        {
            return context.Set<D>().FromSqlRaw("CALL sp_getuserby(@UserNormalId)", SqlParams("@UserNormalId",Id));
        }
        /*TODO Veritabanı kullancıya göre liseteleme prosedürü*/
        public IEnumerable<D> SpGetByImage(int ıd, string title)
        {
            return context.Set<D>().FromSqlRaw("CALL sp_getbyimage(@ImageId,@ImageTitle)", SqlParams("@ImageId", ıd),SqlParams("@ImageTitle", title));
        }
        /*TODO Veritabanı Oyları Listeleme prosedürü*/
        public IEnumerable<D> SpGetVotes(int ıd)
        {
            return context.Set<D>().FromSqlRaw("CALL sp_getvotes(@VotesContentId)", SqlParams("@VotesContentId", ıd));
        }
        public IEnumerable<D> SpGetComments(int ıd)
        {
            return context.Set<D>().FromSqlRaw("CALL sp_getcomments(@CommentFk)", SqlParams("@CommentFk", ıd));
        }
        public IEnumerable<D> SpGetUserByFetch(string username)
        {
            return context.Set<D>().FromSqlRaw("CALL sp_getuserbyfetch(@UserName)", SqlParams("@UserName", username));
        }
        public IEnumerable<D> SpGetByCategory(int ıd)
        {
            return context.Set<D>().FromSqlRaw("CALL sp_getbycategory(@CategoryFk)", SqlParams("@CategoryFk", ıd));
        }
        public IEnumerable<D> SpPendingApproval(int ıd)
        {
            return context.Set<D>().FromSqlRaw("CALL sp_pendingapproval(@UserNormalId)", SqlParams("@UserNormalId", ıd));
        }
        public IEnumerable<D> SpSearch(string term)
        {
            return context.Set<D>().FromSqlRaw("CALL sp_search(@ImageWithoutSeoTitle)", SqlParams("@ImageWithoutSeoTitle", term));
        }
        public IEnumerable<D> SpGetBySearchResult(string title)
        {
            return context.Set<D>().FromSqlRaw("CALL sp_getsearchresult(@ImageTitle)", SqlParams("@ImageTitle", title));
        }
        private MySqlParameter SqlParams(string par, object val)
        {
            return new MySqlParameter(par, val);
        }
    }
    #endregion
}
