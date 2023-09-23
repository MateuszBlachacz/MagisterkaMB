//D:\mgr\Project\MagisterkaMB\MagisterkaMB\It_testArmor.d
const int VALUE_ITAR_Governor	= 1100;
const int VALUE_ITAR_Judge		= 0;
const int VALUE_ITAR_Smith		= 0;
const int VALUE_ITAR_Barkeeper	= 0;
const int VALUE_ITAR_Vlk_L		= 120;
const int VALUE_ITAR_Vlk_M		= 120;
const int VALUE_ITAR_Vlk_H		= 120;
const int VALUE_ITAR_VlkBabe_L	= 0;
const int VALUE_ITAR_VlkBabe_M	= 0;
const int VALUE_ITAR_VlkBabe_H	= 0;
const int VALUE_ITAR_MIL_L		= 600;
const int VALUE_ITAR_MIL_M		= 2500;
const int VALUE_ITAR_PAL_M		= 5000;
const int VALUE_ITAR_PAL_H		= 20000;

// ------ Bauern und Söldner ------
const int VALUE_ITAR_Bau_L		= 80;
const int VALUE_ITAR_Bau_M		= 100;
const int VALUE_ITAR_BauBabe_L	= 0;
const int VALUE_ITAR_BauBabe_M	= 0;
const int VALUE_ITAR_SLD_L		= 500;
const int VALUE_ITAR_SLD_M		= 1000;
const int VALUE_ITAR_DJG_Crawler= 1500;
const int VALUE_ITAR_SLD_H		= 2500;

// ------ Kloster ------
const int VALUE_ITAR_NOV_L		= 280;
const int VALUE_ITAR_KDF_L		= 500;
const int VALUE_ITAR_KDF_H		= 3000;

// ------ Banditen ------
const int VALUE_ITAR_Leather_L	= 250;
const int VALUE_ITAR_BDT_M		= 550;
const int VALUE_ITAR_BDT_H		= 2100;

// ------ Drachenjäger ------
const int VALUE_ITAR_DJG_L		= 3000;
const int VALUE_ITAR_DJG_M		= 12000;
const int VALUE_ITAR_DJG_H		= 20000;
const int VALUE_ITAR_DJG_Babe	= 0;

// ------ Besondere ------
const int VALUE_ITAR_XARDAS		= 15000;
const int VALUE_ITAR_LESTER		= 300;
const int VALUE_ITAR_DIEGO		= 450;
const int VALUE_ITAR_CorAngar	= 600;
const int VALUE_ITAR_Dementor	= 500;
const int VALUE_ITAR_KDW_H		= 450;
const int VALUE_ITAR_Prisoner	= 10;


// ******************
// 		Rüstungen
// ******************
INSTANCE ITAR_Governor (C_Item)
{
	name 					=	"Kaftan gubernatora";

	mainflag 				=	ITEM_KAT_ARMOR;
	flags 					=	0;

	protection [PROT_EDGE]	=	40;
	protection [PROT_BLUNT]	= 	40;
	protection [PROT_POINT] = 	40;
	protection [PROT_FIRE] 	= 	0;
	protection [PROT_MAGIC] = 	0;

	value 					=	VALUE_ITAR_Governor;

	wear 					=	WEAR_TORSO;

	visual 					=	"ItAr_Governor.3ds";
	visual_change 			=	"Armor_Governor.asc";
	visual_skin 			=	0;
	material 				=	MAT_LEATHER;

	description				=	name;
	
	TEXT[1]					=	NAME_Prot_Edge;			
	COUNT[1]				= 	protection	[PROT_EDGE];
	
	TEXT[2]					=	NAME_Prot_Point;		
	COUNT[2]				= 	protection	[PROT_POINT];
	
	TEXT[3] 				=	NAME_Prot_Fire;			
	COUNT[3]				= 	protection	[PROT_FIRE];
	
	TEXT[4]					=	NAME_Prot_Magic;		
	COUNT[4]				= 	protection	[PROT_MAGIC];
	
	TEXT[5]					=	NAME_Value;			
	COUNT[5]				= 	value;
};
// ******************************************************
INSTANCE ITAR_JUDGE (C_Item)
{
	name 					=	"Szata sędziego";

	mainflag 				=	ITEM_KAT_ARMOR;
	flags 					=	0;

	protection [PROT_EDGE]	=	10;
	protection [PROT_BLUNT] = 	10;
	protection [PROT_POINT] = 	10;
	protection [PROT_FIRE] 	= 	0;
	protection [PROT_MAGIC] = 	0;

	value 					=	VALUE_ITAR_JUDGE;

	wear 					=	WEAR_TORSO;

	visual 					=	"ItAr_Governor.3DS";
	visual_change 			=	"Armor_Judge.asc";
	visual_skin 			=	0;
	material 				=	MAT_LEATHER;

	description				=	name;

	TEXT[1]					=	NAME_Prot_Edge;			
	COUNT[1]				= 	protection	[PROT_EDGE];
	
	TEXT[2]					=	NAME_Prot_Point;		
	COUNT[2]				= 	protection	[PROT_POINT];
	
	TEXT[3] 				=	NAME_Prot_Fire;			
	COUNT[3]				= 	protection	[PROT_FIRE];
	
	TEXT[4]					=	NAME_Prot_Magic;		
	COUNT[4]				= 	protection	[PROT_MAGIC];
	
	TEXT[5]					=	NAME_Value;			
	COUNT[5]				= 	value;
};