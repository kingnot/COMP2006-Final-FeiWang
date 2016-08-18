/**
 * Authors & Student Number: Fei Wang 200278460
 * Date Modified: 08-18-2016
 * File Description: This is the Model of data for Album class
 */

namespace COMP2006_Final_FeiWang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Album
    {
        public int AlbumId { get; set; }

        public int GenreId { get; set; }

        public int ArtistId { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public string AlbumArtUrl { get; set; }

        public virtual Artist Artist { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
