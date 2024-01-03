﻿#region Using directives
using System.Collections.Generic;
using System.Linq;
using Blazorise.Providers;
#endregion

namespace Blazorise.Icons.Bootstrap;

class BootstrapIconProvider : BaseIconProvider
{
    #region Members

    private static Dictionary<IconName, string> names = new()
    {
        { IconName.Add, BootstrapIcons.Plus },
        { IconName.Adjust, BootstrapIcons.CircleHalf },
        { IconName.AlignCenter, BootstrapIcons.TextCenter },
        { IconName.AlignJustify, BootstrapIcons.Justify },
        { IconName.AlignLeft, BootstrapIcons.TextLeft },
        { IconName.AlignRight, BootstrapIcons.TextRight },
        { IconName.AngleDown, BootstrapIcons.ChevronDown },
        { IconName.AngleLeft, BootstrapIcons.ChevronLeft },
        { IconName.AngleRight, BootstrapIcons.ChevronRight },
        { IconName.AngleUp, BootstrapIcons.ChevronUp },
        { IconName.Archive, BootstrapIcons.Archive },
        { IconName.ArrowAltCircleDown, BootstrapIcons.ArrowDownCircle },
        { IconName.ArrowDown, BootstrapIcons.ArrowDown },
        { IconName.ArrowLeft, BootstrapIcons.ArrowLeft },
        { IconName.ArrowRight, BootstrapIcons.ArrowRight },
        { IconName.ArrowUp, BootstrapIcons.ArrowUp },
        // { IconName.Baby, "fa-baby" },
        // { IconName.BabyCarriage, "fa-baby-carriage" },
        { IconName.Backspace, BootstrapIcons.Backspace },
        { IconName.Backward, BootstrapIcons.SkipBackward },
        // { IconName.BalanceScale, "fa-balance-scale" },
        { IconName.Ban, BootstrapIcons.SlashCircle },
        { IconName.BandAid, BootstrapIcons.Bandaid },
        { IconName.Bars, BootstrapIcons.List },
        { IconName.BatteryFull, BootstrapIcons.BatteryFull },
        { IconName.Bell, BootstrapIcons.Bell },
        { IconName.BellSlash, BootstrapIcons.BellSlash },
        { IconName.Biking, BootstrapIcons.Bicycle },
        { IconName.BirthdayCake, BootstrapIcons.Balloon },
        { IconName.Bold, BootstrapIcons.TypeBold },
        { IconName.Bolt, BootstrapIcons.Lightning },
        { IconName.Book, BootstrapIcons.Book },
        { IconName.Bookmark, BootstrapIcons.Bookmark },
        { IconName.BookReader, BootstrapIcons.Eyeglasses },
        { IconName.BorderAll, BootstrapIcons.BorderAll },
        { IconName.BorderNone, BootstrapIcons.Border },
        { IconName.BorderStyle, BootstrapIcons.BorderStyle },
        { IconName.Briefcase, BootstrapIcons.Briefcase },
        { IconName.Brush, BootstrapIcons.Brush },
        { IconName.Bug, BootstrapIcons.Bug },
        { IconName.Building, BootstrapIcons.Building },
        { IconName.Bus, BootstrapIcons.BusFront },
        { IconName.CalendarCheck, BootstrapIcons.CalendarCheck },
        { IconName.CalendarDay, BootstrapIcons.CalendarDay },
        { IconName.CalendarTimes, BootstrapIcons.CalendarX },
        { IconName.CalendarWeek, BootstrapIcons.CalendarWeek },
        { IconName.Camera, BootstrapIcons.Camera },
        { IconName.CameraRetro, BootstrapIcons.Camera2 },
        { IconName.Car, BootstrapIcons.CarFront },
        { IconName.CaretSquareRight, BootstrapIcons.CaretRightSquare },
        { IconName.CartPlus, BootstrapIcons.CartPlus },
        // { IconName.Chair, "fa-chair" },
        { IconName.ChartPie, BootstrapIcons.PieChart },
        { IconName.Check, BootstrapIcons.Check },
        { IconName.CheckCircle, BootstrapIcons.CheckCircle },
        { IconName.CheckDouble, BootstrapIcons.Check2 },
        { IconName.CheckSquare, BootstrapIcons.CheckSquare },
        { IconName.ChevronLeft, BootstrapIcons.ChevronLeft },
        { IconName.ChevronRight, BootstrapIcons.ChevronRight },
        { IconName.ChevronUp, BootstrapIcons.ChevronUp },
        { IconName.ChevronDown, BootstrapIcons.ChevronDown },
        { IconName.Circle, BootstrapIcons.Circle },
        { IconName.City, BootstrapIcons.Building },
        { IconName.Clear, BootstrapIcons.Eraser },
        { IconName.ClinicMedical, BootstrapIcons.FileMedical },
        { IconName.Clock, BootstrapIcons.Clock },
        { IconName.ClosedCaptioning, BootstrapIcons.BadgeCc },
        { IconName.Cloud, BootstrapIcons.Cloud },
        { IconName.CloudDownloadAlt, BootstrapIcons.CloudDownload },
        { IconName.CloudUploadAlt, BootstrapIcons.CloudUpload },
        { IconName.Cocktail, BootstrapIcons.CupStraw },
        { IconName.Code, BootstrapIcons.CodeSlash },
        { IconName.Coffee, BootstrapIcons.Cup },
        { IconName.Comment, BootstrapIcons.Chat },
        { IconName.CommentAlt, BootstrapIcons.ChatDots },
        { IconName.Comments, BootstrapIcons.ChatText },
        { IconName.CompactDisc, BootstrapIcons.Disc },
        { IconName.Compass, BootstrapIcons.Compass },
        { IconName.Compress, BootstrapIcons.ArrowsCollapse },
        { IconName.Copyright, BootstrapIcons.CCircle },
        { IconName.CreditCard, BootstrapIcons.CreditCard },
        { IconName.Crop, BootstrapIcons.Crop },
        { IconName.Dashboard, BootstrapIcons.Columns },
        { IconName.Delete, BootstrapIcons.Trash },
        { IconName.Desktop, BootstrapIcons.Display },
        { IconName.Dice, BootstrapIcons.Dice1 },
        { IconName.Directions, BootstrapIcons.Signpost },
        // { IconName.Dog, "fa-dog" },
        { IconName.DollarSign, BootstrapIcons.CurrencyDollar },
        { IconName.DotCircle, BootstrapIcons.RecordCircle },
        { IconName.Download, BootstrapIcons.Download },
        // { IconName.Dumbbell, "fa-dumbbell" },
        { IconName.Edit, BootstrapIcons.PencilSquare },
        { IconName.Eject, BootstrapIcons.Eject },
        { IconName.Ethernet, BootstrapIcons.Ethernet },
        { IconName.EuroSign, BootstrapIcons.CurrencyEuro },
        { IconName.Exclamation, BootstrapIcons.Exclamation },
        { IconName.ExclamationCircle, BootstrapIcons.ExclamationCircle },
        { IconName.ExclamationTriangle, BootstrapIcons.ExclamationTriangle },
        { IconName.Expand, BootstrapIcons.Fullscreen },
        { IconName.ExpandArrowsAlt, BootstrapIcons.ArrowsFullscreen },
        { IconName.ExpandLess, BootstrapIcons.ChevronUp },
        { IconName.ExpandMore, BootstrapIcons.ChevronDown },
        { IconName.ExternalLinkSquareAlt, BootstrapIcons.BoxArrowUpRight },
        { IconName.Eye, BootstrapIcons.Eye },
        { IconName.EyeSlash, BootstrapIcons.EyeSlash },
        { IconName.FastForward, BootstrapIcons.SkipForward },
        { IconName.FileAlt, BootstrapIcons.FilesAlt },
        { IconName.FileDownload, BootstrapIcons.FileArrowDown },
        { IconName.FilePdf, BootstrapIcons.FilePdf },
        { IconName.FileUpload, BootstrapIcons.FileArrowUp },
        { IconName.Film, BootstrapIcons.Film },
        { IconName.Filter, BootstrapIcons.Filter },
        { IconName.Fingerprint, BootstrapIcons.Fingerprint },
        { IconName.Fire, BootstrapIcons.Fire },
        { IconName.Flag, BootstrapIcons.Flag },
        // { IconName.Flask, "fa-flask" },
        { IconName.Folder, BootstrapIcons.Folder },
        { IconName.FolderOpen, BootstrapIcons.Folder2Open },
        { IconName.FolderPlus, BootstrapIcons.FolderPlus },
        { IconName.Forward, BootstrapIcons.Forward },
        { IconName.Frown, BootstrapIcons.EmojiFrown },
        { IconName.FrownOpen, BootstrapIcons.EmojiFrownFill },
        { IconName.Gamepad, BootstrapIcons.Joystick },
        { IconName.GasPump, BootstrapIcons.FuelPump },
        // { IconName.Gavel, "fa-gavel" },
        { IconName.Gift, BootstrapIcons.Gift },
        { IconName.Grin, BootstrapIcons.EmojiWink },
        { IconName.GripLines, BootstrapIcons.GripHorizontal },
        // { IconName.HandPaper, "fa-hand-paper" },
        // { IconName.HandsHelping, "fa-hands-helping" },
        { IconName.Headphones, BootstrapIcons.Headphones },
        { IconName.Headset, BootstrapIcons.Headset },
        { IconName.Heart, BootstrapIcons.Heart },
        { IconName.Highlighter, BootstrapIcons.Highlighter },
        { IconName.History, BootstrapIcons.ClockHistory },
        { IconName.Home, BootstrapIcons.HouseDoor },
        { IconName.Hospital, BootstrapIcons.Hospital },
        // { IconName.Hotel, "fa-hotel" },
        // { IconName.HotTub, "fa-hot-tub" },
        { IconName.Hourglass, BootstrapIcons.Hourglass },
        { IconName.IdCard, BootstrapIcons.PersonBadge },
        { IconName.Image, BootstrapIcons.Image },
        { IconName.Images, BootstrapIcons.Images },
        { IconName.Inbox, BootstrapIcons.Inbox },
        { IconName.Indent, BootstrapIcons.TextIndentLeft },
        { IconName.Infinity, BootstrapIcons.Infinity },
        { IconName.Info, BootstrapIcons.Info },
        { IconName.InfoCircle, BootstrapIcons.InfoCircle },
        { IconName.Italic, BootstrapIcons.TypeItalic },
        { IconName.Key, BootstrapIcons.Key },
        { IconName.Keyboard, BootstrapIcons.Keyboard },
        { IconName.Language, BootstrapIcons.Translate },
        { IconName.Laptop, BootstrapIcons.Laptop },
        { IconName.LaptopCode, BootstrapIcons.CodeSquare },
        { IconName.Laugh, BootstrapIcons.EmojiLaughing },
        { IconName.LayerGroup, BootstrapIcons.Stack },
        { IconName.Lightbulb, BootstrapIcons.Lightbulb },
        { IconName.Link, BootstrapIcons.Link },
        { IconName.List, BootstrapIcons.List },
        { IconName.ListOl, BootstrapIcons.ListOl },
        { IconName.ListUl, BootstrapIcons.ListUl },
        { IconName.LocationArrow, BootstrapIcons.Cursor },
        { IconName.Lock, BootstrapIcons.Lock },
        { IconName.LockOpen, BootstrapIcons.Unlock },
        { IconName.Mail, BootstrapIcons.Envelope },
        { IconName.Map, BootstrapIcons.Map },
        { IconName.MapMarker, BootstrapIcons.Geo },
        { IconName.MapMarkerAlt, BootstrapIcons.GeoAlt },
        { IconName.Memory, BootstrapIcons.Memory },
        { IconName.Microphone, BootstrapIcons.Mic },
        { IconName.MicrophoneSlash, BootstrapIcons.MicMute },
        { IconName.MinusCircle, BootstrapIcons.DashCircle },
        { IconName.MinusSquare, BootstrapIcons.DashSquare },
        { IconName.MoneyBillAlt, BootstrapIcons.Cash },
        { IconName.MoreHorizontal, BootstrapIcons.ThreeDots },
        { IconName.MoreVertical, BootstrapIcons.ThreeDotsVertical },
        { IconName.Motorcycle, BootstrapIcons.Bicycle },
        { IconName.Mouse, BootstrapIcons.Mouse },
        { IconName.Music, BootstrapIcons.MusicNoteBeamed },
        { IconName.PaintBrush, BootstrapIcons.Brush },
        { IconName.PaintRoller, BootstrapIcons.Easel3 },
        { IconName.Palette, BootstrapIcons.Palette },
        { IconName.Paperclip, BootstrapIcons.Paperclip },
        // { IconName.PaperPlane, "fa-paper-plane" },
        { IconName.Parking, BootstrapIcons.PCircle },
        { IconName.Pause, BootstrapIcons.Pause },
        { IconName.PauseCircle, BootstrapIcons.PauseCircle },
        { IconName.Pen, BootstrapIcons.Pen },
        { IconName.Phone, BootstrapIcons.Telephone },
        { IconName.PhoneAlt, BootstrapIcons.TelephoneFill },
        // { IconName.PizzaSlice, "fa-pizza-slice" },
        { IconName.Plane, BootstrapIcons.Airplane },
        // { IconName.PlaneArrival, "fa-plane-arrival" },
        // { IconName.PlaneDeparture, "fa-plane-departure" },
        { IconName.Play, BootstrapIcons.Play },
        { IconName.PlayCircle, BootstrapIcons.PlayCircle },
        { IconName.Plug, BootstrapIcons.Plug },
        { IconName.PlusCircle, BootstrapIcons.PlusCircle },
        { IconName.PlusSquare, BootstrapIcons.PlusSquare },
        { IconName.Poll, BootstrapIcons.FileBarGraph },
        { IconName.Portrait, BootstrapIcons.PersonSquare },
        { IconName.Print, BootstrapIcons.Printer },
        { IconName.PuzzlePiece, BootstrapIcons.Puzzle },
        { IconName.QuestionCircle, BootstrapIcons.QuestionCircle },
        { IconName.QuoteRight, BootstrapIcons.Quote },
        { IconName.Random, BootstrapIcons.Shuffle },
        { IconName.Receipt, BootstrapIcons.Receipt },
        { IconName.Redo, BootstrapIcons.ArrowClockwise },
        { IconName.Remove, BootstrapIcons.Dash },
        // { IconName.RemoveFormat, "fa-remove-format" },
        { IconName.Reply, BootstrapIcons.Reply },
        { IconName.ReplyAll, BootstrapIcons.ReplyAll },
        { IconName.Restroom, BootstrapIcons.BadgeWc },
        { IconName.Rss, BootstrapIcons.Rss },
        { IconName.RulerHorizontal, BootstrapIcons.Rulers },
        // { IconName.Running, "fa-running" },
        // { IconName.Satellite, "fa-satellite" },
        { IconName.Save, BootstrapIcons.Save },
        { IconName.School, BootstrapIcons.Building },
        { IconName.SdCard, BootstrapIcons.SdCard },
        { IconName.Search, BootstrapIcons.Search },
        // { IconName.SearchMinus, "fa-search-minus" },
        // { IconName.SearchPlus, "fa-search-plus" },
        // { IconName.Seedling, "fa-seedling" },
        { IconName.Server, BootstrapIcons.Server },
        { IconName.Shapes, BootstrapIcons.PentagonHalf },
        { IconName.Share, BootstrapIcons.Share },
        { IconName.ShareAlt, BootstrapIcons.ShareFill },
        { IconName.ShieldAlt, BootstrapIcons.ShieldShaded },
        // { IconName.Ship, "fa-ship" },
        { IconName.ShoppingBag, BootstrapIcons.Bag },
        { IconName.ShoppingBasket, BootstrapIcons.Basket },
        { IconName.ShoppingCart, BootstrapIcons.Cart },
        // { IconName.ShuttleVan, "fa-shuttle-van" },
        { IconName.SimCard, BootstrapIcons.Sim },
        { IconName.SliderHorizontal, BootstrapIcons.Sliders },
        { IconName.Smartphone, BootstrapIcons.Phone },
        { IconName.Smile, BootstrapIcons.EmojiSmile },
        // { IconName.Smoking, "fa-smoking" },
        // { IconName.SmokingBan, "fa-smoking-ban" },
        { IconName.Sms, BootstrapIcons.ChatText },
        { IconName.Snowflake, BootstrapIcons.Snow },
        { IconName.Sort, BootstrapIcons.Funnel },
        { IconName.SortAlphaDown, BootstrapIcons.SortAlphaDown },
        { IconName.SortAmountDownAlt, BootstrapIcons.SortAlphaDownAlt },
        { IconName.SortDown, BootstrapIcons.SortDown },
        { IconName.SortUp, BootstrapIcons.SortUp },
        { IconName.Spa, BootstrapIcons.Flower1 },
        { IconName.SpellCheck, BootstrapIcons.Spellcheck },
        { IconName.Square, BootstrapIcons.Square },
        { IconName.Star, BootstrapIcons.Star },
        { IconName.StarHalf, BootstrapIcons.StarHalf },
        { IconName.StepBackward, BootstrapIcons.SkipBackward },
        { IconName.StepForward, BootstrapIcons.SkipForward },
        { IconName.StickyNote, BootstrapIcons.Sticky },
        { IconName.Stop, BootstrapIcons.Stop },
        { IconName.Store, BootstrapIcons.Shop },
        { IconName.StoreAlt, BootstrapIcons.ShopWindow },
        { IconName.Stream, BootstrapIcons.Cast },
        // { IconName.StreetView, "fa-street-view" },
        { IconName.Strikethrough, BootstrapIcons.TypeStrikethrough },
        { IconName.Subscript, BootstrapIcons.Subscript },
        // { IconName.Subway, "fa-subway" },
        { IconName.Suitcase, BootstrapIcons.Briefcase },
        { IconName.Sun, BootstrapIcons.Sun },
        { IconName.Superscript, BootstrapIcons.Superscript },
        { IconName.SwimmingPool, BootstrapIcons.Ladder },
        { IconName.Sync, BootstrapIcons.CloudArrowDown },
        { IconName.SyncAlt, BootstrapIcons.CloudArrowDownFill },
        { IconName.Tablet, BootstrapIcons.Tablet },
        { IconName.Tag, BootstrapIcons.Tag },
        { IconName.Taxi, BootstrapIcons.TaxiFront },
        { IconName.TextHeight, BootstrapIcons.TypeH1 },
        { IconName.ThumbsDown, BootstrapIcons.HandThumbsDown },
        { IconName.ThumbsUp, BootstrapIcons.HandThumbsUp },
        { IconName.TicketAlt, BootstrapIcons.Ticket },
        { IconName.Times, BootstrapIcons.X },
        { IconName.TimesCircle, BootstrapIcons.XCircle },
        { IconName.Tint, BootstrapIcons.Droplet },
        { IconName.TintSlash, BootstrapIcons.DropletHalf },
        { IconName.TrafficLight, BootstrapIcons.Stoplights },
        { IconName.Train, BootstrapIcons.TrainFront },
        { IconName.Tram, BootstrapIcons.TrainLightrailFront },
        { IconName.Tree, BootstrapIcons.Tree },
        { IconName.Truck, BootstrapIcons.Truck },
        { IconName.Tv, BootstrapIcons.Tv },
        { IconName.UmbrellaBeach, BootstrapIcons.Umbrella },
        { IconName.Underline, BootstrapIcons.TypeUnderline },
        { IconName.Undo, BootstrapIcons.ArrowCounterclockwise },
        { IconName.Unlock, BootstrapIcons.Unlock },
        { IconName.User, BootstrapIcons.Person },
        { IconName.UserCheck, BootstrapIcons.PersonCheck },
        { IconName.UserCircle, BootstrapIcons.PersonCircle },
        { IconName.UserFriends, BootstrapIcons.People },
        { IconName.UserPlus, BootstrapIcons.PersonPlus },
        { IconName.Users, BootstrapIcons.People },
        { IconName.UserTie, BootstrapIcons.Person },
        // { IconName.Utensils, "fa-utensils" },
        { IconName.Video, BootstrapIcons.CameraVideo },
        { IconName.VideoSlash, BootstrapIcons.CameraVideoOff },
        { IconName.Voicemail, BootstrapIcons.Voicemail },
        { IconName.VolumeDown, BootstrapIcons.VolumeDown },
        { IconName.VolumeMute, BootstrapIcons.VolumeMute },
        { IconName.VolumeOff, BootstrapIcons.VolumeOff },
        { IconName.VolumeUp, BootstrapIcons.VolumeUp },
        { IconName.Walking, BootstrapIcons.PersonWalking },
        { IconName.Wallet, BootstrapIcons.Wallet },
        { IconName.Wheelchair, BootstrapIcons.PersonWheelchair },
        { IconName.Wifi, BootstrapIcons.Wifi },
        //{ IconName.WineBottle, "fa-wine-bottle" },
        { IconName.Wrench, BootstrapIcons.Wrench },
    };

