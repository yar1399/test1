using System;
using System.IO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using PTemplate.Models;
using PTemplate.Models.Statestics.DB;
using SixLabors.ImageSharp;

namespace PTemplate.Data.DataBase
{
    public partial class _1868_yarbaseContext : IdentityDbContext<IdentityUser>
    {

        public static IConfigurationRoot Configuration;

        public _1868_yarbaseContext()
        {
            
        }

        public _1868_yarbaseContext(DbContextOptions<ApplicationDbContext> options)
        {
        }

        public _1868_yarbaseContext(DbContextOptions<_1868_yarbaseContext> options)
            : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

                Configuration = builder.Build();
                var connectionString = Configuration["ConnectionStrings:BaseCon"];
                optionsBuilder.UseSqlServer(connectionString);
            }
        }



        public virtual DbSet<Ad> Ads { get; set; }
        public virtual DbSet<Addresssystem> Addresssystems { get; set; }
       
        public virtual DbSet<Bankstate> Bankstates { get; set; }
        public virtual DbSet<Banktype> Banktypes { get; set; }
        public virtual DbSet<Bankuser> Bankusers { get; set; }
        public virtual DbSet<Bitafile> Bitafiles { get; set; }
        public virtual DbSet<BotTelegram> BotTelegrams { get; set; }
        public virtual DbSet<Browser> Browsers { get; set; }
        public virtual DbSet<Buysoftwaremodel> Buysoftwaremodels { get; set; }
        public virtual DbSet<Buysoftwaremodelusercount> Buysoftwaremodelusercounts { get; set; }
        public virtual DbSet<Buytype> Buytypes { get; set; }
        public virtual DbSet<Buyusertime> Buyusertimes { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Color1> Colors1 { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Contacttype> Contacttypes { get; set; }
        public virtual DbSet<Counterconnection> Counterconnections { get; set; }
        public virtual DbSet<County> Counties { get; set; }
        public virtual DbSet<Datatype> Datatypes { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Driveravatare> Driveravatares { get; set; }
        public virtual DbSet<Driverlocation> Driverlocations { get; set; }
        public virtual DbSet<Driverrequst> Driverrequsts { get; set; }
        public virtual DbSet<Driverrequststate> Driverrequststates { get; set; }
        public virtual DbSet<Drivertype> Drivertypes { get; set; }
        public virtual DbSet<Driverview> Driverviews { get; set; }
        public virtual DbSet<Factor> Factors { get; set; }
        public virtual DbSet<Factor1> Factors1 { get; set; }
        public virtual DbSet<Factorauthority> Factorauthorities { get; set; }
        public virtual DbSet<Factorpost> Factorposts { get; set; }
        public virtual DbSet<Factorposttype> Factorposttypes { get; set; }
        public virtual DbSet<Factorrequest> Factorrequests { get; set; }
        public virtual DbSet<Factorstate> Factorstates { get; set; }
        public virtual DbSet<Factorsub> Factorsubs { get; set; }
        public virtual DbSet<Factorsubrequest> Factorsubrequests { get; set; }
        public virtual DbSet<Imageprofile> Imageprofiles { get; set; }
        public virtual DbSet<Letter> Letters { get; set; }
        public virtual DbSet<LockCounter> LockCounters { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Menu1> Menus1 { get; set; }
        public virtual DbSet<Menugroup> Menugroups { get; set; }
        public virtual DbSet<Menumediatype> Menumediatypes { get; set; }
        public virtual DbSet<Menumedium> Menumedia { get; set; }
        public virtual DbSet<Menuorder> Menuorders { get; set; }
        public virtual DbSet<Menuorderitem> Menuorderitems { get; set; }
        public virtual DbSet<Move> Moves { get; set; }
        public virtual DbSet<Moveinfo> Moveinfos { get; set; }
        public virtual DbSet<Moveinfotype> Moveinfotypes { get; set; }
        public virtual DbSet<Movemusle> Movemusles { get; set; }
        public virtual DbSet<Moveratinguser> Moveratingusers { get; set; }
        public virtual DbSet<Movesport> Movesports { get; set; }
        public virtual DbSet<Musle> Musles { get; set; }
        public virtual DbSet<Name> Names { get; set; }
        public virtual DbSet<Nameuserentry> Nameuserentries { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }
        public virtual DbSet<Network> Networks { get; set; }
        public virtual DbSet<NetworkUsertell> NetworkUsertells { get; set; }
        public virtual DbSet<Networkblock> Networkblocks { get; set; }
        public virtual DbSet<Networkdescription> Networkdescriptions { get; set; }
        public virtual DbSet<Networkgeo> Networkgeos { get; set; }
        public virtual DbSet<Networkname> Networknames { get; set; }
        public virtual DbSet<Networkname1> Networknames1 { get; set; }
        public virtual DbSet<Networkpost> Networkposts { get; set; }
        public virtual DbSet<Networkposttype> Networkposttypes { get; set; }
        public virtual DbSet<Networkprofilemediatype> Networkprofilemediatypes { get; set; }
        public virtual DbSet<Networkprofilemedium> Networkprofilemedia { get; set; }
        public virtual DbSet<Networkrequeststate> Networkrequeststates { get; set; }
        public virtual DbSet<Networkrequestuser> Networkrequestusers { get; set; }
        public virtual DbSet<Networksettinguser> Networksettingusers { get; set; }
        public virtual DbSet<Networksettingusertype> Networksettingusertypes { get; set; }
        public virtual DbSet<Networkshopping> Networkshoppings { get; set; }
        public virtual DbSet<Networkshoppingtell> Networkshoppingtells { get; set; }
        public virtual DbSet<Networktell> Networktells { get; set; }
        public virtual DbSet<Networktype> Networktypes { get; set; }
        public virtual DbSet<Networkuser> Networkusers { get; set; }
        public virtual DbSet<Networkuserstate> Networkuserstates { get; set; }
        public virtual DbSet<Networkusertype> Networkusertypes { get; set; }
        public virtual DbSet<Networkuserupdate> Networkuserupdates { get; set; }
        public virtual DbSet<Networkuserupdatetype> Networkuserupdatetypes { get; set; }
        public virtual DbSet<Newtworkpostreport> Newtworkpostreports { get; set; }
        public virtual DbSet<Newtworkpostreportrequst> Newtworkpostreportrequsts { get; set; }
        public virtual DbSet<Nretworkreporttype> Nretworkreporttypes { get; set; }
        public virtual DbSet<O> Os { get; set; }
        public virtual DbSet<Option> Options { get; set; }
        public virtual DbSet<Ordertype> Ordertypes { get; set; }
        public virtual DbSet<Oss> Osses { get; set; }
        public virtual DbSet<Ostype> Ostypes { get; set; }
        public virtual DbSet<Pay> Pays { get; set; }
        public virtual DbSet<Payporsant> Payporsants { get; set; }
        public virtual DbSet<Plack> Placks { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Postdatum> Postdata { get; set; }
        public virtual DbSet<Poststatistic> Poststatistics { get; set; }
        public virtual DbSet<Posttop> Posttops { get; set; }
        public virtual DbSet<Posttoptype> Posttoptypes { get; set; }
        public virtual DbSet<Posttype> Posttypes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Productaddress> Productaddresses { get; set; }
        public virtual DbSet<Productcolor> Productcolors { get; set; }
        public virtual DbSet<Productdatatype> Productdatatypes { get; set; }
        public virtual DbSet<Productdatum> Productdata { get; set; }
        public virtual DbSet<Productinfo> Productinfos { get; set; }
        public virtual DbSet<Productmenuinfo> Productmenuinfos { get; set; }
        public virtual DbSet<Productpaytype> Productpaytypes { get; set; }
        public virtual DbSet<Productposttype> Productposttypes { get; set; }
        public virtual DbSet<Productshoppingsubtype> Productshoppingsubtypes { get; set; }
        public virtual DbSet<Productshoppingtype> Productshoppingtypes { get; set; }
        public virtual DbSet<Productsubmenu> Productsubmenus { get; set; }
        public virtual DbSet<Profileuserbirthday> Profileuserbirthdays { get; set; }
        public virtual DbSet<Profileuserdescription> Profileuserdescriptions { get; set; }
        public virtual DbSet<Profileusername> Profileusernames { get; set; }
        public virtual DbSet<Profileuserphone> Profileuserphones { get; set; }
        public virtual DbSet<Profileuserregioncity> Profileuserregioncities { get; set; }
        public virtual DbSet<Profileusersex> Profileusersexes { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Securitytokencode> Securitytokencodes { get; set; }
        public virtual DbSet<Shoppingtype> Shoppingtypes { get; set; }
        public virtual DbSet<Shoppingunit> Shoppingunits { get; set; }
        public virtual DbSet<Social> Socials { get; set; }
        public virtual DbSet<Socialweb> Socialwebs { get; set; }
        public virtual DbSet<Softwaremodel> Softwaremodels { get; set; }
        public virtual DbSet<Softwaremodeloption> Softwaremodeloptions { get; set; }
        public virtual DbSet<Sport> Sports { get; set; }
        public virtual DbSet<Sportmusle> Sportmusles { get; set; }
        public virtual DbSet<StReffer> StReffers { get; set; }
        public virtual DbSet<StUser> StUsers { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Statestic> Statestics { get; set; }
        public virtual DbSet<StatesticsDetil> StatesticsDetils { get; set; }
        public virtual DbSet<Statetype> Statetypes { get; set; }
        public virtual DbSet<Subfactor> Subfactors { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<Useractive> Useractives { get; set; }
        public virtual DbSet<Userbitum> Userbita { get; set; }
        public virtual DbSet<Userdelete> Userdeletes { get; set; }
        public virtual DbSet<Useremail> Useremails { get; set; }
        public virtual DbSet<Useremailconfirmation> Useremailconfirmations { get; set; }
        public virtual DbSet<Userlock> Userlocks { get; set; }
        public virtual DbSet<Userlocktype> Userlocktypes { get; set; }
        public virtual DbSet<Usermediatype> Usermediatypes { get; set; }
        public virtual DbSet<Usermedium> Usermedia { get; set; }
        public virtual DbSet<Userpass> Userpasses { get; set; }
        public virtual DbSet<Usersm> Usersms { get; set; }
        public virtual DbSet<Usersmstype> Usersmstypes { get; set; }
        public virtual DbSet<Usersystemip> Usersystemips { get; set; }
        public virtual DbSet<Usertell> Usertells { get; set; }
        public virtual DbSet<Usertellconfirmation> Usertellconfirmations { get; set; }
        public virtual DbSet<Usertoken> Usertokens { get; set; }
        public virtual DbSet<Valuebody> Valuebodies { get; set; }
        public virtual DbSet<Valuetype> Valuetypes { get; set; }
        public virtual DbSet<Vip> Vips { get; set; }
        public virtual DbSet<Vipuser> Vipusers { get; set; }
        public virtual DbSet<Yarpartner> Yarpartners { get; set; }
        public virtual DbSet<Yarpartnerporsant> Yarpartnerporsants { get; set; }
        public virtual DbSet<Yarpartneruser> Yarpartnerusers { get; set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("6815_yar")
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Ad>(entity =>
            {
                entity.ToTable("ad", "base");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Dateend)
                    .HasColumnType("datetime")
                    .HasColumnName("dateend");

                entity.Property(e => e.Datestart)
                    .HasColumnType("datetime")
                    .HasColumnName("datestart");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Path)
                    .HasMaxLength(500)
                    .HasColumnName("path");
                entity.Property(e => e.Link)
                   .HasMaxLength(500)
                   .HasColumnName("link");
            });

            modelBuilder.Entity<Addresssystem>(entity =>
            {
                entity.ToTable("addresssystem", "Security");

                entity.Property(e => e.Id)
              
                    .HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(120)
                    .HasColumnName("address");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.Description)
                    .HasMaxLength(2200)
                    .HasColumnName("description");

                entity.Property(e => e.Email)
                    .HasMaxLength(120)
                    .HasColumnName("email");

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .HasColumnName("fax");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Namemanger)
                    .HasMaxLength(50)
                    .HasColumnName("namemanger");

                entity.Property(e => e.Postalcode)
                    .HasMaxLength(50)
                    .HasColumnName("postalcode");

                entity.Property(e => e.Province)
                    .HasMaxLength(50)
                    .HasColumnName("province");

                entity.Property(e => e.Tell)
                    .HasMaxLength(50)
                    .HasColumnName("tell"); 
                
                entity.Property(e => e.Time)
                    .HasMaxLength(200)
                    .HasColumnName("time");

                entity.Property(e => e.Text).HasColumnName("text"); 
                entity.Property(e => e.Lat).HasColumnName("lat");  
                entity.Property(e => e.Lng).HasColumnName("lng");
            });

           

            modelBuilder.Entity<Bankstate>(entity =>
            {
                entity.ToTable("bankstate", "pay");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Idbanktype).HasColumnName("idbanktype");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdbanktypeNavigation)
                    .WithMany(p => p.Bankstates)
                    .HasForeignKey(d => d.Idbanktype)
                    .HasConstraintName("FK_bankstate_banktype");
            });

            modelBuilder.Entity<Banktype>(entity =>
            {
                entity.ToTable("banktype", "pay");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Bankuser>(entity =>
            {
                entity.ToTable("bankuser", "pay");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codemeli)
                    .HasMaxLength(15)
                    .HasColumnName("codemeli");

                entity.Property(e => e.Idhasab)
                    .HasMaxLength(25)
                    .HasColumnName("idhasab");

                entity.Property(e => e.Imagehasab)
                    .HasMaxLength(250)
                    .HasColumnName("imagehasab");

                entity.Property(e => e.Imagemeli)
                    .HasMaxLength(250)
                    .HasColumnName("imagemeli");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Isactivehasab).HasColumnName("isactivehasab");

                entity.Property(e => e.Namebank)
                    .HasMaxLength(50)
                    .HasColumnName("namebank");

                entity.Property(e => e.Username)
                    .HasMaxLength(80)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Bitafile>(entity =>
            {
                entity.ToTable("bitafile", "post");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .HasColumnName("name");

                entity.Property(e => e.Namefile)
                    .HasMaxLength(150)
                    .HasColumnName("namefile");
            });


            modelBuilder.Entity<StReffer>(entity =>
            {
                entity.ToTable("StReffer", "Statestics");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(300);
            });
            modelBuilder.Entity<Statestic>(entity =>
            {
                entity.ToTable("Statestics", "Statestics");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Day).HasColumnType("datetime");
            });
            modelBuilder.Entity<StatesticsDetil>(entity =>
            {
                entity.ToTable("StatesticsDetils", "Statestics");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.City).HasMaxLength(80);

                entity.Property(e => e.Country).HasMaxLength(80);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.IdstReffer).HasColumnName("idstReffer");

                entity.Property(e => e.Ip).HasMaxLength(50);

                entity.Property(e => e.Url).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.IdstRefferNavigation)
                    .WithMany(p => p.StatesticsDetils)
                    .HasForeignKey(d => d.IdstReffer)
                    .HasConstraintName("FK_StatesticsDetils_StReffer");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.StatesticsDetils)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_StatesticsDetils_StUsers");
            });
            modelBuilder.Entity<Oss>(entity =>
            {
                entity.ToTable("OSs", "Statestics");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .HasColumnName("color");

                entity.Property(e => e.ImageName).HasMaxLength(250);

                entity.Property(e => e.Oskey)
                    .HasMaxLength(50)
                    .HasColumnName("OSKey");

                entity.Property(e => e.Osname)
                    .HasMaxLength(50)
                    .HasColumnName("OSName");

                entity.Property(e => e.OsnameFa)
                    .HasMaxLength(50)
                    .HasColumnName("OSNameFa");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .HasColumnName("tag");
            });
            modelBuilder.Entity<Browser>(entity =>
            {
                entity.ToTable("Browsers", "Statestics");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrowsersKey).HasMaxLength(50);

                entity.Property(e => e.BrowsersName).HasMaxLength(50);

                entity.Property(e => e.BrowsersNameFa).HasMaxLength(50);

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .HasColumnName("color");

                entity.Property(e => e.ImageName).HasMaxLength(500);

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .HasColumnName("tag");
            });
            modelBuilder.Entity<StUser>(entity =>
            {
                entity.ToTable("StUsers", "Statestics");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BroserId).HasColumnName("BroserID");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(80)
                    .HasColumnName("iduser");

                entity.Property(e => e.KeyId)
                    .HasMaxLength(50)
                    .HasColumnName("KeyID");

                entity.Property(e => e.OsId).HasColumnName("osID");

                entity.Property(e => e.StId).HasColumnName("StID");

                entity.HasOne(d => d.Broser)
                    .WithMany(p => p.StUsers)
                    .HasForeignKey(d => d.BroserId)
                    .HasConstraintName("FK_StUsers_Browsers");

                entity.HasOne(d => d.Os)
                    .WithMany(p => p.StUsers)
                    .HasForeignKey(d => d.OsId)
                    .HasConstraintName("FK_StUsers_OSs");

                entity.HasOne(d => d.St)
                    .WithMany(p => p.StUsers)
                    .HasForeignKey(d => d.StId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_StUsers_Statestics");
            });

            modelBuilder.Entity<BotTelegram>(entity =>
            {
                entity.ToTable("botTelegram", "Security");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(850)
                    .HasColumnName("description");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Isactivediscription).HasColumnName("isactivediscription");

                entity.Property(e => e.Isactivepost).HasColumnName("isactivepost");

                entity.Property(e => e.Isactiveproduct).HasColumnName("isactiveproduct");

                entity.Property(e => e.Isactivesendauto).HasColumnName("isactivesendauto");

                entity.Property(e => e.Namechanale)
                    .HasMaxLength(250)
                    .HasColumnName("namechanale");

                entity.Property(e => e.Token)
                    .HasMaxLength(450)
                    .HasColumnName("token");
            });

          

            modelBuilder.Entity<Buysoftwaremodel>(entity =>
            {
                entity.ToTable("buysoftwaremodel", "pay");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Idsoftwaremodel).HasColumnName("idsoftwaremodel");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Title)
                    .HasMaxLength(60)
                    .HasColumnName("title");

                entity.Property(e => e.Usercounts).HasColumnName("usercounts");

                entity.HasOne(d => d.IdsoftwaremodelNavigation)
                    .WithMany(p => p.Buysoftwaremodels)
                    .HasForeignKey(d => d.Idsoftwaremodel)
                    .HasConstraintName("FK_buysoftwaremodel_softwaremodel");
            });

            modelBuilder.Entity<Buysoftwaremodelusercount>(entity =>
            {
                entity.ToTable("buysoftwaremodelusercount", "pay");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Idos).HasColumnName("idos");

                entity.Property(e => e.Idparentbuyusertime).HasColumnName("idparentbuyusertime");

                entity.Property(e => e.Idsoftwaremodel).HasColumnName("idsoftwaremodel");

                entity.Property(e => e.Idsystem)
                    .HasMaxLength(300)
                    .HasColumnName("idsystem");

                entity.Property(e => e.Systemloginname)
                    .HasMaxLength(120)
                    .HasColumnName("systemloginname");
            });

            modelBuilder.Entity<Buytype>(entity =>
            {
                entity.ToTable("buytype", "pay");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dateend)
                    .HasColumnType("datetime")
                    .HasColumnName("dateend");

                entity.Property(e => e.Datestart)
                    .HasColumnType("datetime")
                    .HasColumnName("datestart");

                entity.Property(e => e.Daycounts).HasColumnName("daycounts");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Idbuysoftwaremodel).HasColumnName("idbuysoftwaremodel");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Money)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("money");

                entity.Property(e => e.Pathcover)
                    .HasMaxLength(300)
                    .HasColumnName("pathcover");

                entity.Property(e => e.Pathlogo)
                    .HasMaxLength(300)
                    .HasColumnName("pathlogo");

                entity.Property(e => e.Title)
                    .HasMaxLength(60)
                    .HasColumnName("title");

                entity.HasOne(d => d.IdbuysoftwaremodelNavigation)
                    .WithMany(p => p.Buytypes)
                    .HasForeignKey(d => d.Idbuysoftwaremodel)
                    .HasConstraintName("FK_buytype_buysoftwaremodel");
            });

            modelBuilder.Entity<Buyusertime>(entity =>
            {
                entity.ToTable("buyusertime", "pay");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dateend)
                    .HasColumnType("datetime")
                    .HasColumnName("dateend");

                entity.Property(e => e.Datestart)
                    .HasColumnType("datetime")
                    .HasColumnName("datestart");

                entity.Property(e => e.Idbuysoftwaremodel).HasColumnName("idbuysoftwaremodel");

                entity.Property(e => e.Idbuytype).HasColumnName("idbuytype");

                entity.Property(e => e.Idparent).HasColumnName("idparent");

                entity.Property(e => e.Idpaybank).HasColumnName("idpaybank");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.HasOne(d => d.IdbuysoftwaremodelNavigation)
                    .WithMany(p => p.Buyusertimes)
                    .HasForeignKey(d => d.Idbuysoftwaremodel)
                    .HasConstraintName("FK_buyusertime_buysoftwaremodel");

                entity.HasOne(d => d.IdbuytypeNavigation)
                    .WithMany(p => p.Buyusertimes)
                    .HasForeignKey(d => d.Idbuytype)
                    .HasConstraintName("FK_buyusertime_buytype");

                entity.HasOne(d => d.IdparentNavigation)
                    .WithMany(p => p.InverseIdparentNavigation)
                    .HasForeignKey(d => d.Idparent)
                    .HasConstraintName("FK_buyusertime_buyusertime");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Buyusertimes)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_buyusertime_user");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("city", "base");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Idcounty).HasColumnName("idcounty");

                entity.Property(e => e.Idprovince).HasColumnName("idprovince");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.ToTable("color", "namyar");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Color1)
                    .HasMaxLength(255)
                    .HasColumnName("color");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .HasColumnName("name");

                entity.Property(e => e.Weight).HasColumnName("weight");
            });

            modelBuilder.Entity<Color1>(entity =>
            {
                entity.ToTable("color", "store");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descrition)
                    .HasMaxLength(1200)
                    .HasColumnName("descrition");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("comments", "Security");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Idsoftwaremodel).HasColumnName("idsoftwaremodel");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Text)
                    .HasMaxLength(1200)
                    .HasColumnName("text");

                entity.HasOne(d => d.IdsoftwaremodelNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.Idsoftwaremodel)
                    .HasConstraintName("FK_comments_softwaremodel");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_comments_user");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("contact", "Security");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Email)
                    .HasMaxLength(120)
                    .HasColumnName("email");

                entity.Property(e => e.Idcontacttype).HasColumnName("idcontacttype");

                entity.Property(e => e.Idsoftwaremodel).HasColumnName("idsoftwaremodel");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Name)
                    .HasMaxLength(60)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdcontacttypeNavigation)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.Idcontacttype)
                    .HasConstraintName("FK_contact_contacttype");

                entity.HasOne(d => d.IdsoftwaremodelNavigation)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.Idsoftwaremodel)
                    .HasConstraintName("FK_contact_softwaremodel");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_contact_user");
            });

            modelBuilder.Entity<Contacttype>(entity =>
            {
                entity.ToTable("contacttype", "Security");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Counterconnection>(entity =>
            {
                entity.ToTable("counterconnection", "pay");

                entity.HasComment("برای اینکه ببینیم کاربری که داره از نسخه ترایال استفاده میکنهُ چند بار وارد سیستم شده و کانکت کرده که تا مثلا ۱۰ بار هر کاربر بتونه به یه سیستم دیگه وصل بشه. البته قبل از اینکه کاربر بخواد از نو تمدید کنه هم قراره که دوباره ۱۰ بار بتونه بصورت مجانی وارد سیستم بشه");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.Idsoftwaremodel).HasColumnName("idsoftwaremodel");

                entity.Property(e => e.Idsystem)
                    .HasMaxLength(300)
                    .HasColumnName("idsystem");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");
            });

            modelBuilder.Entity<County>(entity =>
            {
                entity.ToTable("county", "base");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Idprovince).HasColumnName("idprovince");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Datatype>(entity =>
            {
                entity.ToTable("datatype", "content");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Driver>(entity =>
            {
                entity.ToTable("driver", "driver");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cancel).HasColumnName("cancel");

                entity.Property(e => e.Datecrate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecrate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Idtype).HasColumnName("idtype");

                entity.Property(e => e.Iduser).HasColumnName("iduser");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Namedriver)
                    .HasMaxLength(50)
                    .HasColumnName("namedriver");

                entity.Property(e => e.Plack)
                    .HasMaxLength(40)
                    .HasColumnName("plack");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Viewdriver).HasColumnName("viewdriver");
            });

            modelBuilder.Entity<Driveravatare>(entity =>
            {
                entity.ToTable("driveravatare", "driver");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Iduser).HasColumnName("iduser");

                entity.Property(e => e.Path)
                    .HasMaxLength(500)
                    .HasColumnName("path");
            });

            modelBuilder.Entity<Driverlocation>(entity =>
            {
                entity.ToTable("driverlocation", "driverrequst");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Iduser).HasColumnName("iduser");
            });

            modelBuilder.Entity<Driverrequst>(entity =>
            {
                entity.ToTable("driverrequst", "driverrequst");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dateend)
                    .HasColumnType("datetime")
                    .HasColumnName("dateend");

                entity.Property(e => e.Idrequstsate).HasColumnName("idrequstsate");

                entity.Property(e => e.Iduser).HasColumnName("iduser");

                entity.Property(e => e.Iduserdriver).HasColumnName("iduserdriver");
            });

            modelBuilder.Entity<Driverrequststate>(entity =>
            {
                entity.ToTable("driverrequststate", "driver");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1500)
                    .HasColumnName("description");

                entity.Property(e => e.Image)
                    .HasMaxLength(500)
                    .HasColumnName("image");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Drivertype>(entity =>
            {
                entity.ToTable("drivertype", "driverrequst");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1500)
                    .HasColumnName("description");

                entity.Property(e => e.Image)
                    .HasMaxLength(500)
                    .HasColumnName("image");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Driverview>(entity =>
            {
                entity.ToTable("driverview", "driver");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Idnetwork).HasColumnName("idnetwork");

                entity.Property(e => e.Iduser).HasColumnName("iduser");

                entity.Property(e => e.IsActive).HasColumnName("isActive");
            });

            modelBuilder.Entity<Factor>(entity =>
            {
                entity.ToTable("factor", "pay");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Idfactorrequest).HasColumnName("idfactorrequest");

                entity.Property(e => e.Idnetwork).HasColumnName("idnetwork");

                entity.Property(e => e.Iduser).HasColumnName("iduser");
            });

            modelBuilder.Entity<Factor1>(entity =>
            {
                entity.ToTable("factor", "store");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Authority)
                    .HasMaxLength(64)
                    .HasColumnName("authority");

                entity.Property(e => e.Datechangestate)
                    .HasColumnType("datetime")
                    .HasColumnName("datechangestate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Idbankstate).HasColumnName("idbankstate");

                entity.Property(e => e.Idfactorstate).HasColumnName("idfactorstate");

                entity.Property(e => e.Idproductaddress).HasColumnName("idproductaddress");

                entity.Property(e => e.Idproductpaytype).HasColumnName("idproductpaytype");

                entity.Property(e => e.Idproductposttype).HasColumnName("idproductposttype");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Refid)
                    .HasMaxLength(50)
                    .HasColumnName("refid");

                entity.HasOne(d => d.IdbankstateNavigation)
                    .WithMany(p => p.Factor1s)
                    .HasForeignKey(d => d.Idbankstate)
                    .HasConstraintName("FK_factor_bankstate");

                entity.HasOne(d => d.IdfactorstateNavigation)
                    .WithMany(p => p.Factor1s)
                    .HasForeignKey(d => d.Idfactorstate)
                    .HasConstraintName("FK_factor_factorstate");

                entity.HasOne(d => d.IdproductaddressNavigation)
                    .WithMany(p => p.Factor1s)
                    .HasForeignKey(d => d.Idproductaddress)
                    .HasConstraintName("FK_factor_productaddress");

                entity.HasOne(d => d.IdproductpaytypeNavigation)
                    .WithMany(p => p.Factor1s)
                    .HasForeignKey(d => d.Idproductpaytype)
                    .HasConstraintName("FK_factor_productpaytype");

                entity.HasOne(d => d.IdproductposttypeNavigation)
                    .WithMany(p => p.Factor1s)
                    .HasForeignKey(d => d.Idproductposttype)
                    .HasConstraintName("FK_factor_productposttype");
            });

            modelBuilder.Entity<Factorauthority>(entity =>
            {
                entity.ToTable("factorauthority", "store");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Authority)
                    .HasMaxLength(64)
                    .HasColumnName("authority");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("date")
                    .HasColumnName("datecreate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Idfactor).HasColumnName("idfactor");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Isactive)
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Refid)
                    .HasMaxLength(64)
                    .HasColumnName("refid");

                entity.HasOne(d => d.IdfactorNavigation)
                    .WithMany(p => p.Factorauthorities)
                    .HasForeignKey(d => d.Idfactor)
                    .HasConstraintName("FK_factorauthority_factor");
            });

            modelBuilder.Entity<Factorpost>(entity =>
            {
                entity.ToTable("factorpost", "store");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codefollowup)
                    .HasMaxLength(80)
                    .HasColumnName("codefollowup");

                entity.Property(e => e.Datecreate).HasColumnName("datecreate");

                entity.Property(e => e.Datepost).HasColumnName("datepost");

                entity.Property(e => e.Idfactor).HasColumnName("idfactor");

                entity.Property(e => e.Idfactorposttype).HasColumnName("idfactorposttype");

                entity.Property(e => e.IduserCreator)
                    .HasMaxLength(450)
                    .HasColumnName("iduserCreator");

                entity.Property(e => e.Iduserpost)
                    .HasMaxLength(450)
                    .HasColumnName("iduserpost");

                entity.Property(e => e.Isbus).HasColumnName("isbus");

                entity.Property(e => e.Isfinesh).HasColumnName("isfinesh");

                entity.Property(e => e.Money)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("money");

                entity.HasOne(d => d.IdfactorNavigation)
                    .WithMany(p => p.Factorposts)
                    .HasForeignKey(d => d.Idfactor)
                    .HasConstraintName("FK_factorpost_factor");

                entity.HasOne(d => d.IdfactorposttypeNavigation)
                    .WithMany(p => p.Factorposts)
                    .HasForeignKey(d => d.Idfactorposttype)
                    .HasConstraintName("FK_factorpost_factorposttype");
            });

            modelBuilder.Entity<Factorposttype>(entity =>
            {
                entity.ToTable("factorposttype", "store");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Factorrequest>(entity =>
            {
                entity.ToTable("factorrequest", "pay");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(120)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Factorstate>(entity =>
            {
                entity.ToTable("factorstate", "store");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(60)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Factorsub>(entity =>
            {
                entity.ToTable("factorsub", "store");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Idfactor).HasColumnName("idfactor");

                entity.Property(e => e.Idproduct).HasColumnName("idproduct");

                entity.Property(e => e.Idproductcolor).HasColumnName("idproductcolor");

                entity.Property(e => e.Money)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("money");

                entity.Property(e => e.Offpercent)
                    .HasColumnType("decimal(4, 3)")
                    .HasColumnName("offpercent");

                entity.HasOne(d => d.IdfactorNavigation)
                    .WithMany(p => p.Factorsubs)
                    .HasForeignKey(d => d.Idfactor)
                    .HasConstraintName("FK_factorsub_factor");

                entity.HasOne(d => d.IdproductNavigation)
                    .WithMany(p => p.Factorsubs)
                    .HasForeignKey(d => d.Idproduct)
                    .HasConstraintName("FK_factorsub_product");

                entity.HasOne(d => d.IdproductcolorNavigation)
                    .WithMany(p => p.Factorsubs)
                    .HasForeignKey(d => d.Idproductcolor)
                    .HasConstraintName("FK_factorsub_productcolor");
            });

            modelBuilder.Entity<Factorsubrequest>(entity =>
            {
                entity.ToTable("factorsubrequest", "pay");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(120)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Imageprofile>(entity =>
            {
                entity.ToTable("imageprofile", "4519_reza");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Path)
                    .HasMaxLength(550)
                    .HasColumnName("path");
            });

            modelBuilder.Entity<Letter>(entity =>
            {
                entity.ToTable("letter", "namyar");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(3)
                    .HasColumnName("name");

                entity.Property(e => e.Weight).HasColumnName("weight");
            });

            modelBuilder.Entity<LockCounter>(entity =>
            {
                entity.ToTable("lockCounter", "Security");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Idsoftwaremodel).HasColumnName("idsoftwaremodel");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.LockCounters)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_lockCounter_user");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("menu", "content");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Idmenugroup).HasColumnName("idmenugroup");

                entity.Property(e => e.Isactive)
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdmenugroupNavigation)
                    .WithMany(p => p.Menus)
                    .HasForeignKey(d => d.Idmenugroup)
                    .HasConstraintName("FK_menu_menugroup");
            });

            modelBuilder.Entity<Menu1>(entity =>
            {
                entity.ToTable("menu", "shoppingnetwork");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Dateend)
                    .HasColumnType("datetime")
                    .HasColumnName("dateend");

                entity.Property(e => e.Datestart)
                    .HasColumnType("datetime")
                    .HasColumnName("datestart");

                entity.Property(e => e.Description)
                    .HasMaxLength(2200)
                    .HasColumnName("description");

                entity.Property(e => e.Idnetwork).HasColumnName("idnetwork");

                entity.Property(e => e.Idshoppingunit).HasColumnName("idshoppingunit");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Money)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("money");

                entity.Property(e => e.Moneyuser)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("moneyuser");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdnetworkNavigation)
                    .WithMany(p => p.Menu1s)
                    .HasForeignKey(d => d.Idnetwork)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_menu_network");

                entity.HasOne(d => d.IdshoppingunitNavigation)
                    .WithMany(p => p.Menu1s)
                    .HasForeignKey(d => d.Idshoppingunit)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_menu_unit");
            });

            modelBuilder.Entity<Menugroup>(entity =>
            {
                entity.ToTable("menugroup", "content");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Isactive)
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Istype)
                    .HasColumnName("istype")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Menumediatype>(entity =>
            {
                entity.ToTable("menumediatype", "shoppingnetwork");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Menumedium>(entity =>
            {
                entity.ToTable("menumedia", "shoppingnetwork");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Idmenu).HasColumnName("idmenu");

                entity.Property(e => e.Idmenumediatype).HasColumnName("idmenumediatype");

                entity.Property(e => e.Path)
                    .HasMaxLength(500)
                    .HasColumnName("path");

                entity.HasOne(d => d.IdmenuNavigation)
                    .WithMany(p => p.Menumedia)
                    .HasForeignKey(d => d.Idmenu)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_menumedia_menu");

                entity.HasOne(d => d.IdmenumediatypeNavigation)
                    .WithMany(p => p.Menumedia)
                    .HasForeignKey(d => d.Idmenumediatype)
                    .HasConstraintName("FK_menumedia_menumediatype");
            });

            modelBuilder.Entity<Menuorder>(entity =>
            {
                entity.ToTable("menuorder", "shoppingbasket");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Idnetwork).HasColumnName("idnetwork");

                entity.Property(e => e.Idordertype).HasColumnName("idordertype");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Moneypeyk)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("moneypeyk");
            });

            modelBuilder.Entity<Menuorderitem>(entity =>
            {
                entity.ToTable("menuorderitems", "shoppingbasket");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Counter)
                    .HasColumnName("counter")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("discount")
                    .HasComment("تخفیف");

                entity.Property(e => e.Idmenuorder).HasColumnName("idmenuorder");

                entity.Property(e => e.Money)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("money");

                entity.Property(e => e.Moneyuser)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("moneyuser");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Productbarcode)
                    .HasMaxLength(64)
                    .HasColumnName("productbarcode");

                entity.HasOne(d => d.IdmenuorderNavigation)
                    .WithMany(p => p.Menuorderitems)
                    .HasForeignKey(d => d.Idmenuorder)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_menuorderitems_menuorder");
            });

            modelBuilder.Entity<Move>(entity =>
            {
                entity.ToTable("move", "move");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Isfree).HasColumnName("isfree");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .HasColumnName("name");

                entity.Property(e => e.Namefa)
                    .HasMaxLength(150)
                    .HasColumnName("namefa");

                entity.Property(e => e.Rating).HasColumnName("rating");
            });

            modelBuilder.Entity<Moveinfo>(entity =>
            {
                entity.ToTable("moveinfo", "move");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(3500)
                    .HasColumnName("description");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Isgender).HasColumnName("isgender");

                entity.Property(e => e.Path)
                    .HasMaxLength(500)
                    .HasColumnName("path");

                entity.HasOne(d => d.IdmoveNavigation)
                    .WithMany(p => p.Moveinfos)
                    .HasForeignKey(d => d.Idmove)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_moveinfo_move");

                entity.HasOne(d => d.IdmoveTypeNavigation)
                    .WithMany(p => p.Moveinfos)
                    .HasForeignKey(d => d.IdmoveType)
                    .HasConstraintName("FK_moveinfo_moveinfotype");
            });

            modelBuilder.Entity<Moveinfotype>(entity =>
            {
                entity.ToTable("moveinfotype", "move");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Movemusle>(entity =>
            {
                entity.ToTable("movemusle", "move");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Idmove).HasColumnName("idmove");

                entity.Property(e => e.Idmusle).HasColumnName("idmusle");

                entity.Property(e => e.Istarget).HasColumnName("istarget");
            });

            modelBuilder.Entity<Moveratinguser>(entity =>
            {
                entity.ToTable("moveratinguser", "move");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Cratedate)
                    .HasColumnType("date")
                    .HasColumnName("cratedate");

                entity.Property(e => e.Idmove).HasColumnName("idmove");

                entity.Property(e => e.Iduser).HasColumnName("iduser");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.HasOne(d => d.IdmoveNavigation)
                    .WithMany(p => p.Moveratingusers)
                    .HasForeignKey(d => d.Idmove)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_moveratinguser_move");
            });

            modelBuilder.Entity<Movesport>(entity =>
            {
                entity.ToTable("movesport", "move");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Idmove).HasColumnName("idmove");

                entity.Property(e => e.Idsport).HasColumnName("idsport");

                entity.HasOne(d => d.IdmoveNavigation)
                    .WithMany(p => p.Movesports)
                    .HasForeignKey(d => d.Idmove)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_movesport_move");
            });

            modelBuilder.Entity<Musle>(entity =>
            {
                entity.ToTable("musle", "move");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Image)
                    .HasMaxLength(250)
                    .HasColumnName("image");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Isbase).HasColumnName("isbase");

                entity.Property(e => e.Ismove).HasColumnName("ismove");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Name>(entity =>
            {
                entity.ToTable("name", "namyar");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasComment("اگر 0 باشه زن اگر 1 باشه مرد");

                entity.Property(e => e.Idletter).HasColumnName("idletter");

                entity.Property(e => e.Idnationality).HasColumnName("idnationality");

                entity.Property(e => e.Meaning)
                    .HasMaxLength(1000)
                    .HasColumnName("meaning");

                entity.Property(e => e.Name1)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Pronunciation)
                    .HasMaxLength(50)
                    .HasColumnName("pronunciation");

                entity.HasOne(d => d.IdletterNavigation)
                    .WithMany(p => p.Names)
                    .HasForeignKey(d => d.Idletter)
                    .HasConstraintName("FK_name_letter");

                entity.HasOne(d => d.IdnationalityNavigation)
                    .WithMany(p => p.Names)
                    .HasForeignKey(d => d.Idnationality)
                    .HasConstraintName("FK_name_nationality");
            });

            modelBuilder.Entity<Nameuserentry>(entity =>
            {
                entity.ToTable("nameuserentry", "namyar");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.Idletter).HasColumnName("idletter");

                entity.Property(e => e.Idnationality).HasColumnName("idnationality");

                entity.Property(e => e.Meaning)
                    .HasMaxLength(1000)
                    .HasColumnName("meaning");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Pronunciation)
                    .HasMaxLength(50)
                    .HasColumnName("pronunciation");

                entity.HasOne(d => d.IdletterNavigation)
                    .WithMany(p => p.Nameuserentries)
                    .HasForeignKey(d => d.Idletter)
                    .HasConstraintName("FK_nameuserentry_letter");

                entity.HasOne(d => d.IdnationalityNavigation)
                    .WithMany(p => p.Nameuserentries)
                    .HasForeignKey(d => d.Idnationality)
                    .HasConstraintName("FK_nameuserentry_nationality");
            });

            modelBuilder.Entity<Nationality>(entity =>
            {
                entity.ToTable("nationality", "namyar");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Network>(entity =>
            {
                entity.ToTable("network", "privatebase");

                entity.HasIndex(e => e.Id, "username_network")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Createdatedelete).HasColumnName("createdatedelete");

                entity.Property(e => e.Createnetworkdate)
                    .HasColumnName("createnetworkdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Idnetworktype).HasColumnName("idnetworktype");

                entity.Property(e => e.Iduser)
                    .IsRequired()
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Isactiveoprator).HasColumnName("isactiveoprator");

                entity.Property(e => e.Isdeletesystem).HasColumnName("isdeletesystem");

                entity.Property(e => e.Nickname)
                    .HasMaxLength(50)
                    .HasColumnName("nickname");

                entity.HasOne(d => d.IdnetworktypeNavigation)
                    .WithMany(p => p.Networks)
                    .HasForeignKey(d => d.Idnetworktype)
                    .HasConstraintName("FK_network_networktype");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Networks)
                    .HasForeignKey(d => d.Iduser)
                    .HasConstraintName("FK_network_user");
            });

            modelBuilder.Entity<NetworkUsertell>(entity =>
            {
                entity.ToTable("networkUsertell", "privatebase");

                entity.HasComment("شماره شخصی افراد را نگهداری می کند");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .HasColumnName("name");

                entity.Property(e => e.Tell)
                    .HasMaxLength(50)
                    .HasColumnName("tell");
            });

            modelBuilder.Entity<Networkblock>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("networkblock", "privatebase");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Idnetworkblock).HasColumnName("idnetworkblock");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<Networkdescription>(entity =>
            {
                entity.ToTable("networkdescription", "privatebase");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Idnetwork).HasColumnName("idnetwork");

                entity.HasOne(d => d.IdnetworkNavigation)
                    .WithMany(p => p.Networkdescriptions)
                    .HasForeignKey(d => d.Idnetwork)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_networkdescription_network");
            });

            modelBuilder.Entity<Networkgeo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("networkgeo", "privatebase");

                entity.Property(e => e.Datecreate).HasColumnName("datecreate");

                entity.Property(e => e.Idnetwork).HasColumnName("idnetwork");

                entity.HasOne(d => d.IdnetworkNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idnetwork)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_networkgeo_network");
            });

            modelBuilder.Entity<Networkname>(entity =>
            {
                entity.ToTable("networkname", "privatebase");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Idnetwork).HasColumnName("idnetwork");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Networkname1>(entity =>
            {
                entity.ToTable("networkname", "Security");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Networkname1s)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_NetworkName_User");
            });

            modelBuilder.Entity<Networkpost>(entity =>
            {
                entity.ToTable("networkpost", "post");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Idnetwork).HasColumnName("idnetwork");

                entity.Property(e => e.Idposttype).HasColumnName("idposttype");

                entity.Property(e => e.Path)
                    .HasMaxLength(600)
                    .HasColumnName("path");
            });

            modelBuilder.Entity<Networkposttype>(entity =>
            {
                entity.ToTable("networkposttype", "post");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Networkprofilemediatype>(entity =>
            {
                entity.ToTable("networkprofilemediatype", "privatebase");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Networkprofilemedium>(entity =>
            {
                entity.ToTable("networkprofilemedia", "privatebase");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Idnetwork).HasColumnName("idnetwork");

                entity.Property(e => e.Idtype).HasColumnName("idtype");

                entity.Property(e => e.Path)
                    .HasMaxLength(500)
                    .HasColumnName("path");

                entity.HasOne(d => d.IdnetworkNavigation)
                    .WithMany(p => p.Networkprofilemedia)
                    .HasForeignKey(d => d.Idnetwork)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_networkprofilemedia_network");

                entity.HasOne(d => d.IdtypeNavigation)
                    .WithMany(p => p.Networkprofilemedia)
                    .HasForeignKey(d => d.Idtype)
                    .HasConstraintName("FK_networkprofilemedia_networkprofilemediatype");
            });

            modelBuilder.Entity<Networkrequeststate>(entity =>
            {
                entity.ToTable("networkrequeststate", "PublicBase");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Discription)
                    .HasMaxLength(1200)
                    .HasColumnName("discription");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Networkrequestuser>(entity =>
            {
                entity.ToTable("networkrequestuser", "PublicBase");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Datecrate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecrate");

                entity.Property(e => e.Idstate).HasColumnName("idstate");

                entity.Property(e => e.Idtellcontent).HasColumnName("idtellcontent");

                entity.Property(e => e.Iduser).HasColumnName("iduser");

                entity.Property(e => e.Iduserbase).HasColumnName("iduserbase");
            });

            modelBuilder.Entity<Networksettinguser>(entity =>
            {
                entity.ToTable("networksettinguser", "privatebase");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Idnetwork).HasColumnName("idnetwork");

                entity.Property(e => e.Idnetworksettingusertype).HasColumnName("idnetworksettingusertype");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.HasOne(d => d.IdnetworkNavigation)
                    .WithMany(p => p.Networksettingusers)
                    .HasForeignKey(d => d.Idnetwork)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_networksettinguser_network");

                entity.HasOne(d => d.IdnetworksettingusertypeNavigation)
                    .WithMany(p => p.Networksettingusers)
                    .HasForeignKey(d => d.Idnetworksettingusertype)
                    .HasConstraintName("FK_networksettinguser_networksettingusertype");
            });

            modelBuilder.Entity<Networksettingusertype>(entity =>
            {
                entity.ToTable("networksettingusertype", "privatebase");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Discription)
                    .HasMaxLength(1200)
                    .HasColumnName("discription");

                entity.Property(e => e.Ispreview).HasColumnName("ispreview");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasComment("عمومی یا خصوصی بودن تنظیمات رو مشخص میکنه-- اگر مقدار این فیلد 1 باشد یعنی این تنظیمات مربوط به اکانت شخصی است. اگر 2 باشد یعنی مربوط به مغازه ها است. اگر 3 باشد یعنی تنظیمات عمومی است (هم اکانت های شخصی و هم مغازه ها)");
            });

            modelBuilder.Entity<Networkshopping>(entity =>
            {
                entity.ToTable("networkshopping", "privatebase");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Idnetwork).HasColumnName("idnetwork");

                entity.Property(e => e.Idproductshoppingtype).HasColumnName("idproductshoppingtype");

                entity.Property(e => e.Isactive)
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdnetworkNavigation)
                    .WithMany(p => p.Networkshoppings)
                    .HasForeignKey(d => d.Idnetwork)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_networkshopping_network");

                entity.HasOne(d => d.IdproductshoppingtypeNavigation)
                    .WithMany(p => p.Networkshoppings)
                    .HasForeignKey(d => d.Idproductshoppingtype)
                    .HasConstraintName("FK_networkshopping_productshoppingtype");
            });

            modelBuilder.Entity<Networkshoppingtell>(entity =>
            {
                entity.ToTable("networkshoppingtell", "shoppingnetwork");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Idnetwork).HasColumnName("idnetwork");

                entity.Property(e => e.Tell)
                    .HasMaxLength(20)
                    .HasColumnName("tell");

                entity.HasOne(d => d.IdnetworkNavigation)
                    .WithMany(p => p.Networkshoppingtells)
                    .HasForeignKey(d => d.Idnetwork)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_networkshoppingtell_network");
            });

            modelBuilder.Entity<Networktell>(entity =>
            {
                entity.ToTable("networktell", "privatebase");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Idnetwork).HasColumnName("idnetwork");

                entity.Property(e => e.Tell)
                    .HasMaxLength(24)
                    .HasColumnName("tell");

                entity.HasOne(d => d.IdnetworkNavigation)
                    .WithMany(p => p.Networktells)
                    .HasForeignKey(d => d.Idnetwork)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tell_network");
            });

            modelBuilder.Entity<Networktype>(entity =>
            {
                entity.ToTable("networktype", "privatebase");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(2500)
                    .HasColumnName("description");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Networkuser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("networkuser", "privatebase");

                entity.Property(e => e.Datecrate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecrate");

                entity.Property(e => e.IdnetworkBase).HasColumnName("idnetworkBase");

                entity.Property(e => e.Idstate).HasColumnName("idstate");

                entity.Property(e => e.Idtype).HasColumnName("idtype");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Nicname2)
                    .HasMaxLength(50)
                    .HasColumnName("nicname2");
            });

            modelBuilder.Entity<Networkuserstate>(entity =>
            {
                entity.ToTable("networkuserstate", "privatebase");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Networkusertype>(entity =>
            {
                entity.ToTable("networkusertype", "privatebase");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Networkuserupdate>(entity =>
            {
                entity.ToTable("networkuserupdate", "privatebase");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Idstate).HasColumnName("idstate");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");
            });

            modelBuilder.Entity<Networkuserupdatetype>(entity =>
            {
                entity.ToTable("networkuserupdatetype", "privatebase");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Newtworkpostreport>(entity =>
            {
                entity.ToTable("newtworkpostreport", "post");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Idpost).HasColumnName("idpost");

                entity.Property(e => e.Idtypereport).HasColumnName("idtypereport");
            });

            modelBuilder.Entity<Newtworkpostreportrequst>(entity =>
            {
                entity.ToTable("newtworkpostreportrequst", "post");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Idpost).HasColumnName("idpost");

                entity.Property(e => e.Idreporttype).HasColumnName("idreporttype");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<Nretworkreporttype>(entity =>
            {
                entity.ToTable("nretworkreporttype", "post");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<O>(entity =>
            {
                entity.ToTable("os", "pay");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(69)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Option>(entity =>
            {
                entity.ToTable("options", "Security");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Idsoftwaremodel).HasColumnName("idsoftwaremodel");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdsoftwaremodelNavigation)
                    .WithMany(p => p.Options)
                    .HasForeignKey(d => d.Idsoftwaremodel)
                    .HasConstraintName("FK_Options_SoftwareModel");
            });

            modelBuilder.Entity<Ordertype>(entity =>
            {
                entity.ToTable("ordertype", "shoppingbasket");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            

            modelBuilder.Entity<Ostype>(entity =>
            {
                entity.ToTable("ostype", "Security");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Pay>(entity =>
            {
                entity.ToTable("pay", "pay");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Authority)
                    .HasMaxLength(80)
                    .HasColumnName("authority");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Idbank).HasColumnName("idbank");

                entity.Property(e => e.Idbuytype).HasColumnName("idbuytype");

                entity.Property(e => e.Idsoftwaremodel).HasColumnName("idsoftwaremodel");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Ispayment).HasColumnName("ispayment");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("price");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .HasColumnName("state");

                entity.HasOne(d => d.IdbankNavigation)
                    .WithMany(p => p.Pays)
                    .HasForeignKey(d => d.Idbank)
                    .HasConstraintName("FK_pay_banktype");

                entity.HasOne(d => d.IdsoftwaremodelNavigation)
                    .WithMany(p => p.Pays)
                    .HasForeignKey(d => d.Idsoftwaremodel)
                    .HasConstraintName("FK_pay_softwaremodel");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Pays)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_pay_user");
            });

            modelBuilder.Entity<Payporsant>(entity =>
            {
                entity.ToTable("payporsant", "partner");

                entity.HasComment("مشخص میکند که از فلان تاریخ تا فلان تاریخُ چه مبلغی بعنونا \\ورسانتُ به شرکت شریک پرداخت شده است");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Dateend)
                    .HasColumnType("datetime")
                    .HasColumnName("dateend");

                entity.Property(e => e.Datestart)
                    .HasColumnType("datetime")
                    .HasColumnName("datestart");

                entity.Property(e => e.Idyarpartner).HasColumnName("idyarpartner");

                entity.Property(e => e.Money)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("money");

                entity.Property(e => e.Shenasepardakht)
                    .HasMaxLength(35)
                    .HasColumnName("shenasepardakht");

                entity.HasOne(d => d.IdyarpartnerNavigation)
                    .WithMany(p => p.Payporsants)
                    .HasForeignKey(d => d.Idyarpartner)
                    .HasConstraintName("FK_payporsant_yarpartner");
            });

            modelBuilder.Entity<Plack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("plack", "driver");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Iduser).HasColumnName("iduser");

                entity.Property(e => e.Plack1)
                    .HasMaxLength(50)
                    .HasColumnName("plack");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("post", "content");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datestart)
                    .HasColumnType("datetime")
                    .HasColumnName("datestart")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Idmenu).HasColumnName("idmenu");

                entity.Property(e => e.Idposttoptype).HasColumnName("idposttoptype");

                entity.Property(e => e.Idposttype).HasColumnName("idposttype");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Iswrite)
                    .HasColumnName("iswrite")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Pathdata)
                    .HasMaxLength(400)
                    .HasColumnName("pathdata");

                entity.Property(e => e.Text).HasColumnName("text");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.HasOne(d => d.IdmenuNavigation)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.Idmenu)
                    .HasConstraintName("FK_post_menu");

                entity.HasOne(d => d.IdposttoptypeNavigation)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.Idposttoptype)
                    .HasConstraintName("FK_post_posttoptype");

                entity.HasOne(d => d.IdposttypeNavigation)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.Idposttype)
                    .HasConstraintName("FK_post_posttype");
            });

            modelBuilder.Entity<Postdatum>(entity =>
            {
                entity.ToTable("postdata", "content");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Iddatatype).HasColumnName("iddatatype");

                entity.Property(e => e.Idpost).HasColumnName("idpost");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Pathdata)
                    .HasMaxLength(400)
                    .HasColumnName("pathdata");

                entity.HasOne(d => d.IddatatypeNavigation)
                    .WithMany(p => p.Postdata)
                    .HasForeignKey(d => d.Iddatatype)
                    .HasConstraintName("FK_postdata_datatype");

                entity.HasOne(d => d.IdpostNavigation)
                    .WithMany(p => p.Postdata)
                    .HasForeignKey(d => d.Idpost)
                    .HasConstraintName("FK_postdata_post");
            });

            modelBuilder.Entity<Poststatistic>(entity =>
            {
                entity.ToTable("poststatistics", "content");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Countview).HasColumnName("countview");

                entity.Property(e => e.Dateday)
                    .HasColumnType("date")
                    .HasColumnName("dateday");

                entity.Property(e => e.Idpost).HasColumnName("idpost");
            });

            modelBuilder.Entity<Posttop>(entity =>
            {
                entity.ToTable("posttop", "content");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dateend)
                    .HasColumnType("datetime")
                    .HasColumnName("dateend")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datestart)
                    .HasColumnType("datetime")
                    .HasColumnName("datestart")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Idpost).HasColumnName("idpost");

                entity.Property(e => e.Idtype).HasColumnName("idtype");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Isdatestart).HasColumnName("isdatestart");

                entity.HasOne(d => d.IdpostNavigation)
                    .WithMany(p => p.Posttops)
                    .HasForeignKey(d => d.Idpost)
                    .HasConstraintName("FK_posttop_post");

                entity.HasOne(d => d.IdtypeNavigation)
                    .WithMany(p => p.Posttops)
                    .HasForeignKey(d => d.Idtype)
                    .HasConstraintName("FK_posttop_posttoptype");
            });

            modelBuilder.Entity<Posttoptype>(entity =>
            {
                entity.ToTable("posttoptype", "content");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Posttype>(entity =>
            {
                entity.ToTable("posttype", "content");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(60)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product", "store");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datecreate).HasColumnName("datecreate");

                entity.Property(e => e.Description)
                    .HasMaxLength(2200)
                    .HasColumnName("description");

                entity.Property(e => e.Idmenu).HasColumnName("idmenu");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Moneypost)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("moneypost");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("price");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .HasColumnName("title");

                entity.HasOne(d => d.IdmenuNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Idmenu)
                    .HasConstraintName("FK_product_menu");
            });

            modelBuilder.Entity<Productaddress>(entity =>
            {
                entity.ToTable("productaddress", "store");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(1200)
                    .HasColumnName("address");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Isactivebase).HasColumnName("isactivebase");

                entity.Property(e => e.Namefamily)
                    .HasMaxLength(150)
                    .HasColumnName("namefamily");

                entity.Property(e => e.Postalcode)
                    .HasMaxLength(10)
                    .HasColumnName("postalcode");

                entity.Property(e => e.Province)
                    .HasMaxLength(50)
                    .HasColumnName("province")
                    .HasComment("ostan");

                entity.Property(e => e.Tell)
                    .HasMaxLength(14)
                    .HasColumnName("tell");
            });

            modelBuilder.Entity<Productcolor>(entity =>
            {
                entity.ToTable("productcolor", "store");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Idcolor).HasColumnName("idcolor");

                entity.Property(e => e.Idproduct).HasColumnName("idproduct");

                entity.HasOne(d => d.IdcolorNavigation)
                    .WithMany(p => p.Productcolors)
                    .HasForeignKey(d => d.Idcolor)
                    .HasConstraintName("FK_productcolor_color");

                entity.HasOne(d => d.IdproductNavigation)
                    .WithMany(p => p.Productcolors)
                    .HasForeignKey(d => d.Idproduct)
                    .HasConstraintName("FK_productcolor_product");
            });

            modelBuilder.Entity<Productdatatype>(entity =>
            {
                entity.ToTable("productdatatype", "store");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Productdatum>(entity =>
            {
                entity.ToTable("productdata", "store");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datecreate).HasColumnName("datecreate");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Iddatatype).HasColumnName("iddatatype");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Pathdata)
                    .HasMaxLength(400)
                    .HasColumnName("pathdata");

                entity.HasOne(d => d.IddatatypeNavigation)
                    .WithMany(p => p.Productdata)
                    .HasForeignKey(d => d.Iddatatype)
                    .HasConstraintName("FK_productdata_productdatatype");

                entity.HasOne(d => d.IdproductNavigation)
                    .WithMany(p => p.Productdata)
                    .HasForeignKey(d => d.Idproduct)
                    .HasConstraintName("FK_productdata_product");
            });

            modelBuilder.Entity<Productinfo>(entity =>
            {
                entity.ToTable("productinfo", "store");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datecreate).HasColumnName("datecreate");

                entity.Property(e => e.Description)
                    .HasMaxLength(2200)
                    .HasColumnName("description");

                entity.Property(e => e.Idproduct).HasColumnName("idproduct");

                entity.Property(e => e.Idproductmenuinfo).HasColumnName("idproductmenuinfo");

                entity.HasOne(d => d.IdproductNavigation)
                    .WithMany(p => p.Productinfos)
                    .HasForeignKey(d => d.Idproduct)
                    .HasConstraintName("FK_productinfo_product");

                entity.HasOne(d => d.IdproductmenuinfoNavigation)
                    .WithMany(p => p.Productinfos)
                    .HasForeignKey(d => d.Idproductmenuinfo)
                    .HasConstraintName("FK_productinfo_productmenuinfo");
            });

            modelBuilder.Entity<Productmenuinfo>(entity =>
            {
                entity.ToTable("productmenuinfo", "store");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Idsubmenu).HasColumnName("idsubmenu");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Title)
                    .HasMaxLength(150)
                    .HasColumnName("title");

                entity.HasOne(d => d.IdsubmenuNavigation)
                    .WithMany(p => p.Productmenuinfos)
                    .HasForeignKey(d => d.Idsubmenu)
                    .HasConstraintName("FK_productmenuinfo_menu");
            });

            modelBuilder.Entity<Productpaytype>(entity =>
            {
                entity.ToTable("productpaytype", "store");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Productposttype>(entity =>
            {
                entity.ToTable("productposttype", "store");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Productshoppingsubtype>(entity =>
            {
                entity.ToTable("productshoppingsubtype", "shoppingnetwork");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Idproductshoppingtype).HasColumnName("idproductshoppingtype");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdproductshoppingtypeNavigation)
                    .WithMany(p => p.Productshoppingsubtypes)
                    .HasForeignKey(d => d.Idproductshoppingtype)
                    .HasConstraintName("FK_productshoppingsubtype_productshoppingtype");
            });

            modelBuilder.Entity<Productshoppingtype>(entity =>
            {
                entity.ToTable("productshoppingtype", "shoppingnetwork");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Idshopingtype).HasColumnName("idshopingtype");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Path)
                    .HasMaxLength(300)
                    .HasColumnName("path");

                entity.HasOne(d => d.IdshopingtypeNavigation)
                    .WithMany(p => p.Productshoppingtypes)
                    .HasForeignKey(d => d.Idshopingtype)
                    .HasConstraintName("FK_productshoppingtype_shoppingtype");
            });

            modelBuilder.Entity<Productsubmenu>(entity =>
            {
                entity.ToTable("productsubmenu", "store");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Idmenu).HasColumnName("idmenu");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .HasColumnName("name");

                entity.HasOne(d => d.IdmenuNavigation)
                    .WithMany(p => p.Productsubmenus)
                    .HasForeignKey(d => d.Idmenu)
                    .HasConstraintName("FK_productsubmenu_menu");
            });

            modelBuilder.Entity<Profileuserbirthday>(entity =>
            {
                entity.ToTable("profileuserbirthday", "privatebase");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Birthday).HasColumnName("birthday");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");
            });

            modelBuilder.Entity<Profileuserdescription>(entity =>
            {
                entity.ToTable("profileuserdescription", "privatebase");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Discription)
                    .HasMaxLength(1200)
                    .HasColumnName("discription");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");
            });

            modelBuilder.Entity<Profileusername>(entity =>
            {
                entity.ToTable("profileusername", "privatebase");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Firstlastname)
                    .HasMaxLength(80)
                    .HasColumnName("firstlastname");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");
            });

            modelBuilder.Entity<Profileuserphone>(entity =>
            {
                entity.ToTable("profileuserphone", "privatebase");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(20)
                    .HasColumnName("phonenumber");
            });

            modelBuilder.Entity<Profileuserregioncity>(entity =>
            {
                entity.ToTable("profileuserregioncity", "privatebase");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Idcity).HasColumnName("idcity");

                entity.Property(e => e.Idcounty).HasColumnName("idcounty");

                entity.Property(e => e.Idprovince).HasColumnName("idprovince");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");
            });

            modelBuilder.Entity<Profileusersex>(entity =>
            {
                entity.ToTable("profileusersex", "privatebase");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Iduser)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("province", "base");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role", "Security");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1500)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Securitytokencode>(entity =>
            {
                entity.ToTable("securitytokencode", "pay");

                entity.HasComment("اون شناسه ای که تولید میشه روی برنامه مشتری که از راه دور یکی دیگه با اون شناسه یا توکن وصل بشه به سیستمش");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Idsystem)
                    .HasMaxLength(300)
                    .HasColumnName("idsystem");

                entity.Property(e => e.Number)
                    .HasMaxLength(10)
                    .HasColumnName("number");
            });

            modelBuilder.Entity<Shoppingtype>(entity =>
            {
                entity.ToTable("shoppingtype", "shoppingnetwork");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Discription)
                    .HasMaxLength(1200)
                    .HasColumnName("discription");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Shoppingunit>(entity =>
            {
                entity.ToTable("shoppingunit", "shoppingnetwork");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Social>(entity =>
            {
                entity.ToTable("social", "base");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .HasColumnName("color");

                entity.Property(e => e.Image)
                    .HasMaxLength(500)
                    .HasColumnName("image");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Tag)
                    .HasMaxLength(50)
                    .HasColumnName("tag");
            });

            modelBuilder.Entity<Socialweb>(entity =>
            {
                entity.ToTable("socialweb", "base");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Idsocial).HasColumnName("idsocial");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Link)
                    .HasMaxLength(500)
                    .HasColumnName("link");
                
                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .HasColumnName("description");

                entity.HasOne(d => d.IdsocialNavigation)
                    .WithMany(p => p.Socialwebs)
                    .HasForeignKey(d => d.Idsocial)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_socialweb_social");
            });

            modelBuilder.Entity<Softwaremodel>(entity =>
            {
                entity.ToTable("softwaremodel", "Security");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Softwaremodeloption>(entity =>
            {
                entity.ToTable("softwaremodeloptions", "Security");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Idoptions).HasColumnName("idoptions");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.HasOne(d => d.IdoptionsNavigation)
                    .WithMany(p => p.Softwaremodeloptions)
                    .HasForeignKey(d => d.Idoptions)
                    .HasConstraintName("FK_SoftwareModelOptions_Options");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Softwaremodeloptions)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SoftwareModelOptions_User");
            });

            modelBuilder.Entity<Sport>(entity =>
            {
                entity.ToTable("sport", "move");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.Image)
                    .HasMaxLength(250)
                    .HasColumnName("image");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Sportmusle>(entity =>
            {
                entity.ToTable("sportmusle", "move");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Idmusle).HasColumnName("idmusle");

                entity.Property(e => e.Idsport).HasColumnName("idsport");

                entity.Property(e => e.Image)
                    .HasMaxLength(250)
                    .HasColumnName("image");

                entity.Property(e => e.Isactive).HasColumnName("isactive");
            });

          
          

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("state", "shoppingbasket");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Idnetwork).HasColumnName("idnetwork");

                entity.Property(e => e.Idorder).HasColumnName("idorder");

                entity.Property(e => e.Idstatetype).HasColumnName("idstatetype");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.HasOne(d => d.IdorderNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idorder)
                    .HasConstraintName("FK_state_menuorder");

                entity.HasOne(d => d.IdstatetypeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idstatetype)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_state_statetype");
            });

         

            modelBuilder.Entity<Statetype>(entity =>
            {
                entity.ToTable("statetype", "shoppingbasket");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Subfactor>(entity =>
            {
                entity.ToTable("subfactor", "pay");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Idfactor).HasColumnName("idfactor");

                entity.Property(e => e.Idmenu).HasColumnName("idmenu");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("price");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_User")
                    .IsClustered(false);

                entity.ToTable("user", "Security");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("UserRoles", "Security");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Deletedate)
                    .HasPrecision(3)
                    .HasColumnName("deletedate");

                entity.Property(e => e.Enddate)
                    .HasPrecision(3)
                    .HasColumnName("enddate");

                entity.Property(e => e.Idroles).HasColumnName("idroles");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Isdelete).HasColumnName("isdelete");

                entity.Property(e => e.Startdate)
                    .HasPrecision(3)
                    .HasColumnName("startdate");

                entity.HasOne(d => d.IdrolesNavigation)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.Idroles)
                    .HasConstraintName("FK_UserRoles_Role");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UserRoles_User");
            });

            modelBuilder.Entity<Useractive>(entity =>
            {
                entity.ToTable("useractive", "Security");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Idoperator).HasColumnName("idoperator");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Useractives)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UserActive_User");
            });

            modelBuilder.Entity<Userbitum>(entity =>
            {
                entity.ToTable("userbita", "post");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(450)
                    .HasColumnName("address");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.Description)
                    .HasMaxLength(2500)
                    .HasColumnName("description");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Region)
                    .HasMaxLength(50)
                    .HasColumnName("region");
            });

            modelBuilder.Entity<Userdelete>(entity =>
            {
                entity.ToTable("userdelete", "Security");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Userdeletes)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UserDelete_User");
            });

            modelBuilder.Entity<Useremail>(entity =>
            {
                entity.ToTable("useremail", "Security");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .HasColumnName("email");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Useremails)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_useremail_user");
            });

            modelBuilder.Entity<Useremailconfirmation>(entity =>
            {
                entity.ToTable("useremailconfirmation", "Security");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Codeverification)
                    .HasMaxLength(6)
                    .HasColumnName("codeverification");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .HasColumnName("email");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Useremailconfirmations)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UserEmailConfirmation_User");
            });

            modelBuilder.Entity<Userlock>(entity =>
            {
                entity.ToTable("Userlock", "Security");

                entity.Property(e => e.Enddate)
                    .HasPrecision(3)
                    .HasColumnName("enddate");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Iduserlocktype).HasColumnName("iduserlocktype");

                entity.Property(e => e.Iduseroprator).HasColumnName("iduseroprator");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Startdate)
                    .HasPrecision(3)
                    .HasColumnName("startdate");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Userlocks)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Userlock_user");

                entity.HasOne(d => d.IduserlocktypeNavigation)
                    .WithMany(p => p.Userlocks)
                    .HasForeignKey(d => d.Iduserlocktype)
                    .HasConstraintName("FK_Userlock_Userlocktype");
            });

            modelBuilder.Entity<Userlocktype>(entity =>
            {
                entity.ToTable("Userlocktype", "Security");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("message");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Usermediatype>(entity =>
            {
                entity.ToTable("Usermediatype", "Security");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Usermedium>(entity =>
            {
                entity.ToTable("Usermedia", "Security");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datecreate)
                    .HasPrecision(3)
                    .HasColumnName("datecreate");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Idnetwork).HasColumnName("idnetwork");

                entity.Property(e => e.Idusermediatype).HasColumnName("idusermediatype");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Mojaze).HasColumnName("mojaze");

                entity.Property(e => e.Path)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("path");

                entity.HasOne(d => d.IdnetworkNavigation)
                    .WithMany(p => p.Usermedia)
                    .HasForeignKey(d => d.Idnetwork)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Usermedia_network");
            });

            modelBuilder.Entity<Userpass>(entity =>
            {
                entity.ToTable("userpass", "Security");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Pass)
                    .HasMaxLength(300)
                    .HasColumnName("pass");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Userpasses)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UserPass_User");
            });

            modelBuilder.Entity<Usersm>(entity =>
            {
                entity.ToTable("Usersms", "Security");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .HasColumnName("code");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.Idsoftwaremodel).HasColumnName("idsoftwaremodel");

                entity.Property(e => e.Idusertypesms).HasColumnName("idusertypesms");

                entity.Property(e => e.Message)
                    .HasMaxLength(500)
                    .HasColumnName("message");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(15)
                    .HasColumnName("mobile");
            });

            modelBuilder.Entity<Usersmstype>(entity =>
            {
                entity.ToTable("Usersmstype", "Security");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Usersystemip>(entity =>
            {
                entity.ToTable("usersystemip", "pay");

                entity.HasComment("مشخص میکند که چه کاربری با چه سیستمی و آی پی ای وارد شده است");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Idsystem)
                    .HasMaxLength(300)
                    .HasColumnName("idsystem");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Ip)
                    .HasMaxLength(32)
                    .HasColumnName("ip");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Usersystemips)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_usersystemip_user");
            });

            modelBuilder.Entity<Usertell>(entity =>
            {
                entity.ToTable("usertell", "Security");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Tell)
                    .HasMaxLength(15)
                    .HasColumnName("tell");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Usertells)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UserTell_User");
            });

            modelBuilder.Entity<Usertellconfirmation>(entity =>
            {
                entity.ToTable("usertellconfirmation", "Security");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Codeverification)
                    .HasMaxLength(6)
                    .HasColumnName("codeverification");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Isactive)
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Isdelete)
                    .HasColumnName("isdelete")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tell)
                    .HasMaxLength(24)
                    .HasColumnName("tell");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Usertellconfirmations)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UserTellConfirmation_User");
            });

            modelBuilder.Entity<Usertoken>(entity =>
            {
                entity.ToTable("usertoken", "Security");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Idostype).HasColumnName("idostype");

                entity.Property(e => e.Iduser)
                    .HasMaxLength(450)
                    .HasColumnName("iduser");

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.IdostypeNavigation)
                    .WithMany(p => p.Usertokens)
                    .HasForeignKey(d => d.Idostype)
                    .HasConstraintName("FK_usertoken_ostype");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Usertokens)
                    .HasForeignKey(d => d.Iduser)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UserToken_User");
            });

            modelBuilder.Entity<Valuebody>(entity =>
            {
                entity.ToTable("valuebody", "value");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Idclient).HasColumnName("idclient");

                entity.Property(e => e.Iduser).HasColumnName("iduser");

                entity.Property(e => e.Idvalue).HasColumnName("idvalue");

                entity.Property(e => e.Value)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<Valuetype>(entity =>
            {
                entity.ToTable("valuetype", "value");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Path)
                    .HasMaxLength(250)
                    .HasColumnName("path");
            });

            modelBuilder.Entity<Vip>(entity =>
            {
                entity.ToTable("vip", "pay");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Days).HasColumnName("days");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Image)
                    .HasMaxLength(250)
                    .HasColumnName("image");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("price");
            });

            modelBuilder.Entity<Vipuser>(entity =>
            {
                entity.ToTable("vipuser", "pay");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Expiredate)
                    .HasMaxLength(10)
                    .HasColumnName("expiredate")
                    .IsFixedLength(true);

                entity.Property(e => e.Iduser).HasColumnName("iduser");

                entity.Property(e => e.Idvip).HasColumnName("idvip");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<Yarpartner>(entity =>
            {
                entity.ToTable("yarpartner", "partner");

                entity.HasComment("شرکت هایی که بعنوان شریک در فروش قرار است با برنامه همکاری کنند");

                entity.HasIndex(e => e.Wad, "IX_yarpartner")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id")
                    .HasComment("");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Description)
                    .HasMaxLength(1200)
                    .HasColumnName("description");

                entity.Property(e => e.Imagelogo)
                    .HasMaxLength(300)
                    .HasColumnName("imagelogo");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Title)
                    .HasMaxLength(400)
                    .HasColumnName("title");

                entity.Property(e => e.Wad)
                    .HasMaxLength(300)
                    .HasColumnName("wad");
            });

            modelBuilder.Entity<Yarpartnerporsant>(entity =>
            {
                entity.ToTable("yarpartnerporsant", "partner");

                entity.HasComment("درصد پورسانت مربوط به یک شریک کاری را ذخیره میکند");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Idsoftwaremodel).HasColumnName("idsoftwaremodel");

                entity.Property(e => e.Idyarpartner).HasColumnName("idyarpartner");

                entity.Property(e => e.Percent)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("percent");

                entity.HasOne(d => d.IdsoftwaremodelNavigation)
                    .WithMany(p => p.Yarpartnerporsants)
                    .HasForeignKey(d => d.Idsoftwaremodel)
                    .HasConstraintName("FK_yarpartnerporsant_softwaremodel");

                entity.HasOne(d => d.IdyarpartnerNavigation)
                    .WithMany(p => p.Yarpartnerporsants)
                    .HasForeignKey(d => d.Idyarpartner)
                    .HasConstraintName("FK_yarpartnerporsant_yarpartner");
            });

            modelBuilder.Entity<Yarpartneruser>(entity =>
            {
                entity.ToTable("yarpartneruser", "partner");

                entity.HasComment("مشخص میشه که هر کاربر از طریق کدام شریک کاری نرم افزار را نصب کرده است");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Datecreate)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreate");

                entity.Property(e => e.Iduser).HasColumnName("iduser");

                entity.Property(e => e.Idyarpartner).HasColumnName("idyarpartner");

                entity.Property(e => e.Idyarpartnerporsant).HasColumnName("idyarpartnerporsant");

                entity.HasOne(d => d.IdyarpartnerNavigation)
                    .WithMany(p => p.Yarpartnerusers)
                    .HasForeignKey(d => d.Idyarpartner)
                    .HasConstraintName("FK_yarpartneruser_yarpartner");

                entity.HasOne(d => d.IdyarpartnerporsantNavigation)
                    .WithMany(p => p.Yarpartnerusers)
                    .HasForeignKey(d => d.Idyarpartnerporsant)
                    .HasConstraintName("FK_yarpartneruser_yarpartnerporsant");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
