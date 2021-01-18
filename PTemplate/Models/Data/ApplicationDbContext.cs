using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PTemplate.Areas.Admin.Data;

using PTemplate.Data.DataBase;
using PTemplate.Data.DB;
using PTemplate.Models.Enum;
using Microsoft.AspNetCore.Identity;
using PTemplate.Models.DataViewModel;
using Microsoft.EntityFrameworkCore.Metadata;
using PTemplate.Models.DB;
using Microsoft.EntityFrameworkCore.Storage;
using PTemplate.Models.Data.DBSatare;
using System.Data;

using System.Drawing;
using PTemplate.Models.Data.DataBase;

namespace PTemplate.Data
{
    public class ApplicationDbContext :  _1868_yarbaseContext
    {
       
        
       

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }



        public virtual DbSet<productStory> ProductStory { get; set; }
        public virtual DbSet<Pathfile> Pathfile { get; set; }
      


        [Obsolete]
           #pragma warning disable CS0809 // Obsolete member overrides non-obsolete member
        protected override void OnModelCreating(ModelBuilder modelBuilder)
         #pragma warning restore CS0809 // Obsolete member overrides non-obsolete member
        {

            base.OnModelCreating(modelBuilder);
           
            modelBuilder.Entity("PTemplate.Data.DB.productStory", b =>
            {
                //b.Property<long>("idpost")
                //    .HasColumnType("bigint");

                b.Property<long>("idproduct")
                    .HasColumnType("bigint");

                b.Property<int>("mojudi")
                    .HasColumnType("int");

                b.Property<string>("pathdata")
                    .HasColumnType("nvarchar(max)");

                b.Property<decimal>("price")
                    .HasColumnType("decimal(18,2)");

                b.Property<string>("productdescription")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("title")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("totalrows")
                    .HasColumnType("int");

                b.ToTable("ProductStory");
            });


             modelBuilder.Entity<dbMessage>(); 

             modelBuilder.Entity<productStory>();
             modelBuilder.Entity<subfactorlist>();

             modelBuilder.Entity<PaymentProductViewModel>();
             modelBuilder.Entity<productautocompletelistmenu>();


             modelBuilder.Entity<productautocompletelistmenu>();
             modelBuilder.Entity<sportmusleResut>();
             modelBuilder.Entity<movesportGetResult>();
             modelBuilder.Entity<sportmusleGetAllResult>();
             modelBuilder.Entity<networkGetResult>();
             modelBuilder.Entity<networkGetAllUserResult>();
             modelBuilder.Entity<UserProfileGat>();
             modelBuilder.Entity<UserSecruity>();
             modelBuilder.Entity<networkpostGetUserResult>();
             modelBuilder.Entity<profileuserGetResult>();
             modelBuilder.Entity<networkuserGetResult>();
             modelBuilder.Entity<networkuserupdateGetDateResult>();
             modelBuilder.Entity<networkuserupdateGetResult>();
             modelBuilder.Entity<provinceGetResult>();
             modelBuilder.Entity<countyGetidResult>();
             modelBuilder.Entity<citygetidResult>();
             modelBuilder.Entity<networkSocialuserFllowingGatResult>();
             modelBuilder.Entity<networkSocialstateuserGatResult>();
             modelBuilder.Entity<networkSocialGetaboutResult>();
             modelBuilder.Entity<networkSocialGetuserResult>();
             modelBuilder.Entity<productshoppingsubtypeautocompletelist>();
             modelBuilder.Entity<productshoppingtypelist>();
             modelBuilder.Entity<networksettingusergetResult>();
             modelBuilder.Entity<networkshoppingdetailsgResult>();
             modelBuilder.Entity<shoppingnetworkmenugetResult>();
             modelBuilder.Entity<settingResult>();
             modelBuilder.Entity<stategetResult>();
             modelBuilder.Entity<menuorderitemsgetResult>();
             modelBuilder.Entity<menuorderlistResult>();
             modelBuilder.Entity<AspNetUsers1>();
             modelBuilder.Entity<AspNetRole1>();
             modelBuilder.Entity<Pathfile>();

           
            modelBuilder.Entity<NamranggetcolornameResult>();
            modelBuilder.Entity<NamgetnamelistbycolorandfamilyResult>();
            modelBuilder.Entity<NamgetcolordescriptionResult>();

        }

        /**************نام رنگ****************/
        public List<NamranggetcolornameResult> sp_getcolorname(
string name,
string family
)
        {
            //try
            //{
            List<NamranggetcolornameResult> lst;
            string sqlQuery = " EXEC [namyar].[getcolorname] @name,@family ";
            lst = this.Set<NamranggetcolornameResult>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@name", name)
                 , new SqlParameter("@family", family)
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }

        public List<NamgetcolordescriptionResult> sp_getcolordescription(int? idcolor)
        {
            //try
            //{
            List<NamgetcolordescriptionResult> lst;
            string sqlQuery = " EXEC [namyar].[getcolordescription] @idcolor ";
            lst = this.Set<NamgetcolordescriptionResult>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@idcolor", idcolor)
     
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }

        public List<NamgetnamelistbycolorandfamilyResult> sp_getnamelistbycolorandfamily(
string family ,
    string color ,
	bool gender 
)
        {
            //try
            //{
        List<NamgetnamelistbycolorandfamilyResult> lst;
            string sqlQuery = " EXEC [namyar].[getnamelistbycolorandfamily] @family,@color,@gender ";
            lst = this.Set<NamgetnamelistbycolorandfamilyResult>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@family", family)
                 , new SqlParameter("@color", color)
                 , new SqlParameter("@gender", gender)
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }

        /***************شبکه******************/

        public List<dbMessage> sp_networkprofilemediabytypedelete(
string iduser,
string token,
long idnetwork,
int idtype
  )
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [privatebase].[networkprofilemediabytypedelete] @iduser,@token,@idnetwork,@idtype ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                 , new SqlParameter("@idnetwork", idnetwork)

