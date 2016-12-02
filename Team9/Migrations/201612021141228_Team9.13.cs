namespace Team9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Team913 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Songs", "SongAlbum_AlbumID", "dbo.Albums");
            DropIndex("dbo.Songs", new[] { "SongAlbum_AlbumID" });
            CreateTable(
                "dbo.SongAlbums",
                c => new
                    {
                        Song_SongID = c.Int(nullable: false),
                        Album_AlbumID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Song_SongID, t.Album_AlbumID })
                .ForeignKey("dbo.Songs", t => t.Song_SongID, cascadeDelete: true)
                .ForeignKey("dbo.Albums", t => t.Album_AlbumID, cascadeDelete: true)
                .Index(t => t.Song_SongID)
                .Index(t => t.Album_AlbumID);
            
            DropColumn("dbo.Songs", "SongAlbum_AlbumID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Songs", "SongAlbum_AlbumID", c => c.Int());
            DropForeignKey("dbo.SongAlbums", "Album_AlbumID", "dbo.Albums");
            DropForeignKey("dbo.SongAlbums", "Song_SongID", "dbo.Songs");
            DropIndex("dbo.SongAlbums", new[] { "Album_AlbumID" });
            DropIndex("dbo.SongAlbums", new[] { "Song_SongID" });
            DropTable("dbo.SongAlbums");
            CreateIndex("dbo.Songs", "SongAlbum_AlbumID");
            AddForeignKey("dbo.Songs", "SongAlbum_AlbumID", "dbo.Albums", "AlbumID");
        }
    }
}
