   M S B A M L   `   `   `  ���� H  DHangCards GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:HangCards_GUIHangCards_GUI      HangCards_GUI.CardControl   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     +srcclr-namespace:HangCards_GUI     -     >�Name$  UserControl�� � 	Resources %   HangCards_GUI.RankNameConverter   rankConverter  SuitTemplate �� 
TargetType  	SuitImage �� Triggers �� Binding �� ElementName �� Path �� Value �� Property	 �� Value��%�  &	        &	      &	        �� .R��� ���� �� " �� ��  �� $ UserControl��$
 Suit� Club.a���  � ��$	 Images\Clubs.png����  �� $ UserControl��$
 Suit�	 Heart.a���  � ��$	 Images\Hearts.png����  �� $ UserControl��$
 Suit� Diamond.a���  � ��$	 Images\Diamonds.png����  �� $ UserControl��$
 Suit�	 Spade.a���  � ��$	 Images\Spades.png��.��� .+��� 
 �� RadiusX$

 12.5�� �� RadiusY$
 12.5����Z� ����  �� EndPoint$ 0.47,-0.167&� �� 
StartPoint$ 	0.86,0.92&�.���  � Color$ 	#FFD1C78F�� � Offset$ 0Q�� $ 	#FFFFFFFF��$ 1Q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     	Direction$	 145Q�   
BlurRadius$ 10Q�   ShadowDepth$ 0Q��� -    ��Name$ 	SuitLabel��#���  $��Center=�$��Center=�$��	8,51,8,60q����� $
 Suit�$ UserControl�� �� Mode$ Default=��� -   $ 	RankLabel�� K� ZIndex$ 1��#���  $
��Left=�$	��Top=�$��8,8,0,0q����� $
 Rank�$ UserControl��$ Default=� �� 	Converter# [  �� -   $ RankLabelInverted��#���  $��Right=�$��Bottom=�$��0,0,8,8q� J� RenderTransformOrigin$ 0.5,0.5&����� $
 Rank�$ UserControl��$ Default=�# [  z���  �� Angle$	 180Q��� -   $��TopRightImage��#��[ $��	12,12,8,0q�$��Right=�$	��Top=�$
��18.5��$
��18.5��$��UniformToFill=��� -   $��BottomLeftImage��#��[ $��	12,0,8,12q�$
��Left=�$��Bottom=�$
��18.5��$
��18.5��$��UniformToFill=�$ 0.5,0.5&�z��� $	 180Q�F� ���	#FFFFFFFF �� Stretch$
 Fill=�$��0,0,35.218,-0.077q��������2
�	��2
�H'�Ӓ�s�nQf�L�`@@��ӾT����
�	n�֤	���Ѡ� ��Ә�, ���\��\��\��-р\����Ӏ\�ח_��,�2
���2
��Z�  J� OpacityMask �� $ 0.957,1.127&�$ 0,-0.06&�.��� $ 	#FF000000��$ 0Q�� $ 	#00FFFFFF��$ 1Q