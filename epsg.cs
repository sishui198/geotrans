   public class epsg
    {
        #region Xian 1980
        public static string gcs_4610 = "GEOGCS[\"Xian 1980\",    DATUM[\"Xian_1980\",        SPHEROID[\"IAG 1975\",6378140,298.257,            AUTHORITY[\"EPSG\",\"7049\"]],        AUTHORITY[\"EPSG\",\"6610\"]],    PRIMEM[\"Greenwich\",0,        AUTHORITY[\"EPSG\",\"8901\"]],    UNIT[\"degree\",0.0174532925199433,        AUTHORITY[\"EPSG\",\"9122\"]],    AUTHORITY[\"EPSG\",\"4610\"]]";
        #endregion      
        #region China Geodetic Coordinate System 2000
        public static string gcs_4479 = "GEOCCS[\"China Geodetic Coordinate System 2000\",    DATUM[\"China_2000\",        SPHEROID[\"CGCS2000\",6378137,298.257222101,            AUTHORITY[\"EPSG\",\"1024\"]],        AUTHORITY[\"EPSG\",\"1043\"]],    PRIMEM[\"Greenwich\",0,        AUTHORITY[\"EPSG\",\"8901\"]],    UNIT[\"metre\",1,        AUTHORITY[\"EPSG\",\"9001\"]],    AXIS[\"Geocentric X\",OTHER],    AXIS[\"Geocentric Y\",OTHER],    AXIS[\"Geocentric Z\",NORTH],    AUTHORITY[\"EPSG\",\"4479\"]]";
        #endregion
        #region WGS 84 
        public static string gcs_4326 = "GEOGCS[\"WGS 84\",    DATUM[\"WGS_1984\",        SPHEROID[\"WGS 84\",6378137,298.257223563,            AUTHORITY[\"EPSG\",\"7030\"]],        AUTHORITY[\"EPSG\",\"6326\"]],    PRIMEM[\"Greenwich\",0,        AUTHORITY[\"EPSG\",\"8901\"]],    UNIT[\"degree\",0.0174532925199433,        AUTHORITY[\"EPSG\",\"9122\"]],    AUTHORITY[\"EPSG\",\"4326\"]]";
        #endregion
        #region WGS 84 / Pseudo-Mercator -- Spherical Mercator, Google Maps, OpenStreetMap, Bing, ArcGIS, ESRI
        public static string projcs_3857 = "PROJCS[\"WGS 84 / Pseudo-Mercator\",GEOGCS[\"WGS 84\",DATUM[\"WGS_1984\",SPHEROID[\"WGS 84\",6378137,298.257223563,AUTHORITY[\"EPSG\",\"7030\"]],AUTHORITY[\"EPSG\",\"6326\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.0174532925199433,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4326\"]],PROJECTION[\"Mercator_1SP\"],PARAMETER[\"central_meridian\",0],PARAMETER[\"scale_factor\",1],PARAMETER[\"false_easting\",0],PARAMETER[\"false_northing\",0],UNIT[\"metre\",1,AUTHORITY[\"EPSG\",\"9001\"]],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH],EXTENSION[\"PROJ4\",\"+proj=merc +a=6378137 +b=6378137 +lat_ts=0.0 +lon_0=0.0 +x_0=0.0 +y_0=0 +k=1.0 +units=m +nadgrids=@null +wktext +no_defs\"],AUTHORITY[\"EPSG\",\"3857\"]]";
        #endregion
        #region Xian 1980 / 3-degree Gauss-Kruger CM 99E
        public static string projcs_2378 = "PROJCS[\"Xian 1980 / 3-degree Gauss-Kruger CM 99E\",    GEOGCS[\"Xian 1980\",        DATUM[\"Xian_1980\",            SPHEROID[\"IAG 1975\",6378140,298.257,                AUTHORITY[\"EPSG\",\"7049\"]],            AUTHORITY[\"EPSG\",\"6610\"]],        PRIMEM[\"Greenwich\",0,            AUTHORITY[\"EPSG\",\"8901\"]],        UNIT[\"degree\",0.0174532925199433,            AUTHORITY[\"EPSG\",\"9122\"]],        AUTHORITY[\"EPSG\",\"4610\"]],    PROJECTION[\"Transverse_Mercator\"],    PARAMETER[\"latitude_of_origin\",0],    PARAMETER[\"central_meridian\",99],    PARAMETER[\"scale_factor\",1],    PARAMETER[\"false_easting\",500000],    PARAMETER[\"false_northing\",0],    UNIT[\"metre\",1,        AUTHORITY[\"EPSG\",\"9001\"]],    AUTHORITY[\"EPSG\",\"2378\"]]";
        #endregion
        #region Xian 1980 / 3-degree Gauss-Kruger CM 102E
        public static string projcs_2379 = "PROJCS[\"Xian 1980 / 3-degree Gauss-Kruger CM 102E\",GEOGCS[\"Xian 1980\",DATUM[\"Xian_1980\",SPHEROID[\"IAG 1975\",6378140,298.257,AUTHORITY[\"EPSG\",\"7049\"]],AUTHORITY[\"EPSG\",\"6610\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.0174532925199433,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4610\"]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",0],PARAMETER[\"central_meridian\",102],PARAMETER[\"scale_factor\",1],PARAMETER[\"false_easting\",500000],PARAMETER[\"false_northing\",0],UNIT[\"metre\",1,AUTHORITY[\"EPSG\",\"9001\"]],AUTHORITY[\"EPSG\",\"2379\"]]";
        #endregion
        #region Xian 1980 / 3-degree Gauss-Kruger CM 105E
        public static string projcs_2380 = "PROJCS[\"Xian 1980 / 3-degree Gauss-Kruger CM 105E\",    GEOGCS[\"Xian 1980\",        DATUM[\"Xian_1980\",            SPHEROID[\"IAG 1975\",6378140,298.257,                AUTHORITY[\"EPSG\",\"7049\"]],            AUTHORITY[\"EPSG\",\"6610\"]],        PRIMEM[\"Greenwich\",0,            AUTHORITY[\"EPSG\",\"8901\"]],        UNIT[\"degree\",0.0174532925199433,            AUTHORITY[\"EPSG\",\"9122\"]],        AUTHORITY[\"EPSG\",\"4610\"]],    PROJECTION[\"Transverse_Mercator\"],    PARAMETER[\"latitude_of_origin\",0],    PARAMETER[\"central_meridian\",105],    PARAMETER[\"scale_factor\",1],    PARAMETER[\"false_easting\",500000],    PARAMETER[\"false_northing\",0],    UNIT[\"metre\",1,        AUTHORITY[\"EPSG\",\"9001\"]],    AUTHORITY[\"EPSG\",\"2380\"]]";
        #endregion
        #region Xian 1980 / 3-degree Gauss-Kruger CM 108E
        public static string projcs_2381 = "PROJCS[\"Xian 1980 / 3-degree Gauss-Kruger CM 108E\",    GEOGCS[\"Xian 1980\",        DATUM[\"Xian_1980\",            SPHEROID[\"IAG 1975\",6378140,298.257,                AUTHORITY[\"EPSG\",\"7049\"]],            AUTHORITY[\"EPSG\",\"6610\"]],        PRIMEM[\"Greenwich\",0,            AUTHORITY[\"EPSG\",\"8901\"]],        UNIT[\"degree\",0.0174532925199433,            AUTHORITY[\"EPSG\",\"9122\"]],        AUTHORITY[\"EPSG\",\"4610\"]],    PROJECTION[\"Transverse_Mercator\"],    PARAMETER[\"latitude_of_origin\",0],    PARAMETER[\"central_meridian\",108],    PARAMETER[\"scale_factor\",1],    PARAMETER[\"false_easting\",500000],    PARAMETER[\"false_northing\",0],    UNIT[\"metre\",1,        AUTHORITY[\"EPSG\",\"9001\"]],    AUTHORITY[\"EPSG\",\"2381\"]]";
        #endregion
        #region Xian 1980 / 3-degree Gauss-Kruger CM 111E
        public static string projcs_2382 = "PROJCS[\"Xian 1980 / 3-degree Gauss-Kruger CM 111E\",    GEOGCS[\"Xian 1980\",        DATUM[\"Xian_1980\",            SPHEROID[\"IAG 1975\",6378140,298.257,                AUTHORITY[\"EPSG\",\"7049\"]],            AUTHORITY[\"EPSG\",\"6610\"]],        PRIMEM[\"Greenwich\",0,            AUTHORITY[\"EPSG\",\"8901\"]],        UNIT[\"degree\",0.0174532925199433,            AUTHORITY[\"EPSG\",\"9122\"]],        AUTHORITY[\"EPSG\",\"4610\"]],    PROJECTION[\"Transverse_Mercator\"],    PARAMETER[\"latitude_of_origin\",0],    PARAMETER[\"central_meridian\",111],    PARAMETER[\"scale_factor\",1],    PARAMETER[\"false_easting\",500000],    PARAMETER[\"false_northing\",0],    UNIT[\"metre\",1,        AUTHORITY[\"EPSG\",\"9001\"]],    AUTHORITY[\"EPSG\",\"2382\"]]";
        #endregion
        #region Xian 1980 / 3-degree Gauss-Kruger CM 114E
        public static string projcs_2383 = "PROJCS[\"Xian 1980 / 3-degree Gauss-Kruger CM 114E\",    GEOGCS[\"Xian 1980\",        DATUM[\"Xian_1980\",            SPHEROID[\"IAG 1975\",6378140,298.257,                AUTHORITY[\"EPSG\",\"7049\"]],            AUTHORITY[\"EPSG\",\"6610\"]],        PRIMEM[\"Greenwich\",0,            AUTHORITY[\"EPSG\",\"8901\"]],        UNIT[\"degree\",0.0174532925199433,            AUTHORITY[\"EPSG\",\"9122\"]],        AUTHORITY[\"EPSG\",\"4610\"]],    PROJECTION[\"Transverse_Mercator\"],    PARAMETER[\"latitude_of_origin\",0],    PARAMETER[\"central_meridian\",114],    PARAMETER[\"scale_factor\",1],    PARAMETER[\"false_easting\",500000],    PARAMETER[\"false_northing\",0],    UNIT[\"metre\",1,        AUTHORITY[\"EPSG\",\"9001\"]],    AUTHORITY[\"EPSG\",\"2383\"]]";
        #endregion
        #region Xian 1980 / 3-degree Gauss-Kruger CM 117E
        public static string projcs_2384 = "PROJCS[\"Xian 1980 / 3-degree Gauss-Kruger CM 117E\",    GEOGCS[\"Xian 1980\",        DATUM[\"Xian_1980\",            SPHEROID[\"IAG 1975\",6378140,298.257,                AUTHORITY[\"EPSG\",\"7049\"]],            AUTHORITY[\"EPSG\",\"6610\"]],        PRIMEM[\"Greenwich\",0,            AUTHORITY[\"EPSG\",\"8901\"]],        UNIT[\"degree\",0.0174532925199433,            AUTHORITY[\"EPSG\",\"9122\"]],        AUTHORITY[\"EPSG\",\"4610\"]],    PROJECTION[\"Transverse_Mercator\"],    PARAMETER[\"latitude_of_origin\",0],    PARAMETER[\"central_meridian\",117],    PARAMETER[\"scale_factor\",1],    PARAMETER[\"false_easting\",500000],    PARAMETER[\"false_northing\",0],    UNIT[\"metre\",1,        AUTHORITY[\"EPSG\",\"9001\"]],    AUTHORITY[\"EPSG\",\"2384\"]]";
        #endregion
        #region Xian 1980 / 3-degree Gauss-Kruger CM 120E
        public static string projcs_2385 = "PROJCS[\"Xian 1980 / 3-degree Gauss-Kruger CM 120E\",    GEOGCS[\"Xian 1980\",        DATUM[\"Xian_1980\",            SPHEROID[\"IAG 1975\",6378140,298.257,                AUTHORITY[\"EPSG\",\"7049\"]],            AUTHORITY[\"EPSG\",\"6610\"]],        PRIMEM[\"Greenwich\",0,            AUTHORITY[\"EPSG\",\"8901\"]],        UNIT[\"degree\",0.0174532925199433,            AUTHORITY[\"EPSG\",\"9122\"]],        AUTHORITY[\"EPSG\",\"4610\"]],    PROJECTION[\"Transverse_Mercator\"],    PARAMETER[\"latitude_of_origin\",0],    PARAMETER[\"central_meridian\",120],    PARAMETER[\"scale_factor\",1],    PARAMETER[\"false_easting\",500000],    PARAMETER[\"false_northing\",0],    UNIT[\"metre\",1,        AUTHORITY[\"EPSG\",\"9001\"]],    AUTHORITY[\"EPSG\",\"2385\"]]";
        #endregion
        #region Xian 1980 / 3-degree Gauss-Kruger CM 123E
        public static string projcs_2386 = "PROJCS[\"Xian 1980 / 3-degree Gauss-Kruger CM 123E\",    GEOGCS[\"Xian 1980\",        DATUM[\"Xian_1980\",            SPHEROID[\"IAG 1975\",6378140,298.257,                AUTHORITY[\"EPSG\",\"7049\"]],            AUTHORITY[\"EPSG\",\"6610\"]],        PRIMEM[\"Greenwich\",0,            AUTHORITY[\"EPSG\",\"8901\"]],        UNIT[\"degree\",0.0174532925199433,            AUTHORITY[\"EPSG\",\"9122\"]],        AUTHORITY[\"EPSG\",\"4610\"]],    PROJECTION[\"Transverse_Mercator\"],    PARAMETER[\"latitude_of_origin\",0],    PARAMETER[\"central_meridian\",123],    PARAMETER[\"scale_factor\",1],    PARAMETER[\"false_easting\",500000],    PARAMETER[\"false_northing\",0],    UNIT[\"metre\",1,        AUTHORITY[\"EPSG\",\"9001\"]],    AUTHORITY[\"EPSG\",\"2386\"]]";
        #endregion
        #region Xian 1980 / 3-degree Gauss-Kruger CM 126E
        public static string projcs_2387 = "PROJCS[\"Xian 1980 / 3-degree Gauss-Kruger CM 126E\",    GEOGCS[\"Xian 1980\",        DATUM[\"Xian_1980\",            SPHEROID[\"IAG 1975\",6378140,298.257,                AUTHORITY[\"EPSG\",\"7049\"]],            AUTHORITY[\"EPSG\",\"6610\"]],        PRIMEM[\"Greenwich\",0,            AUTHORITY[\"EPSG\",\"8901\"]],        UNIT[\"degree\",0.0174532925199433,            AUTHORITY[\"EPSG\",\"9122\"]],        AUTHORITY[\"EPSG\",\"4610\"]],    PROJECTION[\"Transverse_Mercator\"],    PARAMETER[\"latitude_of_origin\",0],    PARAMETER[\"central_meridian\",126],    PARAMETER[\"scale_factor\",1],    PARAMETER[\"false_easting\",500000],    PARAMETER[\"false_northing\",0],    UNIT[\"metre\",1,        AUTHORITY[\"EPSG\",\"9001\"]],    AUTHORITY[\"EPSG\",\"2387\"]]";
        #endregion
        #region CGCS2000 / 3-degree Gauss-Kruger CM 99E
        public static string projcs_4542 = "PROJCS[\"CGCS2000 / 3-degree Gauss-Kruger CM 99E\",    GEOGCS[\"China Geodetic Coordinate System 2000\",        DATUM[\"China_2000\",            SPHEROID[\"CGCS2000\",6378137,298.257222101,                AUTHORITY[\"EPSG\",\"1024\"]],            AUTHORITY[\"EPSG\",\"1043\"]],        PRIMEM[\"Greenwich\",0,            AUTHORITY[\"EPSG\",\"8901\"]],        UNIT[\"degree\",0.0174532925199433,            AUTHORITY[\"EPSG\",\"9122\"]],        AUTHORITY[\"EPSG\",\"4490\"]],    PROJECTION[\"Transverse_Mercator\"],    PARAMETER[\"latitude_of_origin\",0],    PARAMETER[\"central_meridian\",99],    PARAMETER[\"scale_factor\",1],    PARAMETER[\"false_easting\",500000],    PARAMETER[\"false_northing\",0],    UNIT[\"metre\",1,        AUTHORITY[\"EPSG\",\"9001\"]],    AUTHORITY[\"EPSG\",\"4542\"]]";
        #endregion
        #region CGCS2000 / 3-degree Gauss-Kruger CM 102E
        public static string projcs_4543 = "PROJCS[\"CGCS2000 / 3-degree Gauss-Kruger CM 102E\",    GEOGCS[\"China Geodetic Coordinate System 2000\",        DATUM[\"China_2000\",            SPHEROID[\"CGCS2000\",6378137,298.257222101,                AUTHORITY[\"EPSG\",\"1024\"]],            AUTHORITY[\"EPSG\",\"1043\"]],        PRIMEM[\"Greenwich\",0,            AUTHORITY[\"EPSG\",\"8901\"]],        UNIT[\"degree\",0.0174532925199433,            AUTHORITY[\"EPSG\",\"9122\"]],        AUTHORITY[\"EPSG\",\"4490\"]],    PROJECTION[\"Transverse_Mercator\"],    PARAMETER[\"latitude_of_origin\",0],    PARAMETER[\"central_meridian\",102],    PARAMETER[\"scale_factor\",1],    PARAMETER[\"false_easting\",500000],    PARAMETER[\"false_northing\",0],    UNIT[\"metre\",1,        AUTHORITY[\"EPSG\",\"9001\"]],    AUTHORITY[\"EPSG\",\"4543\"]]";
        #endregion
        #region CGCS2000 / 3-degree Gauss-Kruger CM 105E
        public static string projcs_4544 = "PROJCS[\"CGCS2000 / 3-degree Gauss-Kruger CM 105E\",    GEOGCS[\"China Geodetic Coordinate System 2000\",        DATUM[\"China_2000\",            SPHEROID[\"CGCS2000\",6378137,298.257222101,                AUTHORITY[\"EPSG\",\"1024\"]],            AUTHORITY[\"EPSG\",\"1043\"]],        PRIMEM[\"Greenwich\",0,            AUTHORITY[\"EPSG\",\"8901\"]],        UNIT[\"degree\",0.0174532925199433,            AUTHORITY[\"EPSG\",\"9122\"]],        AUTHORITY[\"EPSG\",\"4490\"]],    PROJECTION[\"Transverse_Mercator\"],    PARAMETER[\"latitude_of_origin\",0],    PARAMETER[\"central_meridian\",105],    PARAMETER[\"scale_factor\",1],    PARAMETER[\"false_easting\",500000],    PARAMETER[\"false_northing\",0],    UNIT[\"metre\",1,        AUTHORITY[\"EPSG\",\"9001\"]],    AUTHORITY[\"EPSG\",\"4544\"]]";
        #endregion
        #region CGCS2000 / 3-degree Gauss-Kruger CM 108E
        public static string projcs_4545 = "PROJCS[\"CGCS2000 / 3-degree Gauss-Kruger CM 108E\",    GEOGCS[\"China Geodetic Coordinate System 2000\",        DATUM[\"China_2000\",            SPHEROID[\"CGCS2000\",6378137,298.257222101,                AUTHORITY[\"EPSG\",\"1024\"]],            AUTHORITY[\"EPSG\",\"1043\"]],        PRIMEM[\"Greenwich\",0,            AUTHORITY[\"EPSG\",\"8901\"]],        UNIT[\"degree\",0.0174532925199433,            AUTHORITY[\"EPSG\",\"9122\"]],        AUTHORITY[\"EPSG\",\"4490\"]],    PROJECTION[\"Transverse_Mercator\"],    PARAMETER[\"latitude_of_origin\",0],    PARAMETER[\"central_meridian\",108],    PARAMETER[\"scale_factor\",1],    PARAMETER[\"false_easting\",500000],    PARAMETER[\"false_northing\",0],    UNIT[\"metre\",1,        AUTHORITY[\"EPSG\",\"9001\"]],    AUTHORITY[\"EPSG\",\"4545\"]]";
        #endregion
        #region CGCS2000 / 3-degree Gauss-Kruger CM 111E
        public static string projcs_4546 = "PROJCS[\"CGCS2000 / 3-degree Gauss-Kruger CM 111E\",    GEOGCS[\"China Geodetic Coordinate System 2000\",        DATUM[\"China_2000\",            SPHEROID[\"CGCS2000\",6378137,298.257222101,                AUTHORITY[\"EPSG\",\"1024\"]],            AUTHORITY[\"EPSG\",\"1043\"]],        PRIMEM[\"Greenwich\",0,            AUTHORITY[\"EPSG\",\"8901\"]],        UNIT[\"degree\",0.0174532925199433,            AUTHORITY[\"EPSG\",\"9122\"]],        AUTHORITY[\"EPSG\",\"4490\"]],    PROJECTION[\"Transverse_Mercator\"],    PARAMETER[\"latitude_of_origin\",0],    PARAMETER[\"central_meridian\",111],    PARAMETER[\"scale_factor\",1],    PARAMETER[\"false_easting\",500000],    PARAMETER[\"false_northing\",0],    UNIT[\"metre\",1,        AUTHORITY[\"EPSG\",\"9001\"]],    AUTHORITY[\"EPSG\",\"4546\"]]";
        #endregion
        #region CGCS2000 / 3-degree Gauss-Kruger CM 114E
        public static string projcs_4547 = "PROJCS[\"CGCS2000 / 3-degree Gauss-Kruger CM 114E\",    GEOGCS[\"China Geodetic Coordinate System 2000\",        DATUM[\"China_2000\",            SPHEROID[\"CGCS2000\",6378137,298.257222101,                AUTHORITY[\"EPSG\",\"1024\"]],            AUTHORITY[\"EPSG\",\"1043\"]],        PRIMEM[\"Greenwich\",0,            AUTHORITY[\"EPSG\",\"8901\"]],        UNIT[\"degree\",0.0174532925199433,            AUTHORITY[\"EPSG\",\"9122\"]],        AUTHORITY[\"EPSG\",\"4490\"]],    PROJECTION[\"Transverse_Mercator\"],    PARAMETER[\"latitude_of_origin\",0],    PARAMETER[\"central_meridian\",114],    PARAMETER[\"scale_factor\",1],    PARAMETER[\"false_easting\",500000],    PARAMETER[\"false_northing\",0],    UNIT[\"metre\",1,        AUTHORITY[\"EPSG\",\"9001\"]],    AUTHORITY[\"EPSG\",\"4547\"]]";
        #endregion
        #region CGCS2000 / 3-degree Gauss-Kruger CM 117E
        public static string projcs_4548 = "PROJCS[\"CGCS2000 / 3-degree Gauss-Kruger CM 117E\",    GEOGCS[\"China Geodetic Coordinate System 2000\",        DATUM[\"China_2000\",            SPHEROID[\"CGCS2000\",6378137,298.257222101,                AUTHORITY[\"EPSG\",\"1024\"]],            AUTHORITY[\"EPSG\",\"1043\"]],        PRIMEM[\"Greenwich\",0,            AUTHORITY[\"EPSG\",\"8901\"]],        UNIT[\"degree\",0.0174532925199433,            AUTHORITY[\"EPSG\",\"9122\"]],        AUTHORITY[\"EPSG\",\"4490\"]],    PROJECTION[\"Transverse_Mercator\"],    PARAMETER[\"latitude_of_origin\",0],    PARAMETER[\"central_meridian\",117],    PARAMETER[\"scale_factor\",1],    PARAMETER[\"false_easting\",500000],    PARAMETER[\"false_northing\",0],    UNIT[\"metre\",1,        AUTHORITY[\"EPSG\",\"9001\"]],    AUTHORITY[\"EPSG\",\"4548\"]]";
        #endregion
        #region CGCS2000 / 3-degree Gauss-Kruger CM 120E
        public static string projcs_4549 = "PROJCS[\"CGCS2000 / 3-degree Gauss-Kruger CM 120E\",    GEOGCS[\"China Geodetic Coordinate System 2000\",        DATUM[\"China_2000\",            SPHEROID[\"CGCS2000\",6378137,298.257222101,                AUTHORITY[\"EPSG\",\"1024\"]],            AUTHORITY[\"EPSG\",\"1043\"]],        PRIMEM[\"Greenwich\",0,            AUTHORITY[\"EPSG\",\"8901\"]],        UNIT[\"degree\",0.0174532925199433,            AUTHORITY[\"EPSG\",\"9122\"]],        AUTHORITY[\"EPSG\",\"4490\"]],    PROJECTION[\"Transverse_Mercator\"],    PARAMETER[\"latitude_of_origin\",0],    PARAMETER[\"central_meridian\",120],    PARAMETER[\"scale_factor\",1],    PARAMETER[\"false_easting\",500000],    PARAMETER[\"false_northing\",0],    UNIT[\"metre\",1,        AUTHORITY[\"EPSG\",\"9001\"]],    AUTHORITY[\"EPSG\",\"4549\"]]";
        #endregion
        #region CGCS2000 / 3-degree Gauss-Kruger CM 123E
        public static string projcs_4550 = "PROJCS[\"CGCS2000 / 3-degree Gauss-Kruger CM 123E\",    GEOGCS[\"China Geodetic Coordinate System 2000\",        DATUM[\"China_2000\",            SPHEROID[\"CGCS2000\",6378137,298.257222101,                AUTHORITY[\"EPSG\",\"1024\"]],            AUTHORITY[\"EPSG\",\"1043\"]],        PRIMEM[\"Greenwich\",0,            AUTHORITY[\"EPSG\",\"8901\"]],        UNIT[\"degree\",0.0174532925199433,            AUTHORITY[\"EPSG\",\"9122\"]],        AUTHORITY[\"EPSG\",\"4490\"]],    PROJECTION[\"Transverse_Mercator\"],    PARAMETER[\"latitude_of_origin\",0],    PARAMETER[\"central_meridian\",123],    PARAMETER[\"scale_factor\",1],    PARAMETER[\"false_easting\",500000],    PARAMETER[\"false_northing\",0],    UNIT[\"metre\",1,        AUTHORITY[\"EPSG\",\"9001\"]],    AUTHORITY[\"EPSG\",\"4550\"]]";
        #endregion
        #region CGCS2000 / 3-degree Gauss-Kruger CM 126E
        public static string projcs_4551 = "PROJCS[\"CGCS2000 / 3-degree Gauss-Kruger CM 126E\",    GEOGCS[\"China Geodetic Coordinate System 2000\",        DATUM[\"China_2000\",            SPHEROID[\"CGCS2000\",6378137,298.257222101,                AUTHORITY[\"EPSG\",\"1024\"]],            AUTHORITY[\"EPSG\",\"1043\"]],        PRIMEM[\"Greenwich\",0,            AUTHORITY[\"EPSG\",\"8901\"]],        UNIT[\"degree\",0.0174532925199433,            AUTHORITY[\"EPSG\",\"9122\"]],        AUTHORITY[\"EPSG\",\"4490\"]],    PROJECTION[\"Transverse_Mercator\"],    PARAMETER[\"latitude_of_origin\",0],    PARAMETER[\"central_meridian\",126],    PARAMETER[\"scale_factor\",1],    PARAMETER[\"false_easting\",500000],    PARAMETER[\"false_northing\",0],    UNIT[\"metre\",1,        AUTHORITY[\"EPSG\",\"9001\"]],    AUTHORITY[\"EPSG\",\"4551\"]]";
        #endregion

    }
