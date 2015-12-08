namespace Teleimot.Common.Constants
{
    public class GlobalConstants
    {
        public const string RequestCannotBeEmpty = "Request model cannot be empty";

        public const int DefaultSkipCount = 0;
        public const int DefaultTakeCount = 10;
        public const int MaxTakeCount = 100;

        public const int RealEstateTitleMinLength = 5;
        public const int RealEstateTitleMaxLength = 50;

        public const int RealEstateDescritpionMinLength = 10;
        public const int RealEstateDescritpionMaxLength = 1000;
        public const int RealEstateYearMinValue = 1800;

        public const int CommentContentMinLength = 10;
        public const int CommentContentMaxLength = 500;

        public const int MinRatingValue = 1;
        public const int MaxRatingValue = 5;
    }
}
