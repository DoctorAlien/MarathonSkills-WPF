   M S B A M L   `   `   `  ����C  ?Marathon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MarathonMarathon  5          Marathon.Login   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &sjjclr-namespace:Marathon     5       
  Master#��[  6*     N� Title$  Login��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��28* �6   �� 5      $	��47* �6    � RowDefinitions 5   
   �� 5      $	��50* �6   �� 5      $
��150* �6   .+�5   
   �� $��Center=�6   $
��Wrap=�61   $��	LoginForm��6E   $	��Top=�6V   $��20,10,244,0q�6n   $��22(�6�   $
��Bold"�6�   $��1��6�   �� 5   
   $��Center=�6   $
��Wrap=�61   $I��CPlease log in to the system using your email adddress and password.��6E   $	��Top=�6�   $��0,60,0,0q�6�   $��2��6�   $	��424��6�   $��14(�6�   �� 5   
   $��Right=�6   $
��Wrap=�60   $��Email:��6D   $	��Top=�6R   $��0,5,10,0q�6j   $��1��6|   $��14(�6�   �� 5   
   $��Right=�6   $
��Wrap=�60   $��	Password:��6D   $	��Top=�6U   $��0,56,9,0q�6m   $��1��6   $��14(�6�   �� 5   
   -   5         ��Name$ txtEmail��5      $
��Left=�6$   $��23��6?    �� TextWrapping$
 Wrap=�6K   $	��Top=�6_   $	��278��6w   $��1��6�   $��10,1,0,0q�6�   $��1��6�     placeholder#��[ 6�   
 � Tag$ Enter your email address��6�   �� 5   
   -   5        $ txtPassword��5      $
��Left=�6'   $��23��6B   $
 Wrap=�6N   $	��Top=�6b   $	��278��6z   $��1��6�   $��	10,52,0,0q�6�   $��1��6�   #��[ 6�   $ Enter your password��6�   �� 5   
   -   5         ��Name$ btnLogin��5      $��Login��6#   $
��Left=�63   $	��Top=�6N   $��75��6f   $��1��6q   $��
10,110,0,0q�6�   $��1��6�   $��35��6�   6�   �� 5   
   $��Cancel��6   $
��Left=�6"   $	��Top=�6=   $��75��6U   $��1��6`   $��110,110,0,0q�6p   $��1��6�   $��35��6�   5      5      