                 , new SqlParameter("@idtype", idtype)
              


                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }


        public List<dbMessage> sp_stateupdateorderuser(
  string iduser,
  string token,
  long idnetwork,
  string idmenuorder,
  byte idstatetype

    )
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [shoppingbasket].[stateupdateorderuser] @iduser , @token ,@idnetwork ,@idmenuorder,@idstatetype ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                 , new SqlParameter("@idnetwork", idnetwork)

                 , new SqlParameter("@idmenuorder", idmenuorder)
                 , new SqlParameter("@idstatetype", idstatetype)


                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }

        public List<Pathfile> sp_networkprofilemediapathget(
  long idnetwork,
  int idtype

    )
        {
            //try
            //{
            List<Pathfile> lst;
            string sqlQuery = " EXEC [privatebase].[networkprofilemediapathget] @idnetwork,@idtype ";
            lst = this.Set<Pathfile>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@idnetwork", idnetwork)
                 , new SqlParameter("@idtype", idtype)
                 
                 ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }

        public List<Pathfile> sp_menumediapathget(
   string idmenu

     )
        {
            //try
            //{
            List<Pathfile> lst;
            string sqlQuery = " EXEC [privatebase].[menumediapathget]  @idmenu ";
            lst = this.Set<Pathfile>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@idmenu", idmenu)).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }

        public List<dbMessage> sp_stateupdate(
    string iduser ,
    string token,
	long idnetwork ,
    string idmenuorder,
	byte idstatetype 

      )
        {
            //try
            //{
        List<dbMessage> lst;
            string sqlQuery = " EXEC [shoppingbasket].[stateupdate]  @iduser , @token ,@idnetwork ,@idmenuorder,@idstatetype ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                 , new SqlParameter("@idnetwork", idnetwork)

                 , new SqlParameter("@idmenuorder", idmenuorder)
                 , new SqlParameter("@idstatetype", idstatetype)
                

                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }


        public List<menuorderlistResult> sp_stateupdateorderuser(
       string iduser,
       string token,
       long idnetwork,
       string idmenuorder
        )
        {
            //try
            //{
            List<menuorderlistResult> lst;
            string sqlQuery = " EXEC [shoppingbasket].[stateupdateorderuser]  @iduser,@token, @idnetwork,@idmenuorder";
            lst = this.Set<menuorderlistResult>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                 , new SqlParameter("@idnetwork", idnetwork)
                 , new SqlParameter("@idmenuorder", idmenuorder)

                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }


        public List<menuorderlistResult> sp_menuorderlistshoppinguser(
     string iduser,
     string token,
     int PageNumber
      )
        {
            //try
            //{
            List<menuorderlistResult> lst;
            string sqlQuery = " EXEC [shoppingbasket].[menuorderlistshoppinguser]  @iduser,@token@PageNumber,@RowsCountInEachPage ";
            lst = this.Set<menuorderlistResult>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                 , new SqlParameter("@PageNumber", PageNumber)
                 , new SqlParameter("@RowsCountInEachPage ", 20)

                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }


        public List<menuorderlistResult> sp_menuorderlistshopping(
       string iduser,
       string token,
       long idnetwork,
       int PageNumber

        )
        {
            //try
            //{
            List<menuorderlistResult> lst;
            string sqlQuery = " EXEC [shoppingbasket].[menuorderlistshopping]  @iduser,@token, @idnetwork,@PageNumber,@RowsCountInEachPage ";
            lst = this.Set<menuorderlistResult>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                 , new SqlParameter("@idnetwork", idnetwork)
                 , new SqlParameter("@PageNumber", PageNumber)
                 , new SqlParameter("@RowsCountInEachPage ", 20)
                
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }


        public List<menuorderlistResult> sp_menuorderlist(
        string iduser,
        string token,
        long idnetwork,
         int PageNumber
         )
        {
            //try
            //{
            List<menuorderlistResult> lst;
            string sqlQuery = " EXEC [shoppingbasket].[menuorderlist]  @iduser,@token, @idnetwork,@PageNumber,@RowsCountInEachPage";
            lst = this.Set<menuorderlistResult>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                 , new SqlParameter("@idnetwork", idnetwork)
                 , new SqlParameter("@PageNumber", PageNumber)
                 , new SqlParameter("@RowsCountInEachPage ", 20)
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }


     


        public List<dbMessage> sp_menuorderitemsupdate(
      string iduser,
              string token,
           long idnetwork,
    string idmenuorder,
    int counter,
    string idmenuitems
     )
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [shoppingbasket].[menuorderitemsupdate]  @iduser,@token, @idnetwork,@idmenuorder,@counter,@idmenuitems ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                 , new SqlParameter("@idnetwork", idnetwork)
                 , new SqlParameter("@idmenuorder", idmenuorder)
                 , new SqlParameter("@counter", counter)
                 , new SqlParameter("@idmenuitems", idmenuitems)

                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }



        public List<dbMessage> sp_menuorderitemsinsertimg(
 string iduser,
 string token,
 string idmenuorder,
 string idmenu,
 long idnetwork,
 string productbarcode,
 string name,
 decimal money,
 decimal moneyuser,
 decimal discount,
 int count,
 String namefile
)
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [shoppingbasket].[menuorderitemsinsertimg]  @iduser,@token,@idmenuorder," +
                "@idmenu,@idnetwork,@productbarcode,@name,@money,@moneyuser,@discount,@count,@namefile";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                 , new SqlParameter("@idmenuorder", idmenuorder)
                 , new SqlParameter("@idmenu", idmenu)
                 , new SqlParameter("@idnetwork", idnetwork)
                 , new SqlParameter("@productbarcode", productbarcode)
                 , new SqlParameter("@name", name)
                 , new SqlParameter("@money", money)
                 , new SqlParameter("@moneyuser", moneyuser)
                 , new SqlParameter("@discount", discount)
                 , new SqlParameter("@count", count)
                 , new SqlParameter("@namefile", namefile)
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }

        public List<dbMessage> sp_menuorderitemsinsert(
 string iduser,
 string token,
 string idmenuorder,
 string idmenu,
 long idnetwork,
 string productbarcode,
 string name,
 decimal money,
 decimal moneyuser,
 decimal discount,
 int count
)
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [shoppingbasket].[menuorderitemsinsert]  @iduser,@token,@idmenuorder," +
                "@idmenu,@idnetwork,@productbarcode,@name,@money,@moneyuser,@discount,@count ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                 , new SqlParameter("@idmenuorder", idmenuorder)
                 , new SqlParameter("@idmenu", idmenu)
                 , new SqlParameter("@idnetwork", idnetwork)
                 , new SqlParameter("@productbarcode", productbarcode)
                 , new SqlParameter("@name", name)
                 , new SqlParameter("@money", money)
                 , new SqlParameter("@moneyuser", moneyuser)
                 , new SqlParameter("@discount", discount)
                 , new SqlParameter("@count", count)
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }


        public List<dbMessage> sp_menuorderitemsdelete(
       string iduser,
       string token,
       string idmenuorder,
       string idmenuitems,
       long idnetwork
       )
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [shoppingbasket].[menuorderitemsdelete] @iduser,@token,@idmenuorder,@idmenuitems,@idnetwork";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                 , new SqlParameter("@idmenuorder", idmenuorder)
                 , new SqlParameter("@idmenuitems", idmenuitems)
                 , new SqlParameter("@idnetwork", idnetwork)

                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }


        public List<menuorderitemsgetResult> sp_menuorderitemsget(
          string iduser,
          string token,
          string idmenuorder,
          long idnetwork
          )
        {
            //try
            //{
            List<menuorderitemsgetResult> lst;
            string sqlQuery = " EXEC [shoppingbasket].[menuorderitemsget] @iduser,@token,@idmenuorder,@idnetwork";
            lst = this.Set<menuorderitemsgetResult>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                 , new SqlParameter("@idmenuorder",Guid.Parse(idmenuorder))
                 
                 , new SqlParameter("@idnetwork", idnetwork)
              
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }





        public List<stategetResult> sp_stateget(
       string iduser,
       string token,
       long idnetwork)
        {
            //try
            //{
            List<stategetResult> lst;
            string sqlQuery = " EXEC [shoppingbasket].[stateget]  @iduser,@token,@idnetwork ";
            lst = this.Set<stategetResult>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                 , new SqlParameter("@idnetwork", idnetwork)

                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }




        public List<dbMessage> sp_factorcreate(
        string iduser,
        string token,
        long idnetwork,
             int idordertype,
             decimal moneypeyk
)
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [shoppingbasket].[factorcreate]   @iduser,@token,@idnetwork,@idordertype,@moneypeyk ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                 , new SqlParameter("@idnetwork", idnetwork)
                 , new SqlParameter("@idordertype", idordertype)
                 , new SqlParameter("@moneypeyk", moneypeyk)
               
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }


        public List<dbMessage> sp_menudelete(string iduser,
string token, string idmenu, long idnetwork
)
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [shoppingnetwork].[menudelete] @iduser, @token,@idmenu,@idnetwork ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                 , new SqlParameter("@idmenu", idmenu)
                 , new SqlParameter("@idnetwork", idnetwork)

                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }


        public List<settingResult> sp_networksettingusergetactivesettings(long idnetwork)
        {
            //try
            //{
            List<settingResult> lst;
            string sqlQuery = " EXEC [privatebase].[networksettingusergetactivesettings] @idnetwork ";
            lst = this.Set<settingResult>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@idnetwork", idnetwork)
                
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }


        public List<dbMessage> sp_networkdescriptiondelete(string iduser,
string token, long idnetwork, string description
)
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [privatebase].[networkdescriptiondelete] @iduser,@token,@idnetwork,@description ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                 , new SqlParameter("@idnetwork", idnetwork)
                 , new SqlParameter("@description", description)

                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }


        public List<dbMessage> sp_networkdescriptioncreate(string iduser,
  string token,long idnetwork,string description
 )
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [privatebase].[networkdescriptioncreate] @iduser, @token,@idnetwork,@description ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                 , new SqlParameter("@idnetwork", idnetwork)
                 , new SqlParameter("@description", description)

                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }



        public List<shoppingnetworkmenugetResult> sp_shoppingnetworkmenuget(string iduser,
   long idnetwork
  )
        {
            //try
            //{
            List<shoppingnetworkmenugetResult> lst;
            string sqlQuery = " EXEC [shoppingnetwork].[shoppingnetworkmenuget]   @iduser, @idnetwork";
            lst = this.Set<shoppingnetworkmenugetResult>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@idnetwork", idnetwork)
                
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }


        public List<dbMessage> sp_shoppingnetworktelldelete(
        string iduser,
  string token,
  long idnetwork,
  string tell

   )
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [shoppingnetwork].[shoppingnetworktelldelete]  @iduser, @token,@idnetwork,@tell ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                 , new SqlParameter("@idnetwork", idnetwork)
                 , new SqlParameter("@tell", tell)
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }

        public List<dbMessage> sp_shoppingnetworktellcreate(
          string iduser ,
    string token ,
	long idnetwork ,
    string tell 

     )
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [shoppingnetwork].[shoppingnetworktellcreate]  @iduser, @token,@idnetwork,@tell ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                 , new SqlParameter("@idnetwork", idnetwork)
                 , new SqlParameter("@tell", tell)
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }


        public List<dbMessage> sp_networktypenetworkUpdate(
         string iduser,
   string token,
   long idnetwork,
   int idtype

    )
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [privatebase].[networktypenetworkupdate]   @iduser,@token,@idnetwork,@idtype ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                 , new SqlParameter("@idnetwork", idnetwork)
                 , new SqlParameter("@idtype", idtype)
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }




        public List<networkshoppingdetailsgResult> sp_networkshoppingdetailsget(
        string iduser,
        string token,
        long idnetwork
      )
        {
            //try
            //{

            List<networkshoppingdetailsgResult> lst;
            string sqlQuery = " EXEC [shoppingnetwork].[networkshoppingdetailsget]  @iduser,@token, @idnetwork";
            lst = this.Set<networkshoppingdetailsgResult>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                 , new SqlParameter("@idnetwork", idnetwork)
                ).ToList();

            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }



        public List<dbMessage> sp_networkshoppingcreate(
         int idproductshoppingtype ,
    string namenetwork ,
	string iduser,
	string token 
      )
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [shoppingnetwork].[networkshoppingcreate]  @idproductshoppingtype,@namenetwork, @iduser,@token  ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@idproductshoppingtype", idproductshoppingtype)
                 , new SqlParameter("@namenetwork", namenetwork)
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }



        public List<dbMessage> sp_menucreate(
          String iduser,
          String token,
          long idnetwork,
          String name,
          String description,
          decimal money,
          decimal moneyuser,
          int idunit,
          String datestart,
          String dateend,
          String path
    
        )
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [shoppingnetwork].[menucreate]  @iduser,@token,@idnetwork,@name,@description,@money,@moneyuser,@idunit,@datestart,@dateend,@path ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                 , new SqlParameter("@idnetwork", idnetwork)
                 , new SqlParameter("@name", name)
                 , new SqlParameter("@description", description)
                 , new SqlParameter("@money", money)
                 , new SqlParameter("@moneyuser", moneyuser)
                 , new SqlParameter("@idunit", idunit)
                 , new SqlParameter("@datestart", datestart)
                 , new SqlParameter("@dateend", dateend)
                 , new SqlParameter("@path", path)
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }


        public List<networksettingusergetResult> sp_networksettinguserget(
          long idnetwork,
            string iduser,
         string token
        )
        {
            //try
            //{
            List<networksettingusergetResult> lst;
            string sqlQuery = " EXEC [privatebase].[networksettinguserget] @idnetwork,  @iduser ,@token ";
            lst = this.Set<networksettingusergetResult>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@idnetwork", idnetwork)
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                
               
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }



        public List<dbMessage> sp_networksettinguserdelete(
           string iduser,
           string token,
           long idnetwork,
           int idsettingtype)
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [privatebase].[networksettinguserdelete]  @iduser ,@token ,@idnetwork, @idsettingtype ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                 , new SqlParameter("@idnetwork", idnetwork)
                 , new SqlParameter("@idsettingtype", idsettingtype)
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }


        public List<dbMessage> sp_networksettingusercreate(
            string iduser,
            string token,
            long idnetwork,
            int idsettingtype)
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [privatebase].[networksettingusercreate]  @iduser ,@token ,@idnetwork, @idsettingtype ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                 , new SqlParameter("@idnetwork", idnetwork)
                 , new SqlParameter("@idsettingtype", idsettingtype)
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }


        public List<dbMessage> sp_networkshoppinggeodelete(long idnetwork,
       
           string iduser,
   string token)
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [shoppingnetwork].[networkshoppinggeodelete]  @idnetwork,@iduser,@token";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@idnetwork", idnetwork)
                
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }

        public List<dbMessage> sp_networkshoppinggeocreate(long idnetwork,
          string geo,
            string iduser,
    string token)
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [shoppingnetwork].[networkshoppinggeocreate]  @idnetwork,@geo,@iduser,@token";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@idnetwork", idnetwork)
                 , new SqlParameter("@geo", geo)
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }


        public List<productshoppingtypelist> sp_productshoppingtypealllist(
              double latitude,
          double longitude,
                 int distance)
        {
            //try
            //{
            List<productshoppingtypelist> lst;
            string sqlQuery = " EXEC [shoppingnetwork].[productshoppingtypealllist] @geouser,@distance";
            lst = this.Set<productshoppingtypelist>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@geouser", ("Point(" + latitude + " " + longitude + ")").Replace('/', '.'))
                 , new SqlParameter("@distance", distance)
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }

        public List<productshoppingtypelist> sp_productshoppingtypeonetypelist(
          long idproductshoppingtype,
          double latitude,
          double longitude,
          int distance)
        {
            //try
            //{

            List<productshoppingtypelist> lst;
            string sqlQuery = " EXEC [shoppingnetwork].[productshoppingtypeonetypelist]  @idproductshoppingtype,@geouser,@distance";


           

            lst = this.Set<productshoppingtypelist>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@idproductshoppingtype", idproductshoppingtype)
                 , new SqlParameter("@geouser", ("Point(" + latitude + " " + longitude + ")").Replace('/', '.'))
                 , new SqlParameter("@distance", distance)
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }


        public List<productshoppingtypelist> sp_productshoppingtypelist(string namesearch,
          double latitude,
          double longitude,
          int distancefilter,
          int moneyfilter,
          int distance)
        {
            //try
            //{
            List<productshoppingtypelist> lst;
            string sqlQuery = " EXEC [shoppingnetwork].[productshoppingtypelist] @namesearch,@geouser,@distancefilter,@moneyfilter,@distance ";
            lst = this.Set<productshoppingtypelist>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@namesearch", namesearch)
                 , new SqlParameter("@geouser", ("Point(" + latitude + " " + longitude + ")").Replace('/', '.'))
                 , new SqlParameter("@distancefilter", distancefilter) 
                 , new SqlParameter("@moneyfilter", moneyfilter)
                 , new SqlParameter("@distance", distance)
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }

        public List<productshoppingsubtypeautocompletelist> sp_productshoppingsubtypeautocompletelist(
                string namesearch
        )
        {
            //try
            //{
            List<productshoppingsubtypeautocompletelist> lst;
            string sqlQuery = " EXEC [shoppingnetwork].[productshoppingsubtypeautocompletelist]  @namesearch";
            lst = this.Set<productshoppingsubtypeautocompletelist>().FromSqlRaw(sqlQuery
                , new SqlParameter("@namesearch", namesearch)).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }



        public List<dbMessage> sp_UserCreate(string mobile, string pass, string code, string name)
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [Security].[_UserCreate] @mobile,@code,@pass,@name ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@mobile", mobile)
                 , new SqlParameter("@code", code)
                 , new SqlParameter("@pass", pass)
                 , new SqlParameter("@name", name)
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }


        public List<dbMessage> sp_UsernewPass(string mobile, string pass, string code)
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [Security].[_UsernewPass] @mobile,@code,@pass ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@mobile", mobile)
                 , new SqlParameter("@code", code)
                 , new SqlParameter("@pass", pass)
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }

        public List<dbMessage> sp_UserLoginPass(string mobile, string pass, int idsoftwaremodel)
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [Security].[_UserLoginPass] @mobile,@pass,@idsoftwaremodel";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@mobile", mobile)
                 , new SqlParameter("@pass", pass)
                 , new SqlParameter("@idsoftwaremodel", idsoftwaremodel)
                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }



        public List<networkSocialGetuserResult> sp_networkSocialGetuser(
         string   iduser,
       	 string  token ,
         long	 network 
            )
        {
            //try
            //{
        List<networkSocialGetuserResult> lst;
            string sqlQuery = " EXEC [privatebase].[networkSocialGetuser] @iduser,@token,@network";
            lst = this.Set<networkSocialGetuserResult>().FromSqlRaw(sqlQuery
                 , new SqlParameter("@iduser", iduser)
                 , new SqlParameter("@token", token)
                 , new SqlParameter("@network", network)

                ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }

      

        public List<provinceGetResult> sp_provinceGet()
        {
            //try
            //{
            List<provinceGetResult> lst;
            string sqlQuery = " EXEC [base].[provinceGet] ";
            lst = this.Set<provinceGetResult>().FromSqlRaw(sqlQuery).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }



        public List<countyGetidResult> sp_countyGetid(
int @idprovince

     )
        {
            //try
            //{
            List<countyGetidResult> lst;
            string sqlQuery = " EXEC [base].[countyGetid] @idprovince";
            lst = this.Set<countyGetidResult>().FromSqlRaw(sqlQuery
              , new SqlParameter("@idprovince", idprovince)
                

            ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            return lst;

        }


        public List<citygetidResult> sp_citygetid(
int  @idprovince ,
int @idcounty 
     )
        {
            //try
            //{
            List<citygetidResult> lst;
            string sqlQuery = " EXEC [base].[citygetid] @idprovince,@idcounty";
            lst = this.Set<citygetidResult>().FromSqlRaw(sqlQuery
              , new SqlParameter("@idprovince", idprovince)
                , new SqlParameter("@idcounty", idcounty)

            ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            return lst;

        }




        public List<networkprofilemediaGetResult> sp_networkprofilemediaGet(
  string iduser,
string token,
long idnetwork
     )
        {
            //try
            //{
            List<networkprofilemediaGetResult> lst;
            string sqlQuery = " EXEC [privatebase].[networkprofilemediaGet] @iduser,@token,@idnetwork";
            lst = this.Set<networkprofilemediaGetResult>().FromSqlRaw(sqlQuery
              , new SqlParameter("@iduser", iduser)
                , new SqlParameter("@token", token)
                , new SqlParameter("@idnetwork", idnetwork)


            ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            return lst;

        }


        public List<dbMessage> sp_networkblockCreate(
string iduser,
string code,
long @idnetwork
  )
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [privatebase].[networkblockCreate] @iduser,@code,@idnetwork";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
              , new SqlParameter("@iduser", iduser)
                , new SqlParameter("@code", code)
                , new SqlParameter("@idnetwork", idnetwork)


            ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            return lst;

        }



        public List<networkSocialGetaboutResult> sp_networkSocialGetabout(
  string iduser,
string token,
long  network 
     )
        {
            //try
            //{
            List<networkSocialGetaboutResult> lst;
            string sqlQuery = " EXEC [privatebase].[networkSocialGetabout] @iduser,@token,@network";
            lst = this.Set<networkSocialGetaboutResult>().FromSqlRaw(sqlQuery
              , new SqlParameter("@iduser", iduser)
              , new SqlParameter("@token", token)
                , new SqlParameter("@network", network)

  
            ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            return lst;

        }





        public List<networkSocialuserFllowingGatResult> sp_networkSocialuserFllowingGat(
  string iduser,
string token,
  long  network ,
  int  PageNo ,
int    RowCountPerPage 
     )
        {
            //try
            //{
            List<networkSocialuserFllowingGatResult> lst;
            string sqlQuery = " EXEC [privatebase].[networkSocialuserFllowingGat]  @iduser,@token,@network,@PageNo,@RowCountPerPage";
            lst = this.Set<networkSocialuserFllowingGatResult>().FromSqlRaw(sqlQuery
              , new SqlParameter("@iduser", iduser)
                , new SqlParameter("@token", token)
                , new SqlParameter("@network", network)
      
                , new SqlParameter("@PageNo", PageNo)
                , new SqlParameter("@RowCountPerPage", RowCountPerPage)
            ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            return lst;

        }


                    
        public List<networkSocialstateuserGatResult> sp_networkSocialstateuserGat(
  string iduser,
string token,
long network,
int idstate,
int idtype,
int PageNo,
 int RowCountPerPage
     )
        {
            //try
            //{
            List<networkSocialstateuserGatResult> lst;
            string sqlQuery = " EXEC [privatebase].[networkSocialstateuserGat]   @iduser,@token,@network,@idstate,@idtype,@PageNo,@RowCountPerPage";
            lst = this.Set<networkSocialstateuserGatResult>().FromSqlRaw(sqlQuery
              , new SqlParameter("@iduser", iduser)
                , new SqlParameter("@token", token)
                , new SqlParameter("@network", network)
                , new SqlParameter("@idstate", idstate)
                , new SqlParameter("@idtype", idtype)
                , new SqlParameter("@PageNo", PageNo)
                , new SqlParameter("@RowCountPerPage", RowCountPerPage)
            ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            return lst;

        }




        public List<valuetypeGetResult> sp_valuetypeGet(string iduser,string code)
         {
            //try
            //{
            List<valuetypeGetResult> lst;
            string sqlQuery = " EXEC [value].[valuetypeGet]   @iduser,@code";
            lst = this.Set<valuetypeGetResult>().FromSqlRaw(sqlQuery
              , new SqlParameter("@iduser", iduser)
                , new SqlParameter("@code", code)
            ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            return lst;

         }



        public List<UserRolesGetResult> sp_UserRolesGet(string iduser,
 string code)
        {
            //try
            //{
            List<UserRolesGetResult> lst;
            string sqlQuery = " EXEC [driver].[UserRolesGet]  @iduser,@code";
            lst = this.Set<UserRolesGetResult>().FromSqlRaw(sqlQuery
              , new SqlParameter("@iduser", iduser)
                , new SqlParameter("@code", code)
            ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            return lst;

        }


        public List<valuebodyGetResult> sp_valuebodyGet(string iduser,
   string code)
        {
            //try
            //{
            List<valuebodyGetResult> lst;
            string sqlQuery = " EXEC [value].[valuebodyGet]   @iduser,@code";
            lst = this.Set<valuebodyGetResult>().FromSqlRaw(sqlQuery
              , new SqlParameter("@iduser", iduser)
                , new SqlParameter("@code", code)
            ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            return lst;

        }


    public List<dbMessage> sp_profileuserphoneCreate(
                  string iduser,
                  string token,
                 string phonenumber
          )
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [privatebase].[profileuserphoneCreate]  @iduser,@token,@phonenumber";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                , new SqlParameter("@iduser", iduser)
                , new SqlParameter("@token", token)
                , new SqlParameter("@phonenumber", phonenumber)
             


              ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }

        public List<dbMessage> sp_profileuserregioncityCreate(
                  string iduser,
                  string token,
                  int @idcity ,
                  int @idcounty ,
                  int @idprovince 
          )
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [privatebase].[profileuserregioncityCreate]  @iduser,@token,@idcity,@idcounty,@idprovince ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                , new SqlParameter("@iduser", iduser)
                , new SqlParameter("@token", token)
                , new SqlParameter("@idcity", idcity)
                , new SqlParameter("@idcounty", idcounty)
                , new SqlParameter("@idprovince", idprovince)


              ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }



        public List<dbMessage> sp_networknicknameCreate(
                  string iduser,
                  string token,
                  string nickname,
	              long network 
          )
        {
            //try
            //{
        List<dbMessage> lst;
            string sqlQuery = " EXEC [privatebase].[networknicknameCreate]  @iduser,@token,@nickname,@network";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                , new SqlParameter("@iduser", iduser)
                , new SqlParameter("@token", token)
                , new SqlParameter("@nickname", nickname)
                , new SqlParameter("@network", network)
               

              ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }
        
      



        public List<dbMessage> sp_UserProfileCreate(
                  string iduser,
                  string token
                ,bool Idsex 

           , string name 
           
           ,DateTime birthday 
            
           ,int idcity  
           ,int idcounty  
		   ,int idproince  
          )
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [privatebase].[UserProfileCreate]  @iduser,@token,@Idsex,@name,@birthday,@idcity,@idcounty,@idproince";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                , new SqlParameter("@iduser", iduser)
                , new SqlParameter("@token", token)
                , new SqlParameter("@Idsex", Idsex)
                , new SqlParameter("@name", name)
                , new SqlParameter("@birthday", birthday)
                , new SqlParameter("@idcity", idcity)
                , new SqlParameter("@idcounty", idcounty)
                , new SqlParameter("@idproince", idproince)


              ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }


        public List<dbMessage> sp_networkprofilemediaCreate(
     string iduser ,
    string token,
	long idnetwork ,
   byte idtype ,
	string discription,
	string  path
          )
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [privatebase].[networkprofilemediaCreate]  @iduser,@token,@idnetwork,@idtype,@discription,@path";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                , new SqlParameter("@iduser", iduser)
                , new SqlParameter("@token", token)
                , new SqlParameter("@idnetwork", idnetwork)
                , new SqlParameter("@idtype", idtype)
                , new SqlParameter("@discription", discription)
                , new SqlParameter("@path", path)
              

              ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }


        public List<dbMessage> sp_networkprofilemediadelete(
         string iduser,
         string token,
       long   idnetwork ,
   long idmediaprofile 
          )
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [privatebase].[networkprofilemediadelete]  @iduser,@token,@idnetwork,@idmediaprofile";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                , new SqlParameter("@iduser", iduser)
                , new SqlParameter("@token", token)
                , new SqlParameter("@idnetwork", idnetwork)
                , new SqlParameter("@idclient", idmediaprofile)
              
              ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }

        public List<dbMessage> sp_networkuserCreate(
         string iduser,
      string   code ,
  long idnetworkBase ,
  int  idstate ,
int	idtype ,
string	idu  )
        {
            //try
            //{
        List<dbMessage> lst;
            string sqlQuery = " EXEC [privatebase].[networkuserCreate]  @iduser,@code, @idnetworkBase, @idstate,@idtype,@idu ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                , new SqlParameter("@iduser", iduser)
                , new SqlParameter("@code", code)
                , new SqlParameter("@idnetworkBase", idnetworkBase)
                , new SqlParameter("@idstate", idstate)
                , new SqlParameter("@idtype", idtype)
                , new SqlParameter("@idu", idu)
              ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }



        public List<dbMessage> sp_valuebodyCreate(
         string  iduser  ,
         string  token   ,
            byte idvalue ,
           long  idclient 
       ,decimal  value
      ,DateTime  date )
        {
            //try
            //{
        List<dbMessage> lst;
            string sqlQuery = " EXEC [value].[valuebodyCreate]  @iduser,@token,@idvalue,@idclient,@value,@date ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                , new SqlParameter("@iduser", iduser)
                , new SqlParameter("@token", token)
                , new SqlParameter("@idvalue", idvalue)
                , new SqlParameter("@idclient", idclient)
                , new SqlParameter("@value", value)
                , new SqlParameter("@date", date)
              ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }




        public List<dbMessage> sp_networkuserupdateCreate(
    string iduser,
string code,
 int state)
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [privatebase].[networkuserupdateCreate]  @iduser,@code,@state ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                , new SqlParameter("@iduser", iduser)
                , new SqlParameter("@code", code)
                , new SqlParameter("@state", state)
              ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }

        public List<profileuserGetResult> sp_profileuserGet(
       string iduser,
   string token)
        {
            //try
            //{
            List<profileuserGetResult> lst;
            string sqlQuery = " EXEC [privatebase].[profileuserGet]  @iduser,@token ";
            lst = this.Set<profileuserGetResult>().FromSqlRaw(sqlQuery
                , new SqlParameter("@iduser", iduser)
                , new SqlParameter("@token", token)
               
              ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }

        public List<dbMessage> sp_profileusernameCreate(
            string iduser,
        string code,
        string name)
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [privatebase].[profileusernameCreate]  @iduser,@code,@name ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                , new SqlParameter("@iduser", iduser)
                , new SqlParameter("@code", code)
                , new SqlParameter("@name", name)
              ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }

        public List<dbMessage> sp_profileuserdescriptionCreate(
                  string iduser,
              string code,
              string discription)
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [privatebase].[profileuserdescriptionCreate]  @iduser,@code,@discription ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                , new SqlParameter("@iduser", iduser)
                , new SqlParameter("@code", code)
                , new SqlParameter("@discription", discription)
              ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }



        public List<dbMessage> sp_profileuserbirthdayCreate(
            string iduser,
        string code,
        DateTime berth)
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [privatebase].[profileuserbirthdayCreate]  @iduser,@code,@berth ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                , new SqlParameter("@iduser", iduser)
                , new SqlParameter("@code", code)
                , new SqlParameter("@berth", berth)
              ).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }


        public List<dbMessage> sp_networkpostdelete(string iduser,
             string code,
             long idnetwork,
             long idpost)
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC  [post].[networkpostdelete]  @iduser,@code,@idnetwork,@idpost ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                , new SqlParameter("@iduser", iduser)
                , new SqlParameter("@code", code)
                , new SqlParameter("@idnetwork", idnetwork)
               , new SqlParameter("@idpost", idpost)).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }

        public List<dbMessage> sp_networkpostcreate(string iduser,
       string code,
       long idnetwork,
       byte posttype,
       string name,
       string discription)
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC  [post].[networkpostcreate]  @iduser,@code,@idnetwork,@posttype,@name,@discription ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery
                , new SqlParameter("@iduser", iduser)
                , new SqlParameter("@code", code)
                , new SqlParameter("@idnetwork", idnetwork)
                , new SqlParameter("@posttype", posttype)
                , new SqlParameter("@name", name)
                 , new SqlParameter("@discription", discription)).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }


        public List<networkpostGetUserResult> sp_networkpostGet(string iduser, string code,long idnetwork, int PageNo, int RowCountPerPage)
        {
            //try
            //{
            List<networkpostGetUserResult> lst;
            string sqlQuery = " EXEC  [post].[networkpostGet]  @iduser,@code,@idnetwork,@PageNo,@RowCountPerPage ";
            lst = this.Set<networkpostGetUserResult>().FromSqlRaw(sqlQuery
                , new SqlParameter("@iduser", iduser)
                , new SqlParameter("@code", code)
                , new SqlParameter("@idnetwork", idnetwork)
                , new SqlParameter("@PageNo", PageNo)
                , new SqlParameter("@RowCountPerPage", RowCountPerPage)).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }


        public List<networkpostGetUserResult> sp_networkpostGetUser(string iduser, string code,int PageNo,int RowCountPerPage)
        {
            //try
            //{
            List<networkpostGetUserResult> lst;
            string sqlQuery = " EXEC  [post].[networkpostGetUser]  @iduser,@code,@PageNo,@RowCountPerPage ";
            lst = this.Set<networkpostGetUserResult>().FromSqlRaw(sqlQuery
                , new SqlParameter("@iduser", iduser)
                , new SqlParameter("@code", code)
                , new SqlParameter("@PageNo", PageNo)
                , new SqlParameter("@RowCountPerPage", RowCountPerPage)).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }

        public List<networkuserupdateGetResult> sp_networkuserupdateGet(string iduser, string code)
        {
            //try
            //{
            List<networkuserupdateGetResult> lst;
            string sqlQuery = " EXEC  [privatebase].[networkuserupdateGet]  @iduser,@code ";
            lst = this.Set<networkuserupdateGetResult>().FromSqlRaw(sqlQuery, new SqlParameter("@iduser", iduser)
                , new SqlParameter("@code", code)).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }



        public List<networkuserupdateGetDateResult> sp_networkuserupdateGetDate(string iduser, string code)
        {
            //try
            //{
            List<networkuserupdateGetDateResult> lst;
            string sqlQuery = " EXEC [privatebase].[networkuserupdateGetDate]  @iduser,@code ";
            lst = this.Set<networkuserupdateGetDateResult>().FromSqlRaw(sqlQuery, new SqlParameter("@iduser", iduser)
                , new SqlParameter("@code", code)).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }



        public List<networkuserGetResult> sp_networkuserGet(string iduser,string token)
        {
            //try
            //{
            List<networkuserGetResult> lst;
            string sqlQuery = "EXEC [privatebase].[networkuserGet]  @iduser,@token ";
            lst = this.Set<networkuserGetResult>().FromSqlRaw(sqlQuery,
                  new SqlParameter("@iduser", iduser)
                , new SqlParameter("@token", token)).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }



        /***************انتهای پروژه ستاره ورزشی******************/

        public List<UserProfileGat> sp_UserProfileGat(int Idnetwork)
        {
            //try
            //{
            List<UserProfileGat> lst;
            string sqlQuery = " EXEC [privatebase].[UserProfileGat]  @Idnetwork ";
            lst = this.Set<UserProfileGat>().FromSqlRaw(sqlQuery,
                  new SqlParameter("@Idnetwork", Idnetwork)).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }


        public List<dbMessage> sp_UserProfileCreate(
            string iduser,
            string token,
            bool Idsex,
            string name,
            string birthday,
            int idcity,
            int idcounty,
            int idproince)
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [privatebase].[UserProfileCreate]  @iduser, @token, @Idsex,@name,@birthday,@idcity,@idcounty,@idproince ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery,
                  new SqlParameter("@iduser", iduser),
                  new SqlParameter("@token", token),
                  new SqlParameter("@Idsex", Idsex),
                  new SqlParameter("@name", name),
                  new SqlParameter("@birthday", birthday),
                  new SqlParameter("@idcity", idcity),
                  new SqlParameter("@idcounty", idcounty),
                  new SqlParameter("@idproince", idproince)).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }



        public List<networkGetAllUserResult> sp_networkGetAllUser(string iduser, string token, byte @networktype)
        {
            //try
            //{
            List<networkGetAllUserResult> lst;
            string sqlQuery = " EXEC [privatebase].[networkGetAllUser]  @iduser, @token, @networktype ";
            lst = this.Set<networkGetAllUserResult>().FromSqlRaw(sqlQuery,
                  new SqlParameter("@iduser", iduser),
                  new SqlParameter("@token", token),
                  new SqlParameter("@networktype", networktype)).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }


        public List<dbMessage> sp_networkchecknickname(string iduser, string token, string nickname)
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [privatebase].[networkchecknickname]  @iduser, @token, @nickname ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery,
                  new SqlParameter("@iduser", iduser),
                  new SqlParameter("@token", token),
                  new SqlParameter("@nickname", nickname)).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }


        public List<dbMessage> sp_networkcreatePro(string iduser,string token ,byte networktype,string nickname)
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [privatebase].[networkcreatePro]  @iduser,@token,@networktype,@nickname ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery,
                  new SqlParameter("@iduser", iduser),
                  new SqlParameter("@token", token),
                  new SqlParameter("@networktype", networktype),
                  new SqlParameter("@nickname", nickname)).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }

        public List<sportmusleGetAllResult> sp_sportmusleGetAll(int idsport)
        {
            //try
            //{
            List<sportmusleGetAllResult> lst;
            string sqlQuery = " EXEC [move].[sportmusleGetAll]  @idsport ";
            lst = this.Set<sportmusleGetAllResult>().FromSqlRaw(sqlQuery,
                  new SqlParameter("@idsport", idsport)).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }


        public List<movesportGetResult> sp_movesportGet(int idsport,int idmusle)
        {
            //try
            //{
            List<movesportGetResult> lst;
            string sqlQuery = " EXEC [move].[movesportGet] @idsport,@idmusle  ";
            lst = this.Set<movesportGetResult>().FromSqlRaw(sqlQuery,
                  new SqlParameter("@idsport", idsport),
                  new SqlParameter("@idmusle", idmusle)).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }

        public List<Moveinfo> sp_moveinfoGet(int idmove)
        {
            //try
            //{
            List<Moveinfo> lst;
            string sqlQuery = " EXEC [move].[moveinfoGet]  @idmove ";
            lst = this.Set<Moveinfo>().FromSqlRaw(sqlQuery,
                  new SqlParameter("@idmove", idmove)).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }


        public List<Vip> sp_vipGet()
        {

            // Initialization.  

            //try

            //{

            List<Vip> lst;

            string sqlQuery = " EXEC [pay].[vipGet]";

            lst = this.Set<Vip>().FromSqlRaw(sqlQuery).ToList();

            //}

            //catch (Exception ex)

            //{

            //    throw ex;

            //}

            // Info.  

            return lst;

        }


        public List<Musle> sp_movemusleGetAll()
        {

            // Initialization.  

            //try

            //{

            List<Musle> lst;

            string sqlQuery = " EXEC [move].[movemusleGetAll]";

            lst = this.Set<Musle>().FromSqlRaw(sqlQuery).ToList();

            //}

            //catch (Exception ex)

            //{

            //    throw ex;

            //}

            // Info.  

            return lst;

        }



        public List<moveGet> sp_moveGet(int idmove)
        {
            //try
            //{
            List<moveGet> lst;
            string sqlQuery = " EXEC [move].[moveGet]  @idmove ";
            lst = this.Set<moveGet>().FromSqlRaw(sqlQuery,
                  new SqlParameter("@idmove", idmove)).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }


        public List<sportmusleResut> sp_sportmusle(int sport)
        {
            //try
            //{
            List<sportmusleResut> lst;
            string sqlQuery = " EXEC [move].[_sportmusle] @sport ";
            lst = this.Set<sportmusleResut>().FromSqlRaw(sqlQuery,
                  new SqlParameter("@sport", sport)
                )
                .ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }

        public List<UserProfileGat> sp_UserProfileGat(long Idnetwork)
        {
            //try
            //{
            List<UserProfileGat> lst;
            string sqlQuery = " EXEC [privatebase].[UserProfileGat] @Idnetwork ";
            lst = this.Set<UserProfileGat>().FromSqlRaw(sqlQuery,
                  new SqlParameter("@Idnetwork", Idnetwork)
                )
                .ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }


        public List<dbMessage> sp_networkUserCreateContent(string iduser, string token, DataTable dt)
        {

            //try
            //{
            List<dbMessage> lst;

            SqlParameter tellParameter = new SqlParameter
            {
                ParameterName = "@tell",
                SqlDbType = SqlDbType.Structured,
                TypeName = "privatebase.listtell",
                Direction = ParameterDirection.Input,
                Value = dt
            };

            SqlParameter iduserParameter = new SqlParameter
            {
                ParameterName = "@iduser",
                SqlDbType = SqlDbType.NVarChar,
                Direction = ParameterDirection.Input,
                Value = iduser
            };

            SqlParameter codeParameter = new SqlParameter
            {
                ParameterName = "@code",
                SqlDbType = SqlDbType.NVarChar,
                Direction = ParameterDirection.Input,
                Value = token
            };

            string sqlQuery = " EXEC [privatebase].[networkUserCreateContent]  @iduser,@code,@tell ";

            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery,
                  iduserParameter
                , codeParameter
                , tellParameter
                )
                .ToList();


            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            return lst;

        }

        public List<networkGetResult> sp_networkGet(string iduser, string token,byte networktype)
        {

            //try
            //{
            List<networkGetResult> lst;
            string sqlQuery = " EXEC [privatebase].[networkGet] @iduser,@token,@networktype ";
            lst = this.Set<networkGetResult>().FromSqlRaw(sqlQuery,
                  new SqlParameter("@iduser", iduser)
                , new SqlParameter("@token", token)
                , new SqlParameter("@networktype", networktype))
                .ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            return lst;

        }


        public List<UserSecruity> sp_UserGet(string mobile)
        {
         //try
         //{
            List<UserSecruity> lst;
            string sqlQuery = "EXEC [Security].[UserGet] @mobile ";
            lst = this.Set<UserSecruity>().FromSqlRaw(sqlQuery,
                  new SqlParameter("@mobile", mobile)).ToList();
         //}
         //catch (Exception ex)
         //{
         // throw ex;
         //}

            return lst;

        }

        public List<dbMessage> sp_UserSMSCode(string mobile,string code)
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = "EXEC [Security].[_UserSMSCode] @mobile,@code ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery,
                  new SqlParameter("@mobile", mobile)
                , new SqlParameter("@code", code))
                .ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }
        
        public List<dbMessage> sp_UserSMSChack(string mobile,string code,int typesms)
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = "EXEC [Security].[_UserSMSChack] @mobile,@code,@typesms ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery,
                  new SqlParameter("@mobile", mobile)
                , new SqlParameter("@code", code)
                , new SqlParameter("@typesms", typesms)
                )
                .ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }


        public List<dbMessage> sp_UserSMS(string mobile,byte idsoftwaremodel,byte idusertypesms)
        {
            //try
            //{
            List<dbMessage> lst;
            string sqlQuery = " EXEC [Security].[_UserSMS] @mobile,@idsoftwaremodel,@idusertypesms ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery, new SqlParameter("@mobile", mobile)
                , new SqlParameter("@idsoftwaremodel", idsoftwaremodel)
                , new SqlParameter("@idusertypesms", idusertypesms)).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }

        public List<Sport> sp_Sport()
        {

            // Initialization.  

            //try

            //{

            List<Sport> lst;

            string sqlQuery = " EXEC [move].[_Sport] ";

            lst = this.Set<Sport>().FromSqlRaw(sqlQuery).ToList();

            //}

            //catch (Exception ex)

            //{

            //    throw ex;

            //}

            // Info.  

            return lst;

        }


        /***************انتهای پروژه ستاره ورزشی******************/

        public List<Post> sp_postgetPostMenuall()
        {

            // Initialization.  

            //try

            //{

            List<Post> lst;

            string sqlQuery = " EXEC [content].[sp_postgetPostMenuall] ";

            lst = this.Set<Post>().FromSqlRaw(sqlQuery).ToList();

            //}

            //catch (Exception ex)

            //{

            //    throw ex;

            //}

            // Info.  

            return lst;

        }


        public List<Post> sp_postgetPostMenuid(long idmenu)
        {
            //try
            //{
            List<Post> lst;
            string sqlQuery = " EXEC [content].[sp_postgetPostMenuid] @idmenu";
            lst = this.Set<Post>().FromSqlRaw(sqlQuery,
                new SqlParameter("@idmenu", idmenu)).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;

        }

        public List<Post> sp_postgetPostPageing(long PageNumber,long RowsCountInEachPage)
        {
            //try
            //{
            List<Post> lst ;
            string sqlQuery = " EXEC [content].[sp_postgetPostPageing] @PageNumber,@RowsCountInEachPage";
            lst = this.Set<Post>().FromSqlRaw(sqlQuery, 
                new SqlParameter("@PageNumber", PageNumber),
                new SqlParameter("@RowsCountInEachPage", RowsCountInEachPage)
                ).ToList() ;
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            

            return lst;

        }


        public List<Post> sp_postget(long id)
        {

            // Initialization.  

            //try

            //{

            List<Post> lst = new List<Post>();

            string sqlQuery = " EXEC [content].[sp_postget] @id ";

            lst = this.Set<Post>().FromSqlRaw(sqlQuery,
               new SqlParameter("@id", id)).AsEnumerable().ToList();

            //}

            //catch (Exception ex)

            //{

            //    throw ex;

            //}

            // Info.  

            return lst;

        }

        public List<Post> sp_postgetPost()
        {

            // Initialization.  

            //try

            //{

            List<Post> lst = new List<Post>();

            string sqlQuery = " EXEC [content].[sp_postgetPost] ";

            lst = this.Set<Post>().FromSqlRaw(sqlQuery).AsEnumerable().ToList();

            //}
            
            //catch (Exception ex)
            
            //{
            
            //    throw ex;
            
            //}

            // Info.  

            return lst;

        }

        public List<Post> sp_postgetNews()
        {
            // Initialization.  

            //try
            //{

            List<Post> lst = new List<Post>();

            string sqlQuery = " EXEC  [content].[sp_postgetNews]";


            lst = this.Set<Post>().FromSqlRaw(sqlQuery).AsEnumerable().ToList();

            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            // Info.  

            return lst;

        }

        public List<Post> sp_postgetImageText()
        {
            // Initialization.  

            //try
            //{

            List<Post> lst = new List<Post>();

            string sqlQuery = " EXEC  [content].[sp_postgetImageText]";


            lst = this.Set<Post>().FromSqlRaw(sqlQuery).AsEnumerable().ToList();

            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            // Info.  
            return lst;
        }

        public List<Post> sp_postgetPadKast()
        {
            // Initialization.  

            //try
            //{

            List<Post> lst = new List<Post>();

            string sqlQuery = " EXEC   [content].[sp_postgetPadKast] ";


            lst = this.Set<Post>().FromSqlRaw(sqlQuery).AsEnumerable().ToList();

            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            // Info.  
            return lst;
        }

        public List<Post> sp_postgetSlide()
        {
            // Initialization.  

            //try
            //{

            List<Post> lst = new List<Post>();

            string sqlQuery = " EXEC  [content].[sp_postgetSlide] ";


            lst = this.Set<Post>().FromSqlRaw(sqlQuery).AsEnumerable().ToList();

            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            // Info.  
            return lst;
        }

        public List<Post> sp_postgetMuscic()
        {
            // Initialization.  

            //try
            //{

            List<Post> lst = new List<Post>();

            string sqlQuery = " EXEC  [content].[sp_postgetMuscic] ";


            lst = this.Set<Post>().FromSqlRaw(sqlQuery).AsEnumerable().ToList();

            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            // Info.  
            return lst;
        }

        public List<Post>  sp_postgetVIdeo()
        {
            // Initialization.  

            //try
            //{

            List<Post> lst = new List<Post>();

            string sqlQuery = " EXEC  [content].[sp_postgetVIdeo] ";


            lst = this.Set<Post>().FromSqlRaw(sqlQuery).AsEnumerable().ToList();

            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            // Info.  
            return lst;
        }

        public void sp_poststatisticsADD(long idpost)
        {
            // Initialization.  
          
            //try
            //{
            string sqlQuery = " EXEC  [content].[sp_poststatisticsADD1]  @dateday , @idpost ";

          
           var n= this.Database.ExecuteSqlRaw(sqlQuery, new SqlParameter("@dateday", DateTime.Now), new SqlParameter("@idpost", idpost));
            
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            // Info.  
          
        }
        public List<productautocompletelistmenu> sp_productsubmenucompletelist(string name)
        {
            // Initialization.  
            List<productautocompletelistmenu> lst = new List<productautocompletelistmenu>();
            //try
            //{



            string sqlQuery = " EXEC [store].[productsubmenucompletelist] @name  ";
            lst = this.Set<productautocompletelistmenu>().FromSqlRaw(sqlQuery,
               new SqlParameter("@name", (object)name ?? DBNull.Value)

              ).AsEnumerable().ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            // Info.  
            return lst;
        }
        public List<AspNetUsers1> sp_UserAllGet()
        {
            // Initialization.  
            List<AspNetUsers1> lst = new List<AspNetUsers1>();
            //try
            //{
            string sqlQuery = " EXEC  [Security].[UserAllGet]   ";
            lst = this.Set<AspNetUsers1>().FromSqlRaw(sqlQuery).AsEnumerable().ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            // Info.  
            return lst;
        }
        public List<AspNetUsers1> sp_UseridGet(string iduser)
        {
            // Initialization.  
            List<AspNetUsers1> lst = new List<AspNetUsers1>();
            //try
            //{
            string sqlQuery = " EXEC  [Security].[UseridGet]  @iduser ";
            lst = this.Set<AspNetUsers1>().FromSqlRaw(sqlQuery,
               new SqlParameter("@iduser", iduser)
              ).AsEnumerable().ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            // Info.  
            return lst;
        }

        public List<AspNetUsers1> sp_AspNetUserslikeEmail(string name)
        {
            // Initialization.  
           List< AspNetUsers1> lst = new List<AspNetUsers1>();
            //try
            //{
            string sqlQuery = " EXEC  [4519_reza].[AspNetUserslikeEmail]  @name  ";
            lst = this.Set<AspNetUsers1>().FromSqlRaw(sqlQuery,
               new SqlParameter("@name", name)
              ).AsEnumerable().ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            // Info.  
            return lst;
        }

        public PaymentProductViewModel sp_factorauthoritychecking(string authority)
        {
            // Initialization.  
            PaymentProductViewModel lst = new PaymentProductViewModel();
            //try
            //{



            string sqlQuery = " EXEC [store].[factorauthoritychecking] @authority  ";
            lst = this.Set<PaymentProductViewModel>().FromSqlRaw(sqlQuery,
               new SqlParameter("@authority", authority)
              ).AsEnumerable().FirstOrDefault();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            // Info.  
            return lst;
        }

        public PaymentProductViewModel sp_userfactorconfirm(string iduser)
        {
            // Initialization.  
            PaymentProductViewModel lst = new PaymentProductViewModel();
            //try
            //{



            string sqlQuery = " EXEC [store].[userfactorconfirm] @iduser  ";
            lst = this.Set<PaymentProductViewModel>().FromSqlRaw(sqlQuery,
               new SqlParameter("@iduser", iduser)
             
              ).AsEnumerable().FirstOrDefault();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            // Info.  
            return lst;
        }

        public dbMessage sp_aspnetusersupdate(AspNetUsers1 aspNet)
        {
            // Initialization.  
            dbMessage lst = new dbMessage();
            //try
            //{
            string sqlQuery = " EXEC [Security].[aspnetusersupdate] @iduser , @UserName,@NormalizedUserName,@EmailConfirmed," +
                "@PhoneNumberConfirmed ,@TwoFactorEnabled,@LockoutEnabled,@AccessFailedCount ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery,
               new SqlParameter("@iduser", aspNet.Id),
               new SqlParameter("@UserName", aspNet.UserName),
               new SqlParameter("@NormalizedUserName", aspNet.UserName.ToLower()),
               new SqlParameter("@EmailConfirmed", aspNet.EmailConfirmed),
               new SqlParameter("@PhoneNumberConfirmed", aspNet.PhoneNumberConfirmed),
               new SqlParameter("@TwoFactorEnabled", aspNet.TwoFactorEnabled),
               new SqlParameter("@LockoutEnabled", aspNet.LockoutEnabled),
               new SqlParameter("@AccessFailedCount", aspNet.AccessFailedCount)
              ).AsEnumerable().FirstOrDefault();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            // Info.  
            return lst;
        }

        public List<AspNetRole1> sp_aspnetroleslist()
        {
            // Initialization.  
           List<AspNetRole1> lst = new List<AspNetRole1>();
            //try
            //{
            string sqlQuery = " EXEC [Security].[aspnetroleslist]";
            lst = this.Set<AspNetRole1>().FromSqlRaw(sqlQuery).AsEnumerable().ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            // Info.  
            return lst;
        }


        public List<dbMessage> sp_spNetUserRolesDelete(string UserId, string RoleId)
        {
            // Initialization.  
           var lst = new List<dbMessage>();
            //try
            //{
            string sqlQuery = " EXEC [4519_yar].spNetUserRolesDelete @UserId,@RoleId ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery,
               new SqlParameter("@UserId", UserId),
               new SqlParameter("@RoleId", RoleId)).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            // Info.  

            return lst;
        }

        public List<AspNetRole1> sp_aspnetuserroleslist(string iduser)
        {
            // Initialization.  
            List<AspNetRole1> lst = new List<AspNetRole1>();
            //try
            //{
            string sqlQuery = " EXEC [Security].[aspnetuserroleslist] @iduser ";
            lst = this.Set<AspNetRole1>().FromSqlRaw(sqlQuery,
               new SqlParameter("@iduser", iduser)).ToList();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            // Info.  
           
            return lst;
        }

        public dbMessage sp_aspnetuserrolesinsert(string @iduser, string idrole)
        {
            // Initialization.  
            dbMessage lst = new dbMessage();
            //try
            //{
            string sqlQuery = " EXEC [Security].[aspnetuserrolesinsert] @iduser , @idrole ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery,
               new SqlParameter("@iduser", iduser),
               new SqlParameter("@idrole", idrole)
              ).AsEnumerable().FirstOrDefault();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            // Info.  
            return lst;
        }


        public dbMessage sp_aspnetuserrolesdelete(string @iduser, string idrole)
        {
            // Initialization.  
            dbMessage lst = new dbMessage();
            //try
            //{
            string sqlQuery = " EXEC [Security].[aspnetuserrolesdelete] @iduser , @idrole ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery,
               new SqlParameter("@iduser", iduser),
               new SqlParameter("@idrole", idrole)
              ).AsEnumerable().FirstOrDefault();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            // Info.  
            return lst;
        }



        public dbMessage sp_factorupdateforsuccessfulbuy(string authority, int idbankstate,string refid)
        {
            // Initialization.  
            dbMessage lst = new dbMessage();
            //try
            //{
            string sqlQuery = " EXEC [store].[factorupdateforsuccessfulbuy] @authority , @idbankstate,@refid ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery,
               new SqlParameter("@authority", authority),
               new SqlParameter("@idbankstate", idbankstate),
               new SqlParameter("@refid", refid)
              ).AsEnumerable().FirstOrDefault();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            // Info.  
            return lst;
        }


        public dbMessage sp_factorupdateforsyncbuyerror(string iduser, string idbankstate)
        {
            // Initialization.  
            dbMessage lst = new dbMessage();
            //try
            //{
            string sqlQuery = " EXEC [store].[factorupdateforsyncbuyerror] @iduser , @idbankstate ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery,
               new SqlParameter("@iduser", iduser),
               new SqlParameter("@idbankstate", idbankstate)
              ).AsEnumerable().FirstOrDefault();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            // Info.  
            return lst;
        }


        public dbMessage sp_subfactordelete(string iduser, string idfactorsub)
        {
            // Initialization.  
            dbMessage lst = new dbMessage();
            //try
            //{
            string sqlQuery = " EXEC [store].[subfactordelete] @iduser , @idfactorsub ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery,
               new SqlParameter("@iduser", iduser),
               new SqlParameter("@idfactorsub", idfactorsub)
              ).AsEnumerable().FirstOrDefault();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            // Info.  
            return lst;
        }



        public async Task<dbMessage> sp_productaddressdelete
            (
             string iduser,
             long idproductaddress
            )
        {
            // Initialization.  
            dbMessage lst = new dbMessage();
            //try
            //{
            string sqlQuery = "EXEC [store].[productaddressdelete] @iduser , @idproductaddress ";
            lst =  this.Set<dbMessage>().FromSqlRaw(sqlQuery,
               new SqlParameter("@iduser", iduser),
               new SqlParameter("@idproductaddress", idproductaddress)
              ).AsEnumerable().FirstOrDefault();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            // Info.  
            return lst;
        }

     


        public  dbMessage sp_subfactorupdate
            (
                string iduser ,
                string idfactorsub ,
                long   idproduct ,
                int    countsefaresh ,
                long   idproductcolor 
            )
        {
            // Initialization.  
            dbMessage lst = new dbMessage();
            //try
            //{
            string sqlQuery = "EXEC [store].[subfactorupdate] @iduser ,@idfactorsub , @idproduct , @countsefaresh , @idproductcolor ";
            lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery,
               new SqlParameter("@iduser", iduser),
               new SqlParameter("@idfactorsub", idfactorsub),
               new SqlParameter("@idproduct", idproduct),
               new SqlParameter("@countsefaresh", countsefaresh),
               new SqlParameter("@idproductcolor", idproductcolor) ).AsEnumerable().FirstOrDefault();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            // Info.  
            return lst;
        }





        public async Task<dbMessage> sp_productaddresschangeactive(string iduser, long idproductaddress)
        {
            // Initialization.  
            dbMessage lst = new dbMessage();
            //try
            //{
            string sqlQuery = "EXEC [store].[productaddresschangeactive] @iduser , @idproductaddress ";
            lst =  this.Set<dbMessage>().FromSqlRaw(sqlQuery,
               new SqlParameter("@iduser", iduser),
               new SqlParameter("@idproductaddress", idproductaddress)
              ).AsEnumerable().FirstOrDefault();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            // Info.  
            return lst;
        }




        public async Task<List<dbMessage>> sp_productinsert(ProductInsert product)
        {
            // Initialization.  
            List<dbMessage> lst = new List<dbMessage>();


            //try
            //{
            // Settings.  


            // Processing.  
            string sqlQuery = "EXEC [store].[productinsert] " +
                "@iduser ," +
               
               
                "@idmenu ," +
                "@title ," +
                "@descriptionpost ," +
                "@text ," +
                "@pathdata ," +
               
   " @price ," +
  "  @isactiveproduct ," +
  "  @descriptionproduct,@moneypost ";

            lst = await this.Set<dbMessage>().FromSqlRaw(sqlQuery,
               new SqlParameter("@iduser", product.iduser),
             
               new SqlParameter("@idmenu", product.Idmenu),
               new SqlParameter("@title", product.Title),
               new SqlParameter("@descriptionpost", product.Description),
               new SqlParameter("@text", product.Text),
               new SqlParameter("@pathdata", "..."),
           
               new SqlParameter("@price", product.Price),
               new SqlParameter("@isactiveproduct", product.Isactive),
               new SqlParameter("@descriptionproduct", product.Description),
               new SqlParameter("@moneypost", product.Moneypost)
             
               ).ToListAsync();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            // Info.  
            return lst;
        }

      
        public async Task<List<dbMessage>> contactinsert(byte idcontacttype, long? iduser, string name,  string email,  string description)
        {
            // Initialization.  
            List<dbMessage> lst = new List<dbMessage>();


            //try
            //{
            // Settings.  


            // Processing.  
            string sqlQuery = "EXEC [Security].[contactinsert] @idcontacttype,@idsoftwaremodel,@iduser,@name,@email,@description";

            lst = await this.Set<dbMessage>().FromSqlRaw(sqlQuery,
               new SqlParameter("@idcontacttype", (byte)idcontacttype),
               new SqlParameter("@idsoftwaremodel", (byte)SoftWeare.stareGem),
               new SqlParameter("@iduser", iduser),
               new SqlParameter("@name", name),
               new SqlParameter("@email", email),
               new SqlParameter("@description", description)).ToListAsync();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            // Info.  
            return lst;
        }

        public async Task<List<productStory>> sp_productbynamelist(long PageNumber, long RowsCountInEachPage, bool? isactiveproduct, bool? moneysorttype,string nameproduct)
        {
            // Initialization.  
            List<productStory> lst = new List<productStory>();


            //try
            //{

            string sqlQuery = "EXEC [store].[productbynamelist] @PageNumber , @RowsCountInEachPage,@isactiveproduct,@moneysorttype,@nameproduct ";

            lst = await this.Set<productStory>().FromSqlRaw(sqlQuery,
               new SqlParameter("@PageNumber", PageNumber),
               new SqlParameter("@RowsCountInEachPage", RowsCountInEachPage),
               new SqlParameter("@isactiveproduct", (object)isactiveproduct ?? DBNull.Value),
               new SqlParameter("@moneysorttype", (object)moneysorttype ?? DBNull.Value),
               new SqlParameter("@nameproduct", nameproduct)
              ).ToListAsync();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            // Info.  
            return lst;
        }


           public async Task<List<productStory>> sp_productbygrouplist(long PageNumber, long RowsCountInEachPage, bool? isactiveproduct,
               bool? moneysorttype,long idmenu)
        {
            // Initialization.  
            List<productStory> lst = new List<productStory>();


            //try
            //{

            string sqlQuery = "EXEC [store].[productbygrouplist]  @idmenu,@PageNumber ,@RowsCountInEachPage,@isactiveproduct,@moneysorttype ";

            lst = await this.Set<productStory>().FromSqlRaw(sqlQuery, 
               new SqlParameter("@idmenu", idmenu),
               new SqlParameter("@PageNumber", PageNumber),
               new SqlParameter("@RowsCountInEachPage", RowsCountInEachPage),
               new SqlParameter("@isactiveproduct", (object)isactiveproduct ?? DBNull.Value),
               new SqlParameter("@moneysorttype", (object)moneysorttype ?? DBNull.Value)
              ).ToListAsync();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            // Info.  
            return lst;
        }



        public async Task<List<productStory>> sp_productalllist(long PageNumber, long RowsCountInEachPage,bool? isactiveproduct, bool? moneysorttype)
        {
            // Initialization.  
            List<productStory> lst = new List<productStory>();


            //try
            //{
           
            string sqlQuery = "EXEC [store].[productalllist] @PageNumber , @RowsCountInEachPage,@isactiveproduct,@moneysorttype ";
            
            lst = await this.Set<productStory>().FromSqlRaw(sqlQuery,
               new SqlParameter("@PageNumber", PageNumber),
               new SqlParameter("@RowsCountInEachPage", RowsCountInEachPage),
               new SqlParameter("@isactiveproduct", (object)isactiveproduct ?? DBNull.Value ),
               new SqlParameter("@moneysorttype", (object)moneysorttype ?? DBNull.Value )
              ).ToListAsync();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            // Info.  
            return lst;
        }


        public async Task<List<productStory>> sp_productallwithmenulist(long idmenu,long PageNumber, long RowsCountInEachPage,bool? isactiveproduct, bool? moneysorttype)
        {
            // Initialization.  
            List<productStory> lst = new List<productStory>();


            //try
            //{

            string sqlQuery = "EXEC [store].[productallwithmenulist] @idmenu, @PageNumber , @RowsCountInEachPage,@isactiveproduct,@moneysorttype ";

            lst = await this.Set<productStory>().FromSqlRaw(sqlQuery,
               new SqlParameter("@idmenu", idmenu),
               new SqlParameter("@PageNumber", PageNumber),
               new SqlParameter("@RowsCountInEachPage", RowsCountInEachPage),
               new SqlParameter("@isactiveproduct", (object)isactiveproduct ?? DBNull.Value),
               new SqlParameter("@moneysorttype", (object)moneysorttype ?? DBNull.Value)
              ).ToListAsync();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            // Info.  
            return lst;
        }


        public List<productStory> sp_productlatestlist(int tedadrecord)
        {
            // Initialization.  
            //  List<productStory> lst = new List<productStory>();
            //try
            //{
            var param = new SqlParameter("@tedadrecord", tedadrecord);
            // var basee = new Microsoft.Data.SqlClient.SqlParameter("@tedadrecord", tedadrecord);
            // basee.SqlDbType= System.Data.SqlDbType.BigInt;
            string sqlQuery = "EXEC  [store].[productlatestlist] @tedadrecord";
            var lst = this.Set<productStory>().FromSqlRaw(sqlQuery,
                new SqlParameter("@tedadrecord", tedadrecord))
               .AsNoTracking()

               .ToList();

            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            return lst;
        }

        public dbMessage sp_factorupdate(string @iduser, string @authority, string @idbankstate,int idproductpaytype,int idproductposttype)
        {

            //try
            //{

            string sqlQuery = "EXEC  [store].[factorupdate] @iduser ,@authority,@idbankstate,@idproductpaytype,@idproductposttype";
            var lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery,
                new SqlParameter("@iduser", iduser),
                new SqlParameter("@authority", authority),
                new SqlParameter("@idproductpaytype", idproductpaytype),
                 new SqlParameter("@idproductposttype", idproductposttype))
               .AsNoTracking()
               .FirstAsync();

            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            return lst.Result;
        }



        public dbMessage sp_factorupdateforsyncbuyerror(string @authority, int idbankstate,string refid)
        {

            //try
            //{

            string sqlQuery = "EXEC  [store].[factorupdateforsyncbuyerror] @authority ,@idbankstate,@refid";
            var lst =  this.Set<dbMessage>().FromSqlRaw(sqlQuery, 
                new SqlParameter("@authority", authority),
                new SqlParameter("@idbankstate", idbankstate),
                new SqlParameter("@refid", refid))
               .AsNoTracking()
               .FirstAsync();

            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
 
            return lst.Result;
        }


        public IOrderedQueryable<productStory> sp_productbannerList()
        {


           // IOrderedQueryable<productStory> applicationDbContext;
            var v = new DbContextOptions<ApplicationDbContext>();
            //try
            //{
            var context = new ApplicationDbContext(v);
            string sqlQuery = " exec [store].[productbannerList] ";
          var   applicationDbContext = this.Set<productStory>().FromSqlRaw(sqlQuery)
                .AsNoTracking().AsQueryable().OrderBy(b=>b.idproduct);


            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return applicationDbContext;
        }

        public productStory sp_productbannerlatest( )
        {
           
            productStory lst = new productStory();

            var v = new DbContextOptions<ApplicationDbContext>();
            //try
            //{
            var context = new ApplicationDbContext(v);
            string sqlQuery = "exec [store].[productbannerlatest]";
            lst  =   this.Set<productStory>().FromSqlRaw(sqlQuery).AsNoTracking().AsEnumerable().FirstOrDefault(); 


            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}


            return lst;
        }

       
        public async Task<List<productStory>> sp_productsliderlatestlist( )
        {
            List<productStory> lst = new List<productStory>();
            //try
            //{
            string sqlQuery = "EXEC [store].[productsliderlatestlist]";
            lst = await this.Set<productStory>().FromSqlRaw(sqlQuery).AsNoTracking().ToListAsync();
            
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return lst;
        }


        [Obsolete]
        public async Task<List<subfactorlist>> sp_subfactorlist(string iduser)
        {
            List<subfactorlist> lst = new List<subfactorlist>();


            //try
            //{
            string sqlQuery = "EXEC [store].[subfactorlist] @iduser ";
            lst = await this.Set<subfactorlist>().FromSqlRaw(sqlQuery,
               new SqlParameter("@iduser", iduser)
              ).ToListAsync();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
 
            return lst;
        }

        public dbMessage sp_productaddressinsert(Productaddress proaddress)        
        {
            //try
            //{
            string sqlQuery = " EXEC [store].[productaddressinsert] @iduser" +
                " ,@namefamily , @tell,@address,@city,@province,@postalcode,@geo,@isactive" +
                ",@isactivebase ";
            var lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery,
                new SqlParameter("@iduser", proaddress.Iduser),     
                new SqlParameter("@namefamily", proaddress.Namefamily),
                new SqlParameter("@tell", proaddress.Tell),
                new SqlParameter("@address", proaddress.Address),
                new SqlParameter("@city", proaddress.City),
                new SqlParameter("@province", proaddress.Province),
                new SqlParameter("@postalcode", proaddress.Postalcode),
                new SqlParameter("@geo", ""),
                new SqlParameter("@isactive", proaddress.Isactive),
                new SqlParameter("@isactivebase", proaddress.Isactivebase)
               ).AsEnumerable().FirstOrDefault();

            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //} 
            if (lst == null)
                return null;
            return lst;
        }

        public dbMessage sp_productaddressupdate(long id,Productaddress proaddress)
        {
            //try
            //{
            string sqlQuery = " EXEC [store].[productaddressupdate] @idproductaddress,@iduser" +
                ",@namefamily , @tell,@address,@city,@province,@postalcode,@geo,@isactive" +
                ",@isactivebase ";
            var lst = this.Set<dbMessage>().FromSqlRaw(sqlQuery,
                new SqlParameter("@idproductaddress", id),
                new SqlParameter("@iduser", proaddress.Iduser),
                new SqlParameter("@namefamily", proaddress.Namefamily),
                new SqlParameter("@tell", proaddress.Tell),
                new SqlParameter("@address", proaddress.Address),
                new SqlParameter("@city", proaddress.City),
                new SqlParameter("@province", proaddress.Province),
                new SqlParameter("@postalcode", proaddress.Postalcode),
                new SqlParameter("@geo", ""),
                new SqlParameter("@isactive", proaddress.Isactive),
                new SqlParameter("@isactivebase", proaddress.Isactivebase)
               ).AsEnumerable().FirstOrDefault();

            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //} 
            if (lst == null)
                return null;
            return lst;
        }



        public dbMessage sp_subfactorinsert(
             string iduser,
             long idproduct,
             long countsefaresh,
             long idcolor)
        {
           
            //try
            //{
            string sqlQuery = " EXEC [store].[subfactorinsert] @iduser, @idproduct , @countsefaresh , @idproductcolor ";
           var lst =  this.Set<dbMessage>().FromSqlRaw(sqlQuery,
               new SqlParameter("@iduser", iduser),
               new SqlParameter("@idproduct", idproduct),
               new SqlParameter("@countsefaresh", countsefaresh),
               new SqlParameter("@idproductcolor", idcolor)
              ).AsEnumerable().FirstOrDefault();

            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //} 
            if (lst == null)
                return null;
            return lst;
        }

        [Obsolete]
        public async Task<List<subfactorlist>> sp_subfactordelete(long iduser, long idproduct, long countsefaresh, long idcolor)
        {
            List<subfactorlist> lst = new List<subfactorlist>();
            //try
            //{
            string sqlQuery = "EXEC [store].[subfactordelete] @iduser, @idproduct , @countsefaresh,@idcolor ";
            lst = await this.Set<subfactorlist>().FromSqlRaw(sqlQuery,
               new SqlParameter("@iduser", iduser),
               new SqlParameter("@idproduct", idproduct),
               new SqlParameter("@countsefaresh", countsefaresh),
               new SqlParameter("@idcolor", idcolor)
              ).ToListAsync();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //} 
            return lst;
        }

    }
}