    #endregion

    #region Methods

    public override string IconSize( IconSize iconSize )
    {
        return iconSize switch
        {
            Blazorise.IconSize.ExtraSmall => "bi-xs",
            Blazorise.IconSize.Small => "bi-sm",
            Blazorise.IconSize.Large => "bi-lg",
            Blazorise.IconSize.x2 => "bi-2x",
            Blazorise.IconSize.x3 => "bi-3x",
            Blazorise.IconSize.x4 => "bi-4x",
            Blazorise.IconSize.x5 => "bi-5x",
            Blazorise.IconSize.x6 => "bi-6x",
            Blazorise.IconSize.x7 => "bi-7x",
            Blazorise.IconSize.x8 => "bi-8x",
            Blazorise.IconSize.x9 => "bi-9x",
            Blazorise.IconSize.x10 => "bi-10x",
            _ => null,
        };
    }

    public override string GetIconName( IconName iconName, IconStyle iconStyle )
    {
        names.TryGetValue( iconName, out var name );

        return name;
    }

    public override void SetIconName( IconName name, string newName )
    {
        names[name] = newName;
    }

    public override string GetStyleName( IconStyle iconStyle ) => null;

    protected override bool ContainsStyleName( string iconName ) => false;

    #endregion

    #region Properties

    public override bool IconNameAsContent => false;

    #endregion
}