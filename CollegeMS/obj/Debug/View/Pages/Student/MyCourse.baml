   M S B A M L   `   `   `  ����D  @CollegeMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:CollegeMS.View.Pages.StudentCollegeMS.View.Pages.Student  5      I)clr-namespace:CollegeMS.View.UserControlsCollegeMS.View.UserControls  5
      +    %CollegeMS.View.Pages.Student.MyCourse   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:CollegeMS.View.Pages.Student     5      BuserControls)clr-namespace:CollegeMS.View.UserControls     5
        N� Title$  MyCourse��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      .+�5   
   *   $CollegeMS.View.UserControls.TitleBar  � 5   
   $��1��6   .+�5      �� ._�5      �� $��/Assets/regist.png��6   $
��Fill=�64   5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ 
RegistGrid��5   �      SelectionUnit$ FullRow=�6      RowHover   RowStyle# [  61   $
��Left=�6V   $��Center=�6q   $	��500��6�   $	��250��6�      HeadersVisibility$ Column=�6�      CanUserResizeColumns .     AutoGenerateColumns .     CanUserAddRows .  	   CanUserDeleteRows	 .  
   CanUserReorderColumns
 .     CanUserResizeRows .     CanUserSortColumns .  ���#fdf3f1
���   �$
��Bold"�6�  $��	260,0,0,0q�6�  
���   �$��2q�6  ��6�  ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Course��6)     HeaderBG   HeaderStyle# [ 6T      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *Course+6�     5      $ CH��6)   # [ 6L    . $ * 6�    65   �� *CH+6�   4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $ Add/Remove Course��6-   # [ 6�    .  $ * 6�    6H   �� *	AddRemove+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   5       �� 5#      $	��↩��6   $��20(�6!     	triggerrr#��[ 6/   $��39,372,651,15q�6R   5$      5%      5&      