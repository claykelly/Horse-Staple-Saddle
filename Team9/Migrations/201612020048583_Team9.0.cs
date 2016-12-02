namespace Team9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Team90 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        AlbumID = c.Int(nullable: false, identity: true),
                        AlbumName = c.String(nullable: false),
                        isDiscounted = c.Boolean(nullable: false),
                        AlbumPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiscountAlbumPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.AlbumID);
            
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        ArtistID = c.Int(nullable: false, identity: true),
                        ArtistName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ArtistID);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreID = c.Int(nullable: false, identity: true),
                        GenreName = c.String(),
                    })
                .PrimaryKey(t => t.GenreID);
            
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        SongID = c.Int(nullable: false, identity: true),
                        SongName = c.String(nullable: false),
                        SongPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        isDiscoutned = c.Boolean(nullable: false),
                        DiscountPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SongLength = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SongAlbum_AlbumID = c.Int(),
                    })
                .PrimaryKey(t => t.SongID)
                .ForeignKey("dbo.Albums", t => t.SongAlbum_AlbumID)
                .Index(t => t.SongAlbum_AlbumID);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        RatingID = c.Int(nullable: false, identity: true),
                        RatingText = c.String(),
                        RatingValue = c.Int(nullable: false),
                        RatingAlbum_AlbumID = c.Int(),
                        RatingArtist_ArtistID = c.Int(),
                        RatingSong_SongID = c.Int(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.RatingID)
                .ForeignKey("dbo.Albums", t => t.RatingAlbum_AlbumID)
                .ForeignKey("dbo.Artists", t => t.RatingArtist_ArtistID)
                .ForeignKey("dbo.Songs", t => t.RatingSong_SongID)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.RatingAlbum_AlbumID)
                .Index(t => t.RatingArtist_ArtistID)
                .Index(t => t.RatingSong_SongID)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FName = c.String(),
                        LName = c.String(),
                        SSN = c.String(),
                        City = c.String(),
                        State = c.String(),
                        StreeAddress = c.String(),
                        Zip = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                        CC1_CreditCardID = c.Int(),
                        CC2_CreditCardID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CreditCards", t => t.CC1_CreditCardID)
                .ForeignKey("dbo.CreditCards", t => t.CC2_CreditCardID)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex")
                .Index(t => t.CC1_CreditCardID)
                .Index(t => t.CC2_CreditCardID);
            
            CreateTable(
                "dbo.CreditCards",
                c => new
                    {
                        CreditCardID = c.Int(nullable: false, identity: true),
                        CCNumber = c.String(),
                        CardOwner_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CreditCardID)
                .ForeignKey("dbo.AspNetUsers", t => t.CardOwner_Id)
                .Index(t => t.CardOwner_Id);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        PurchaseID = c.Int(nullable: false, identity: true),
                        isPurchased = c.Boolean(nullable: false),
                        PurchaseDate = c.DateTime(),
                        isGift = c.Boolean(nullable: false),
                        GiftUser_Id = c.String(maxLength: 128),
                        PurchaseCard_CreditCardID = c.Int(),
                        PurchaseUser_Id = c.String(maxLength: 128),
                        AppUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PurchaseID)
                .ForeignKey("dbo.AspNetUsers", t => t.GiftUser_Id)
                .ForeignKey("dbo.CreditCards", t => t.PurchaseCard_CreditCardID)
                .ForeignKey("dbo.AspNetUsers", t => t.PurchaseUser_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AppUser_Id)
                .Index(t => t.GiftUser_Id)
                .Index(t => t.PurchaseCard_CreditCardID)
                .Index(t => t.PurchaseUser_Id)
                .Index(t => t.AppUser_Id);
            
            CreateTable(
                "dbo.PurchaseItems",
                c => new
                    {
                        PurchaseItemID = c.Int(nullable: false, identity: true),
                        PurchaseItemPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        isAlbum = c.Boolean(nullable: false),
                        Purchase_PurchaseID = c.Int(),
                        PurchaseItemAlbum_AlbumID = c.Int(),
                        PurchaseItemSong_SongID = c.Int(),
                    })
                .PrimaryKey(t => t.PurchaseItemID)
                .ForeignKey("dbo.Purchases", t => t.Purchase_PurchaseID)
                .ForeignKey("dbo.Albums", t => t.PurchaseItemAlbum_AlbumID)
                .ForeignKey("dbo.Songs", t => t.PurchaseItemSong_SongID)
                .Index(t => t.Purchase_PurchaseID)
                .Index(t => t.PurchaseItemAlbum_AlbumID)
                .Index(t => t.PurchaseItemSong_SongID);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.ArtistAlbums",
                c => new
                    {
                        Artist_ArtistID = c.Int(nullable: false),
                        Album_AlbumID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Artist_ArtistID, t.Album_AlbumID })
                .ForeignKey("dbo.Artists", t => t.Artist_ArtistID, cascadeDelete: true)
                .ForeignKey("dbo.Albums", t => t.Album_AlbumID, cascadeDelete: true)
                .Index(t => t.Artist_ArtistID)
                .Index(t => t.Album_AlbumID);
            
            CreateTable(
                "dbo.GenreAlbums",
                c => new
                    {
                        Genre_GenreID = c.Int(nullable: false),
                        Album_AlbumID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Genre_GenreID, t.Album_AlbumID })
                .ForeignKey("dbo.Genres", t => t.Genre_GenreID, cascadeDelete: true)
                .ForeignKey("dbo.Albums", t => t.Album_AlbumID, cascadeDelete: true)
                .Index(t => t.Genre_GenreID)
                .Index(t => t.Album_AlbumID);
            
            CreateTable(
                "dbo.GenreArtists",
                c => new
                    {
                        Genre_GenreID = c.Int(nullable: false),
                        Artist_ArtistID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Genre_GenreID, t.Artist_ArtistID })
                .ForeignKey("dbo.Genres", t => t.Genre_GenreID, cascadeDelete: true)
                .ForeignKey("dbo.Artists", t => t.Artist_ArtistID, cascadeDelete: true)
                .Index(t => t.Genre_GenreID)
                .Index(t => t.Artist_ArtistID);
            
            CreateTable(
                "dbo.SongArtists",
                c => new
                    {
                        Song_SongID = c.Int(nullable: false),
                        Artist_ArtistID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Song_SongID, t.Artist_ArtistID })
                .ForeignKey("dbo.Songs", t => t.Song_SongID, cascadeDelete: true)
                .ForeignKey("dbo.Artists", t => t.Artist_ArtistID, cascadeDelete: true)
                .Index(t => t.Song_SongID)
                .Index(t => t.Artist_ArtistID);
            
            CreateTable(
                "dbo.SongGenres",
                c => new
                    {
                        Song_SongID = c.Int(nullable: false),
                        Genre_GenreID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Song_SongID, t.Genre_GenreID })
                .ForeignKey("dbo.Songs", t => t.Song_SongID, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.Genre_GenreID, cascadeDelete: true)
                .Index(t => t.Song_SongID)
                .Index(t => t.Genre_GenreID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Ratings", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Purchases", "AppUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Purchases", "PurchaseUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.PurchaseItems", "PurchaseItemSong_SongID", "dbo.Songs");
            DropForeignKey("dbo.PurchaseItems", "PurchaseItemAlbum_AlbumID", "dbo.Albums");
            DropForeignKey("dbo.PurchaseItems", "Purchase_PurchaseID", "dbo.Purchases");
            DropForeignKey("dbo.Purchases", "PurchaseCard_CreditCardID", "dbo.CreditCards");
            DropForeignKey("dbo.Purchases", "GiftUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "CC2_CreditCardID", "dbo.CreditCards");
            DropForeignKey("dbo.AspNetUsers", "CC1_CreditCardID", "dbo.CreditCards");
            DropForeignKey("dbo.CreditCards", "CardOwner_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Ratings", "RatingSong_SongID", "dbo.Songs");
            DropForeignKey("dbo.Ratings", "RatingArtist_ArtistID", "dbo.Artists");
            DropForeignKey("dbo.Ratings", "RatingAlbum_AlbumID", "dbo.Albums");
            DropForeignKey("dbo.SongGenres", "Genre_GenreID", "dbo.Genres");
            DropForeignKey("dbo.SongGenres", "Song_SongID", "dbo.Songs");
            DropForeignKey("dbo.SongArtists", "Artist_ArtistID", "dbo.Artists");
            DropForeignKey("dbo.SongArtists", "Song_SongID", "dbo.Songs");
            DropForeignKey("dbo.Songs", "SongAlbum_AlbumID", "dbo.Albums");
            DropForeignKey("dbo.GenreArtists", "Artist_ArtistID", "dbo.Artists");
            DropForeignKey("dbo.GenreArtists", "Genre_GenreID", "dbo.Genres");
            DropForeignKey("dbo.GenreAlbums", "Album_AlbumID", "dbo.Albums");
            DropForeignKey("dbo.GenreAlbums", "Genre_GenreID", "dbo.Genres");
            DropForeignKey("dbo.ArtistAlbums", "Album_AlbumID", "dbo.Albums");
            DropForeignKey("dbo.ArtistAlbums", "Artist_ArtistID", "dbo.Artists");
            DropIndex("dbo.SongGenres", new[] { "Genre_GenreID" });
            DropIndex("dbo.SongGenres", new[] { "Song_SongID" });
            DropIndex("dbo.SongArtists", new[] { "Artist_ArtistID" });
            DropIndex("dbo.SongArtists", new[] { "Song_SongID" });
            DropIndex("dbo.GenreArtists", new[] { "Artist_ArtistID" });
            DropIndex("dbo.GenreArtists", new[] { "Genre_GenreID" });
            DropIndex("dbo.GenreAlbums", new[] { "Album_AlbumID" });
            DropIndex("dbo.GenreAlbums", new[] { "Genre_GenreID" });
            DropIndex("dbo.ArtistAlbums", new[] { "Album_AlbumID" });
            DropIndex("dbo.ArtistAlbums", new[] { "Artist_ArtistID" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.PurchaseItems", new[] { "PurchaseItemSong_SongID" });
            DropIndex("dbo.PurchaseItems", new[] { "PurchaseItemAlbum_AlbumID" });
            DropIndex("dbo.PurchaseItems", new[] { "Purchase_PurchaseID" });
            DropIndex("dbo.Purchases", new[] { "AppUser_Id" });
            DropIndex("dbo.Purchases", new[] { "PurchaseUser_Id" });
            DropIndex("dbo.Purchases", new[] { "PurchaseCard_CreditCardID" });
            DropIndex("dbo.Purchases", new[] { "GiftUser_Id" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.CreditCards", new[] { "CardOwner_Id" });
            DropIndex("dbo.AspNetUsers", new[] { "CC2_CreditCardID" });
            DropIndex("dbo.AspNetUsers", new[] { "CC1_CreditCardID" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Ratings", new[] { "User_Id" });
            DropIndex("dbo.Ratings", new[] { "RatingSong_SongID" });
            DropIndex("dbo.Ratings", new[] { "RatingArtist_ArtistID" });
            DropIndex("dbo.Ratings", new[] { "RatingAlbum_AlbumID" });
            DropIndex("dbo.Songs", new[] { "SongAlbum_AlbumID" });
            DropTable("dbo.SongGenres");
            DropTable("dbo.SongArtists");
            DropTable("dbo.GenreArtists");
            DropTable("dbo.GenreAlbums");
            DropTable("dbo.ArtistAlbums");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.PurchaseItems");
            DropTable("dbo.Purchases");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.CreditCards");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Ratings");
            DropTable("dbo.Songs");
            DropTable("dbo.Genres");
            DropTable("dbo.Artists");
            DropTable("dbo.Albums");
        }
    }
}
