   M S B A M L   `   `   `  ����C  ?Marathon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MarathonMarathon  5          Marathon.RunnerRegister   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &sjjclr-namespace:Marathon     5       
  Master#��[  6*     N� Title$  RunnerRegister��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��50* �6   �� 5      $
��150* �6   .+�5   
   �� $��Center=�6   $
��Wrap=�61   $��Register as a runner��6E   $	��Top=�6a   $��0,10,0,0q�6y   $
��Bold"�6�   $��22(�6�   �� 5   
   $��Center=�6   $
��Wrap=�61   $S��MPlease fill out all of the following information to be registered as a runner��6E   $	��Top=�6�   $��0,70,0,0q�6�   $��16(�6�   �� 5   
   $
��Left=�6   $
��Wrap=�6/   $��Email:��6C   $	��Top=�6Q   $��
116,35,0,0q�6i   $��1��6}   �� 5   
   $
��Left=�6   $
��Wrap=�6/   $��	Password:��6C   $	��Top=�6T   $��	94,70,0,0q�6l   $��1��6   �� 5   
   $
��Left=�6   $
��Wrap=�6/   $��Password Again:��6C   $	��Top=�6Z   $��
60,105,0,0q�6r   $��1��6�   �� 5   
   $
��Left=�6   $
��Wrap=�6/   $��First Name:��6C   $	��Top=�6V   $��
87,148,0,0q�6n   $��1��6�   �� 5   
   $
��Left=�6   $
��Wrap=�6/   $��
Last Name:��6C   $	��Top=�6U   $��
88,195,0,0q�6m   $��1��6�   �� 5   
   $
��Left=�6   $
��Wrap=�6/   $��Gender:��6C   $	��Top=�6R   $��
372,38,0,0q�6j   $��1��6~   �� 5   
   $
��Left=�6   $
��Wrap=�6/   $��Date of Birth:��6C   $	��Top=�6Y   $��
344,73,0,0q�6q   $��1��6�   �� 5   
   $
��Left=�6   $
��Wrap=�6/   $��Country:��6C   $	��Top=�6S   $��369,105,0,0q�6k   $��1��6�   �� 5   
   -   5         ��Name$ txtEmail��5      $
��Left=�6$   $��23��6?    �� TextWrapping$
 Wrap=�6K   $	��Top=�6_   $	��157��6w   $��
167,34,0,0q�6�   $��1��6�     placeholder#��[ 6�   
 � Tag$ Email address��6�   �� 5   
   -   5        $ txtPassword��5      $
��Left=�6'   $��23��6B   $
 Wrap=�6N   $	��Top=�6b   $	��157��6z   $��
167,69,0,0q�6�   $��1��6�   #��[ 6�   $ Password��6�   �� 5   
   $
��Left=�6   $��23��6-   $
 Wrap=�69   $	��Top=�6M   $	��157��6e   $��167,104,0,0q�6q   $��1��6�   #��[ 6�   $ Re-enter password��6�   �� 5   
   -   5        $ txtFirstName��5      $
��Left=�6(   $��23��6C   $
 Wrap=�6O   $	��Top=�6c   $	��157��6{   $��167,147,0,0q�6�   $��1��6�   #��[ 6�   $ 
First name��6�   �� 5   
   -   5        $ txtLastName��5      $
��Left=�6'   $��23��6B   $
 Wrap=�6N   $	��Top=�6b   $	��157��6z   $��167,194,0,0q�6�   $��1��6�   #��[ 6�   $ 	Last name��6�   �� 5   
   -   5         ��Name$ 	cmbGender��5      $
��Left=�6&   $	��Top=�6A   $	��157��6Y   $��
434,34,0,0q�6e   $��1��6y   �� 5    
   -   5        $ 
cmbCountry��5       $
��Left=�6'   $	��Top=�6B   $	��157��6Z   $��434,104,0,0q�6f   $��1��6{   �� 5!   
   -   5         ��Name$ btnRegister��5!      $��Register��6&   $
��Left=�69   $	��Top=�6T   $��75��6l   $��249,268,0,0q�6w   $��1��6�   6�   �� 5"   
   $��Cancel��6   $
��Left=�6"   $	��Top=�6=   $��76��6U   $��360,268,0,0q�6`   $��1��6u   (  "System.Windows.Controls.DatePicker  5#   
   -   5          Name$ dpBirth��5#      $
��Left=�6&   $	��Top=�6A   $��434,68.4,0,0q�6Y   $��1��6o   $	��157��6|   5%      5&      