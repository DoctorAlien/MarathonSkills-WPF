   M S B A M L   `   `   `  ����C  ?Marathon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MarathonMarathon  5          Marathon.EventRegister   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &sjjclr-namespace:Marathon     5         Marathon.Master    Loaded$  Master_Loaded��5	       
  Master#��[  5   *    N� Title$ EventRegister��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��58* �6   �� 5      $	��53* �6    � RowDefinitions 5   
   �� 5      $
��114* �6   �� 5      $
��148* �6   �� 5      $
��193* �6   .+�5   
   �� $��Center=�6   $
��Wrap=�61   $��Register for an event��6E   $	��Top=�6b   $��0,10,0,0q�6z   $
��Bold"�6�   $��22(�6�   $��2��6�   $	��226��6�   �� 5   
   $
��Left=�6   $
��Wrap=�6/   $����Please fill out all folowing information to register for events in the Skills Marathon 2016 being held in Sao Paulo,Brazil.You will be contacted after you have registered to organise payment and other details��6C   $	��Top=�6  $��	10,58,0,0q�63  $��2��6F  �� 5   
   $��Center=�6   $
��Wrap=�61   $��Competition events��6E   $	��Top=�6_   $��0,10,0,0q�6w   $��1��6�   $��18(�6�   $
��Bold"�6�   $	��179��6�   �� 5   
   $��Center=�6   $
��Wrap=�61   $��Race kit options��6E   $	��Top=�6]   $��0,10,0,0q�6u   $��1��6�   $��18(�6�   $
��Bold"�6�   $��1��6�   $	��148��6�   �� 5   
   -   5         ��Name$ cbFullMarathon��5      $��42km Full marathon($145)��6+   $
��Left=�6N   $	��Top=�6i   $��	76,61,0,0q�6�   $��1��6�   
 � Tag$	 145��6�   6�   �� 5   
   -   5        $ cbHalfMarathon��5      $��21km Half marathon($75)��6+   $
��Left=�6M   $	��Top=�6h   $��	76,81,0,0q�6�   $��1��6�   $ 75��6�   6�   �� 5   
   -   5        $ cbFunRun��5      $��5km Fun run($20)��6%   $
��Left=�6@   $	��Top=�6[   $��
76,101,0,0q�6s   $��1��6�   $ 20��6�   6�   �� 5   
   $��Center=�6   $
��Wrap=�61   $��Sponsorship details��6E   $	��Top=�6`   $��0,10,0,0q�6x   $��2��6�   $��18(�6�   $
��Bold"�6�   $	��203��6�   �� 5   
   $��Center=�6   $
��Wrap=�61   $��Registration cost��6E   $	��Top=�6^   $��
77,10,75,0q�6v   $��2��6�   $��18(�6�   $
��Bold"�6�   $��1��6�   �� 5   
   $
��Left=�6   $
��Wrap=�6/   $��Charity:��6C   $	��Top=�6S   $��	58,54,0,0q�6k   $��2��6~   �� 5   
   $
��Left=�6   $
��Wrap=�6/   $��Target to raise:��6C   $	��Top=�6[   $��	19,91,0,0q�6s   $��2��6�   �� 5    
   $
��Left=�6   $��23��6-    �� TextWrapping$
 Wrap=�69   $	��Top=�6M   $	��165��6e   $��
115,53,0,0q�6q   $��2��6�     placeholder#��[ 6�   $ Save The Cats Fund��6�   �� 5!   
   $
��Left=�6   $��23��6-   $
 Wrap=�69   $	��Top=�6M   $	��165��6e   $��
115,90,0,0q�6q   $��2��6�   #��[ 6�   $
 $500��6�   �� 5"   
   $��Register��6   $
��Left=�6$   $	��Top=�6?   $��75��6W   $��
58,141,0,0q�6b   $��2��6v   �� 5#   
   $��Cancel��6   $
��Left=�6"   $	��Top=�6=   $��75��6U   $��160,141,0,0q�6`   $��2��6u   �� 5$   
   -   5         ��Name$ tbTotal��5$      $��Center=�6%   $
��Wrap=�6B   $	��Top=�6w   $��1��6�   $��0,53,0,0q�6�   $��2��6�   $��72(�6�   $
��Bold"�6�   ��6V   �� *sum+ �� Mode$ OneWay=�6�   �� 5%   
   -   5        	 ��Name$	 btnModal��5%      $��i��6#   $
��Left=�6/   $	��Top=�6J   $��21��6b   $��
295,53,0,0q�6m   $��2��6�   6�   �� 5&   
   -   5        
 ��Name$
 lbxRaceKitOption��5&      $
��Left=�6,   $	��100��6G   $	��Top=�6T   $	��250��6l   $��1��6x   $��	10,39,0,0q�6�   $��1��6�   $��Disabled=�6�   ��5'      �� 5(      .R�5+      	� -   5        $
��Left=�5+   &   $	��Top=�6A    	� 	GroupName$ raceKitOptions��6Y    6�   �� *Cost+ �� StringFormat$ 0��.��5,      �� $��Option��6(   $
��Bold"�66   �� 5-      $
��Bold"�6I   $	��150��6[   ��6(   �� *RaceKitOptionId+�� 5.   "   $��(��6,   67    �� 5/   "   $��$��6,   67    �� 50   "   ��6,   �� *Cost+$ 0��6S    �� 51   "   $��):��6,   68    �� 52   "   $��Normal"�6K   $
��Wrap=�6_   ��6,   �� *RaceKitOption+6u   54      55      56      5:      5<      5?      5@      