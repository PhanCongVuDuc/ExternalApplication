using ExternalApplication.UIAttributeBase;

namespace ExampleCreateUIApp
{
    [Tab("Sonny Tab")]
    public class SonnyTab
    {
        [Panel("Sonny Pannel 1")]
        public class SonnyPannel1
        {
            [StackedButton("Sonny Stacked Button 1")]
            public class SonnySpitButton1
            {
                [Button("Sonny Button 1-1", "ExternalApplication.TestCmd", LinkImage = "image-16.png",
                    LongDescription = "This is Test", ToolTip = "This is toolTip", ToolTipImage = "image-32.png")]
                public class SonnyButton1
                {
                }

                [Button("Sonny Button 1-2", "ExternalApplication.TestCmd", LinkImage = "image-16.png",
                    LongDescription = "This is Test")]
                public class SonnyButton12
                {
                }
            }

            [Button("Sonny Button 1-3", "ExternalApplication.TestCmd", LinkImage = "image-16.png",
                LongDescription = "This is Test", ToolTip = "This is toolTip", ToolTipImage = "image-32.png")]
            public class SonnyButton2
            {
            }

            [Button("Sonny Button 1-4", "ExternalApplication.TestCmd", LinkImage = "image-16.png",
                LongDescription = "This is Test")]
            public class SonnyButton3
            {
            }

            [PulldownButtonData("Sonny Pulldown Button Data 1", LinkImage = "image-16.png",
                LongDescription = "This is Test", ToolTip = "This is toolTip", ToolTipImage = "image-32.png")]
            public class PulldownButtonData1
            {
                [Button("Sonny Button 1-5", "ExternalApplication.TestCmd", LinkImage = "image-16.png",
                    LongDescription = "This is Test", ToolTip = "This is toolTip", ToolTipImage = "image-32.png")]
                public class SonnyButton1
                {
                }

                [Button("Sonny Button 1-6", "ExternalApplication.TestCmd", LinkImage = "image-16.png",
                    LongDescription = "This is Test")]
                public class SonnyButton2
                {
                }

                [Button("Sonny Button 1-7", "ExternalApplication.TestCmd", LinkImage = "image-16.png",
                    LongDescription = "This is Test", ToolTip = "This is toolTip", ToolTipImage = "image-32.png")]
                public class SonnyButton3
                {
                }

                [Button("Sonny Button 1-8", "ExternalApplication.TestCmd", LinkImage = "image-16.png",
                    LongDescription = "This is Test")]
                public class SonnyButton4
                {
                }

                [Button("Sonny Button 1-9", "ExternalApplication.TestCmd", LinkImage = "image-16.png",
                    LongDescription = "This is Test", ToolTip = "This is toolTip", ToolTipImage = "image-32.png")]
                public class SonnyButton5
                {
                }

                [Button("Sonny Button 1-10", "ExternalApplication.TestCmd", LinkImage = "image-16.png",
                    LongDescription = "This is Test")]
                public class SonnyButton6
                {
                }
            }
        }

        [Panel("Sonny Pannel 2")]
        public class SonnyPannel2
        {
            [StackedButton("Sonny Stacked Button 2")]
            public class SonnySpitButton2
            {
                [Button("Sonny Button 2-1", "ExternalApplication.TestCmd", LinkImage = "image-16.png",
                    LongDescription = "This is Test")]
                public class SonnyButton1
                {
                }

                [Button("Sonny Button 2-2", "ExternalApplication.TestCmd", LinkImage = "image-16.png",
                    LongDescription = "This is Test")]
                public class SonnyButton2
                {
                }
            }

            [Button("Sonny Button 2-3", "ExternalApplication.TestCmd", LinkImage = "image-16.png",
                LongDescription = "This is Test")]
            public class SonnyButton3
            {
            }

            [Button("Sonny Button 2-4", "ExternalApplication.TestCmd", LinkImage = "image-16.png",
                LongDescription = "This is Test")]
            public class SonnyButton4
            {
            }
        }
    }
}