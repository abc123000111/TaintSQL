// $ANTLR 3.0.1 MacroScope\\MacroScope.g 2008-01-12 20:02:55
namespace 
	MacroScope

{

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;


public class MacroScopeLexer : Lexer 
{
    public const int CAST = 62;
    public const int STAR = 40;
    public const int MOD = 76;
    public const int GREATERTHANOREQUALTO1 = 81;
    public const int DOT_STAR = 50;
    public const int CASE = 57;
    public const int DAY = 86;
    public const int NOT = 30;
    public const int ASSIGNEQUAL = 14;
    public const int EOF = -1;
    public const int MONTH = 85;
    public const int RPAREN = 7;
    public const int FULL = 44;
    public const int Variable = 52;
    public const int ESCAPE = 34;
    public const int INSERT = 4;
    public const int NonQuotedIdentifier = 56;
    public const int SELECT = 16;
    public const int INTO = 5;
    public const int DIVIDE = 75;
    public const int PLACEHOLDER = 51;
    public const int GREATERTHAN = 82;
    public const int SECOND = 89;
    public const int ASC = 24;
    public const int UnicodeStringLiteral = 64;
    public const int NULL = 32;
    public const int ELSE = 60;
    public const int ON = 48;
    public const int DELETE = 11;
    public const int GROUP = 26;
    public const int MAccessDateTime = 69;
    public const int OR = 28;
    public const int LESSTHANOREQUALTO1 = 79;
    public const int END = 61;
    public const int FROM = 12;
    public const int DISTINCT = 18;
    public const int Letter = 90;
    public const int WHERE = 21;
    public const int UnicodeStringRun = 96;
    public const int INNER = 41;
    public const int YEAR = 84;
    public const int ORDER = 22;
    public const int UPDATE = 9;
    public const int AsciiStringLiteral = 65;
    public const int Exponent = 92;
    public const int FOR = 54;
    public const int AND = 29;
    public const int CROSS = 47;
    public const int INTERVAL = 71;
    public const int LPAREN = 6;
    public const int AS = 49;
    public const int IN = 36;
    public const int THEN = 59;
    public const int Number = 93;
    public const int COMMA = 13;
    public const int IS = 31;
    public const int LEFT = 42;
    public const int SOME = 38;
    public const int ALL = 17;
    public const int Real = 67;
    public const int PLUS = 72;
    public const int EXISTS = 37;
    public const int EXTRACT = 55;
    public const int DOT = 63;
    public const int Whitespace = 98;
    public const int LIKE = 33;
    public const int OUTER = 45;
    public const int HexLiteral = 68;
    public const int BY = 23;
    public const int LESSTHAN = 80;
    public const int AsciiStringRun = 95;
    public const int DEFAULT = 15;
    public const int VALUES = 8;
    public const int RIGHT = 43;
    public const int SET = 10;
    public const int HAVING = 27;
    public const int MINUS = 73;
    public const int HOUR = 87;
    public const int Digit = 91;
    public const int Tokens = 99;
    public const int QuotedIdentifier = 66;
    public const int WordTail = 94;
    public const int JOIN = 46;
    public const int UNION = 83;
    public const int SUBSTRING = 53;
    public const int COLON = 97;
    public const int STRCONCAT = 74;
    public const int ANY = 39;
    public const int WHEN = 58;
    public const int NOTEQUAL1 = 77;
    public const int NOTEQUAL2 = 78;
    public const int DESC = 25;
    public const int MINUTE = 88;
    public const int TOP = 19;
    public const int BETWEEN = 35;
    public const int Integer = 20;
    public const int Iso8601DateTime = 70;
    
    	public override void ReportError(RecognitionException e)
    	{
    	}


    public MacroScopeLexer() 
    {
		InitializeCyclicDFAs();
    }
    public MacroScopeLexer(ICharStream input) 
		: base(input)
	{
		InitializeCyclicDFAs();
        ruleMemo = new IDictionary[97+1];
     }
    
    override public string GrammarFileName
    {
    	get { return "MacroScope\\MacroScope.g";} 
    }

    // $ANTLR start ALL 
    public void mALL() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = ALL;
            // MacroScope\\MacroScope.g:801:5: ( 'all' )
            // MacroScope\\MacroScope.g:801:7: 'all'
            {
            	Match("all"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end ALL

    // $ANTLR start AND 
    public void mAND() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = AND;
            // MacroScope\\MacroScope.g:802:5: ( 'and' )
            // MacroScope\\MacroScope.g:802:7: 'and'
            {
            	Match("and"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end AND

    // $ANTLR start ANY 
    public void mANY() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = ANY;
            // MacroScope\\MacroScope.g:803:5: ( 'any' )
            // MacroScope\\MacroScope.g:803:7: 'any'
            {
            	Match("any"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end ANY

    // $ANTLR start AS 
    public void mAS() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = AS;
            // MacroScope\\MacroScope.g:804:4: ( 'as' )
            // MacroScope\\MacroScope.g:804:6: 'as'
            {
            	Match("as"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end AS

    // $ANTLR start ASC 
    public void mASC() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = ASC;
            // MacroScope\\MacroScope.g:805:5: ( 'asc' )
            // MacroScope\\MacroScope.g:805:7: 'asc'
            {
            	Match("asc"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end ASC

    // $ANTLR start BETWEEN 
    public void mBETWEEN() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = BETWEEN;
            // MacroScope\\MacroScope.g:806:9: ( 'between' )
            // MacroScope\\MacroScope.g:806:11: 'between'
            {
            	Match("between"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end BETWEEN

    // $ANTLR start BY 
    public void mBY() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = BY;
            // MacroScope\\MacroScope.g:807:4: ( 'by' )
            // MacroScope\\MacroScope.g:807:6: 'by'
            {
            	Match("by"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end BY

    // $ANTLR start CASE 
    public void mCASE() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = CASE;
            // MacroScope\\MacroScope.g:808:6: ( 'case' )
            // MacroScope\\MacroScope.g:808:8: 'case'
            {
            	Match("case"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end CASE

    // $ANTLR start CAST 
    public void mCAST() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = CAST;
            // MacroScope\\MacroScope.g:809:6: ( 'cast' )
            // MacroScope\\MacroScope.g:809:8: 'cast'
            {
            	Match("cast"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end CAST

    // $ANTLR start CROSS 
    public void mCROSS() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = CROSS;
            // MacroScope\\MacroScope.g:810:7: ( 'cross' )
            // MacroScope\\MacroScope.g:810:9: 'cross'
            {
            	Match("cross"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end CROSS

    // $ANTLR start DAY 
    public void mDAY() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = DAY;
            // MacroScope\\MacroScope.g:811:5: ( 'day' )
            // MacroScope\\MacroScope.g:811:7: 'day'
            {
            	Match("day"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end DAY

    // $ANTLR start DEFAULT 
    public void mDEFAULT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = DEFAULT;
            // MacroScope\\MacroScope.g:812:9: ( 'default' )
            // MacroScope\\MacroScope.g:812:11: 'default'
            {
            	Match("default"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end DEFAULT

    // $ANTLR start DELETE 
    public void mDELETE() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = DELETE;
            // MacroScope\\MacroScope.g:813:8: ( 'delete' )
            // MacroScope\\MacroScope.g:813:10: 'delete'
            {
            	Match("delete"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end DELETE

    // $ANTLR start DESC 
    public void mDESC() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = DESC;
            // MacroScope\\MacroScope.g:814:6: ( 'desc' )
            // MacroScope\\MacroScope.g:814:8: 'desc'
            {
            	Match("desc"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end DESC

    // $ANTLR start DISTINCT 
    public void mDISTINCT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = DISTINCT;
            // MacroScope\\MacroScope.g:815:10: ( 'distinct' )
            // MacroScope\\MacroScope.g:815:12: 'distinct'
            {
            	Match("distinct"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end DISTINCT

    // $ANTLR start ELSE 
    public void mELSE() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = ELSE;
            // MacroScope\\MacroScope.g:816:6: ( 'else' )
            // MacroScope\\MacroScope.g:816:8: 'else'
            {
            	Match("else"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end ELSE

    // $ANTLR start END 
    public void mEND() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = END;
            // MacroScope\\MacroScope.g:817:5: ( 'end' )
            // MacroScope\\MacroScope.g:817:7: 'end'
            {
            	Match("end"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end END

    // $ANTLR start ESCAPE 
    public void mESCAPE() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = ESCAPE;
            // MacroScope\\MacroScope.g:818:8: ( 'escape' )
            // MacroScope\\MacroScope.g:818:10: 'escape'
            {
            	Match("escape"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end ESCAPE

    // $ANTLR start EXISTS 
    public void mEXISTS() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = EXISTS;
            // MacroScope\\MacroScope.g:819:8: ( 'exists' )
            // MacroScope\\MacroScope.g:819:10: 'exists'
            {
            	Match("exists"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end EXISTS

    // $ANTLR start EXTRACT 
    public void mEXTRACT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = EXTRACT;
            // MacroScope\\MacroScope.g:820:9: ( 'extract' )
            // MacroScope\\MacroScope.g:820:11: 'extract'
            {
            	Match("extract"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end EXTRACT

    // $ANTLR start FOR 
    public void mFOR() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = FOR;
            // MacroScope\\MacroScope.g:821:5: ( 'for' )
            // MacroScope\\MacroScope.g:821:7: 'for'
            {
            	Match("for"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end FOR

    // $ANTLR start FROM 
    public void mFROM() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = FROM;
            // MacroScope\\MacroScope.g:822:6: ( 'from' )
            // MacroScope\\MacroScope.g:822:8: 'from'
            {
            	Match("from"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end FROM

    // $ANTLR start FULL 
    public void mFULL() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = FULL;
            // MacroScope\\MacroScope.g:823:6: ( 'full' )
            // MacroScope\\MacroScope.g:823:8: 'full'
            {
            	Match("full"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end FULL

    // $ANTLR start GROUP 
    public void mGROUP() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = GROUP;
            // MacroScope\\MacroScope.g:824:7: ( 'group' )
            // MacroScope\\MacroScope.g:824:9: 'group'
            {
            	Match("group"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end GROUP

    // $ANTLR start HAVING 
    public void mHAVING() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = HAVING;
            // MacroScope\\MacroScope.g:825:8: ( 'having' )
            // MacroScope\\MacroScope.g:825:10: 'having'
            {
            	Match("having"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end HAVING

    // $ANTLR start HOUR 
    public void mHOUR() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = HOUR;
            // MacroScope\\MacroScope.g:826:6: ( 'hour' )
            // MacroScope\\MacroScope.g:826:8: 'hour'
            {
            	Match("hour"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end HOUR

    // $ANTLR start IN 
    public void mIN() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = IN;
            // MacroScope\\MacroScope.g:827:4: ( 'in' )
            // MacroScope\\MacroScope.g:827:6: 'in'
            {
            	Match("in"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end IN

    // $ANTLR start INNER 
    public void mINNER() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = INNER;
            // MacroScope\\MacroScope.g:828:7: ( 'inner' )
            // MacroScope\\MacroScope.g:828:9: 'inner'
            {
            	Match("inner"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end INNER

    // $ANTLR start INSERT 
    public void mINSERT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = INSERT;
            // MacroScope\\MacroScope.g:829:8: ( 'insert' )
            // MacroScope\\MacroScope.g:829:10: 'insert'
            {
            	Match("insert"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end INSERT

    // $ANTLR start INTERVAL 
    public void mINTERVAL() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = INTERVAL;
            // MacroScope\\MacroScope.g:830:10: ( 'interval' )
            // MacroScope\\MacroScope.g:830:12: 'interval'
            {
            	Match("interval"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end INTERVAL

    // $ANTLR start INTO 
    public void mINTO() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = INTO;
            // MacroScope\\MacroScope.g:831:6: ( 'into' )
            // MacroScope\\MacroScope.g:831:8: 'into'
            {
            	Match("into"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end INTO

    // $ANTLR start IS 
    public void mIS() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = IS;
            // MacroScope\\MacroScope.g:832:4: ( 'is' )
            // MacroScope\\MacroScope.g:832:6: 'is'
            {
            	Match("is"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end IS

    // $ANTLR start JOIN 
    public void mJOIN() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = JOIN;
            // MacroScope\\MacroScope.g:833:6: ( 'join' )
            // MacroScope\\MacroScope.g:833:8: 'join'
            {
            	Match("join"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end JOIN

    // $ANTLR start LEFT 
    public void mLEFT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = LEFT;
            // MacroScope\\MacroScope.g:834:6: ( 'left' )
            // MacroScope\\MacroScope.g:834:8: 'left'
            {
            	Match("left"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end LEFT

    // $ANTLR start LIKE 
    public void mLIKE() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = LIKE;
            // MacroScope\\MacroScope.g:835:6: ( 'like' )
            // MacroScope\\MacroScope.g:835:8: 'like'
            {
            	Match("like"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end LIKE

    // $ANTLR start MINUTE 
    public void mMINUTE() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = MINUTE;
            // MacroScope\\MacroScope.g:836:8: ( 'minute' )
            // MacroScope\\MacroScope.g:836:10: 'minute'
            {
            	Match("minute"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end MINUTE

    // $ANTLR start MONTH 
    public void mMONTH() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = MONTH;
            // MacroScope\\MacroScope.g:837:7: ( 'month' )
            // MacroScope\\MacroScope.g:837:9: 'month'
            {
            	Match("month"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end MONTH

    // $ANTLR start NOT 
    public void mNOT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = NOT;
            // MacroScope\\MacroScope.g:838:5: ( 'not' )
            // MacroScope\\MacroScope.g:838:7: 'not'
            {
            	Match("not"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end NOT

    // $ANTLR start NULL 
    public void mNULL() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = NULL;
            // MacroScope\\MacroScope.g:839:6: ( 'null' )
            // MacroScope\\MacroScope.g:839:8: 'null'
            {
            	Match("null"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end NULL

    // $ANTLR start ON 
    public void mON() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = ON;
            // MacroScope\\MacroScope.g:840:4: ( 'on' )
            // MacroScope\\MacroScope.g:840:6: 'on'
            {
            	Match("on"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end ON

    // $ANTLR start OR 
    public void mOR() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = OR;
            // MacroScope\\MacroScope.g:841:4: ( 'or' )
            // MacroScope\\MacroScope.g:841:6: 'or'
            {
            	Match("or"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end OR

    // $ANTLR start ORDER 
    public void mORDER() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = ORDER;
            // MacroScope\\MacroScope.g:842:7: ( 'order' )
            // MacroScope\\MacroScope.g:842:9: 'order'
            {
            	Match("order"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end ORDER

    // $ANTLR start OUTER 
    public void mOUTER() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = OUTER;
            // MacroScope\\MacroScope.g:843:7: ( 'outer' )
            // MacroScope\\MacroScope.g:843:9: 'outer'
            {
            	Match("outer"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end OUTER

    // $ANTLR start RIGHT 
    public void mRIGHT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = RIGHT;
            // MacroScope\\MacroScope.g:844:7: ( 'right' )
            // MacroScope\\MacroScope.g:844:9: 'right'
            {
            	Match("right"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end RIGHT

    // $ANTLR start SECOND 
    public void mSECOND() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = SECOND;
            // MacroScope\\MacroScope.g:845:8: ( 'second' )
            // MacroScope\\MacroScope.g:845:10: 'second'
            {
            	Match("second"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end SECOND

    // $ANTLR start SELECT 
    public void mSELECT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = SELECT;
            // MacroScope\\MacroScope.g:846:8: ( 'select' )
            // MacroScope\\MacroScope.g:846:10: 'select'
            {
            	Match("select"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end SELECT

    // $ANTLR start SET 
    public void mSET() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = SET;
            // MacroScope\\MacroScope.g:847:5: ( 'set' )
            // MacroScope\\MacroScope.g:847:7: 'set'
            {
            	Match("set"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end SET

    // $ANTLR start SOME 
    public void mSOME() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = SOME;
            // MacroScope\\MacroScope.g:848:6: ( 'some' )
            // MacroScope\\MacroScope.g:848:8: 'some'
            {
            	Match("some"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end SOME

    // $ANTLR start SUBSTRING 
    public void mSUBSTRING() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = SUBSTRING;
            // MacroScope\\MacroScope.g:849:11: ( 'substring' )
            // MacroScope\\MacroScope.g:849:13: 'substring'
            {
            	Match("substring"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end SUBSTRING

    // $ANTLR start THEN 
    public void mTHEN() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = THEN;
            // MacroScope\\MacroScope.g:850:6: ( 'then' )
            // MacroScope\\MacroScope.g:850:8: 'then'
            {
            	Match("then"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end THEN

    // $ANTLR start TOP 
    public void mTOP() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = TOP;
            // MacroScope\\MacroScope.g:851:5: ( 'top' )
            // MacroScope\\MacroScope.g:851:7: 'top'
            {
            	Match("top"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end TOP

    // $ANTLR start UNION 
    public void mUNION() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = UNION;
            // MacroScope\\MacroScope.g:852:7: ( 'union' )
            // MacroScope\\MacroScope.g:852:9: 'union'
            {
            	Match("union"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end UNION

    // $ANTLR start UPDATE 
    public void mUPDATE() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = UPDATE;
            // MacroScope\\MacroScope.g:853:8: ( 'update' )
            // MacroScope\\MacroScope.g:853:10: 'update'
            {
            	Match("update"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end UPDATE

    // $ANTLR start VALUES 
    public void mVALUES() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = VALUES;
            // MacroScope\\MacroScope.g:854:8: ( 'values' )
            // MacroScope\\MacroScope.g:854:10: 'values'
            {
            	Match("values"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end VALUES

    // $ANTLR start WHEN 
    public void mWHEN() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = WHEN;
            // MacroScope\\MacroScope.g:855:6: ( 'when' )
            // MacroScope\\MacroScope.g:855:8: 'when'
            {
            	Match("when"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end WHEN

    // $ANTLR start WHERE 
    public void mWHERE() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = WHERE;
            // MacroScope\\MacroScope.g:856:7: ( 'where' )
            // MacroScope\\MacroScope.g:856:9: 'where'
            {
            	Match("where"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end WHERE

    // $ANTLR start YEAR 
    public void mYEAR() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = YEAR;
            // MacroScope\\MacroScope.g:857:6: ( 'year' )
            // MacroScope\\MacroScope.g:857:8: 'year'
            {
            	Match("year"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end YEAR

    // $ANTLR start DOT_STAR 
    public void mDOT_STAR() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = DOT_STAR;
            // MacroScope\\MacroScope.g:859:9: ( '.*' )
            // MacroScope\\MacroScope.g:859:11: '.*'
            {
            	Match(".*"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end DOT_STAR

    // $ANTLR start DOT 
    public void mDOT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = DOT;
            // MacroScope\\MacroScope.g:860:5: ( '.' )
            // MacroScope\\MacroScope.g:860:7: '.'
            {
            	Match('.'); if (failed) return ;
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end DOT

    // $ANTLR start COMMA 
    public void mCOMMA() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = COMMA;
            // MacroScope\\MacroScope.g:861:7: ( ',' )
            // MacroScope\\MacroScope.g:861:9: ','
            {
            	Match(','); if (failed) return ;
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end COMMA

    // $ANTLR start LPAREN 
    public void mLPAREN() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = LPAREN;
            // MacroScope\\MacroScope.g:862:8: ( '(' )
            // MacroScope\\MacroScope.g:862:10: '('
            {
            	Match('('); if (failed) return ;
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end LPAREN

    // $ANTLR start RPAREN 
    public void mRPAREN() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = RPAREN;
            // MacroScope\\MacroScope.g:863:8: ( ')' )
            // MacroScope\\MacroScope.g:863:10: ')'
            {
            	Match(')'); if (failed) return ;
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end RPAREN

    // $ANTLR start ASSIGNEQUAL 
    public void mASSIGNEQUAL() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = ASSIGNEQUAL;
            // MacroScope\\MacroScope.g:865:13: ( '=' )
            // MacroScope\\MacroScope.g:865:15: '='
            {
            	Match('='); if (failed) return ;
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end ASSIGNEQUAL

    // $ANTLR start NOTEQUAL1 
    public void mNOTEQUAL1() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = NOTEQUAL1;
            // MacroScope\\MacroScope.g:866:11: ( '<>' )
            // MacroScope\\MacroScope.g:866:13: '<>'
            {
            	Match("<>"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end NOTEQUAL1

    // $ANTLR start NOTEQUAL2 
    public void mNOTEQUAL2() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = NOTEQUAL2;
            // MacroScope\\MacroScope.g:867:11: ( '!=' )
            // MacroScope\\MacroScope.g:867:13: '!='
            {
            	Match("!="); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end NOTEQUAL2

    // $ANTLR start LESSTHANOREQUALTO1 
    public void mLESSTHANOREQUALTO1() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = LESSTHANOREQUALTO1;
            // MacroScope\\MacroScope.g:868:20: ( '<=' )
            // MacroScope\\MacroScope.g:868:22: '<='
            {
            	Match("<="); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end LESSTHANOREQUALTO1

    // $ANTLR start LESSTHAN 
    public void mLESSTHAN() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = LESSTHAN;
            // MacroScope\\MacroScope.g:869:10: ( '<' )
            // MacroScope\\MacroScope.g:869:12: '<'
            {
            	Match('<'); if (failed) return ;
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end LESSTHAN

    // $ANTLR start GREATERTHANOREQUALTO1 
    public void mGREATERTHANOREQUALTO1() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = GREATERTHANOREQUALTO1;
            // MacroScope\\MacroScope.g:870:23: ( '>=' )
            // MacroScope\\MacroScope.g:870:25: '>='
            {
            	Match(">="); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end GREATERTHANOREQUALTO1

    // $ANTLR start GREATERTHAN 
    public void mGREATERTHAN() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = GREATERTHAN;
            // MacroScope\\MacroScope.g:871:13: ( '>' )
            // MacroScope\\MacroScope.g:871:15: '>'
            {
            	Match('>'); if (failed) return ;
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end GREATERTHAN

    // $ANTLR start DIVIDE 
    public void mDIVIDE() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = DIVIDE;
            // MacroScope\\MacroScope.g:873:8: ( '/' )
            // MacroScope\\MacroScope.g:873:10: '/'
            {
            	Match('/'); if (failed) return ;
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end DIVIDE

    // $ANTLR start PLUS 
    public void mPLUS() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = PLUS;
            // MacroScope\\MacroScope.g:874:6: ( '+' )
            // MacroScope\\MacroScope.g:874:8: '+'
            {
            	Match('+'); if (failed) return ;
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end PLUS

    // $ANTLR start STAR 
    public void mSTAR() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = STAR;
            // MacroScope\\MacroScope.g:875:6: ( '*' )
            // MacroScope\\MacroScope.g:875:8: '*'
            {
            	Match('*'); if (failed) return ;
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end STAR

    // $ANTLR start MOD 
    public void mMOD() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = MOD;
            // MacroScope\\MacroScope.g:876:5: ( '%' )
            // MacroScope\\MacroScope.g:876:7: '%'
            {
            	Match('%'); if (failed) return ;
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end MOD

    // $ANTLR start STRCONCAT 
    public void mSTRCONCAT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = STRCONCAT;
            // MacroScope\\MacroScope.g:878:11: ( '||' )
            // MacroScope\\MacroScope.g:878:13: '||'
            {
            	Match("||"); if (failed) return ;

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end STRCONCAT

    // $ANTLR start PLACEHOLDER 
    public void mPLACEHOLDER() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = PLACEHOLDER;
            // MacroScope\\MacroScope.g:880:12: ( '?' )
            // MacroScope\\MacroScope.g:880:14: '?'
            {
            	Match('?'); if (failed) return ;
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end PLACEHOLDER

    // $ANTLR start Letter 
    public void mLetter() // throws RecognitionException [2]
    {
        try 
    	{
            // MacroScope\\MacroScope.g:883:8: ( 'a' .. 'z' )
            // MacroScope\\MacroScope.g:883:10: 'a' .. 'z'
            {
            	MatchRange('a','z'); if (failed) return ;
            
            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end Letter

    // $ANTLR start Digit 
    public void mDigit() // throws RecognitionException [2]
    {
        try 
    	{
            // MacroScope\\MacroScope.g:886:7: ( '0' .. '9' )
            // MacroScope\\MacroScope.g:886:9: '0' .. '9'
            {
            	MatchRange('0','9'); if (failed) return ;
            
            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end Digit

    // $ANTLR start Integer 
    public void mInteger() // throws RecognitionException [2]
    {
        try 
    	{
            // MacroScope\\MacroScope.g:889:9: ()
            // MacroScope\\MacroScope.g:889:10: 
            {
            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end Integer

    // $ANTLR start Real 
    public void mReal() // throws RecognitionException [2]
    {
        try 
    	{
            // MacroScope\\MacroScope.g:892:6: ()
            // MacroScope\\MacroScope.g:892:7: 
            {
            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end Real

    // $ANTLR start Exponent 
    public void mExponent() // throws RecognitionException [2]
    {
        try 
    	{
            // MacroScope\\MacroScope.g:895:10: ( 'e' ( '+' | '-' )? ( Digit )+ )
            // MacroScope\\MacroScope.g:896:2: 'e' ( '+' | '-' )? ( Digit )+
            {
            	Match('e'); if (failed) return ;
            	// MacroScope\\MacroScope.g:896:6: ( '+' | '-' )?
            	int alt1 = 2;
            	int LA1_0 = input.LA(1);
            	
            	if ( (LA1_0 == '+' || LA1_0 == '-') )
            	{
            	    alt1 = 1;
            	}
            	switch (alt1) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:
            	        {
            	        	if ( input.LA(1) == '+' || input.LA(1) == '-' ) 
            	        	{
            	        	    input.Consume();
            	        	failed = false;
            	        	}
            	        	else 
            	        	{
            	        	    if ( backtracking > 0 ) {failed = true; return ;}
            	        	    MismatchedSetException mse =
            	        	        new MismatchedSetException(null,input);
            	        	    Recover(mse);    throw mse;
            	        	}

            	        
            	        }
            	        break;
            	
            	}

            	// MacroScope\\MacroScope.g:896:21: ( Digit )+
            	int cnt2 = 0;
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);
            	    
            	    if ( ((LA2_0 >= '0' && LA2_0 <= '9')) )
            	    {
            	        alt2 = 1;
            	    }
            	    
            	
            	    switch (alt2) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:896:22: Digit
            			    {
            			    	mDigit(); if (failed) return ;
            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt2 >= 1 ) goto loop2;
            			    if ( backtracking > 0 ) {failed = true; return ;}
            		            EarlyExitException eee =
            		                new EarlyExitException(2, input);
            		            throw eee;
            	    }
            	    cnt2++;
            	} while (true);
            	
            	loop2:
            		;	// Stops C# compiler whinging that label 'loop2' has no statements

            
            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end Exponent

    // $ANTLR start MAccessDateTime 
    public void mMAccessDateTime() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = MAccessDateTime;
            // MacroScope\\MacroScope.g:899:17: ( '#' Digit Digit Digit Digit '-' Digit Digit '-' Digit Digit ' ' Digit Digit ':' Digit Digit ':' Digit Digit '#' )
            // MacroScope\\MacroScope.g:900:2: '#' Digit Digit Digit Digit '-' Digit Digit '-' Digit Digit ' ' Digit Digit ':' Digit Digit ':' Digit Digit '#'
            {
            	Match('#'); if (failed) return ;
            	mDigit(); if (failed) return ;
            	mDigit(); if (failed) return ;
            	mDigit(); if (failed) return ;
            	mDigit(); if (failed) return ;
            	Match('-'); if (failed) return ;
            	mDigit(); if (failed) return ;
            	mDigit(); if (failed) return ;
            	Match('-'); if (failed) return ;
            	mDigit(); if (failed) return ;
            	mDigit(); if (failed) return ;
            	Match(' '); if (failed) return ;
            	mDigit(); if (failed) return ;
            	mDigit(); if (failed) return ;
            	Match(':'); if (failed) return ;
            	mDigit(); if (failed) return ;
            	mDigit(); if (failed) return ;
            	Match(':'); if (failed) return ;
            	mDigit(); if (failed) return ;
            	mDigit(); if (failed) return ;
            	Match('#'); if (failed) return ;
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end MAccessDateTime

    // $ANTLR start Iso8601DateTime 
    public void mIso8601DateTime() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = Iso8601DateTime;
            // MacroScope\\MacroScope.g:906:17: ( Digit Digit Digit Digit '-' Digit Digit '-' Digit Digit ( 't' | ' ' ) Digit Digit ':' Digit Digit ':' Digit Digit )
            // MacroScope\\MacroScope.g:907:2: Digit Digit Digit Digit '-' Digit Digit '-' Digit Digit ( 't' | ' ' ) Digit Digit ':' Digit Digit ':' Digit Digit
            {
            	mDigit(); if (failed) return ;
            	mDigit(); if (failed) return ;
            	mDigit(); if (failed) return ;
            	mDigit(); if (failed) return ;
            	Match('-'); if (failed) return ;
            	mDigit(); if (failed) return ;
            	mDigit(); if (failed) return ;
            	Match('-'); if (failed) return ;
            	mDigit(); if (failed) return ;
            	mDigit(); if (failed) return ;
            	if ( input.LA(1) == ' ' || input.LA(1) == 't' ) 
            	{
            	    input.Consume();
            	failed = false;
            	}
            	else 
            	{
            	    if ( backtracking > 0 ) {failed = true; return ;}
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
            	    Recover(mse);    throw mse;
            	}

            	mDigit(); if (failed) return ;
            	mDigit(); if (failed) return ;
            	Match(':'); if (failed) return ;
            	mDigit(); if (failed) return ;
            	mDigit(); if (failed) return ;
            	Match(':'); if (failed) return ;
            	mDigit(); if (failed) return ;
            	mDigit(); if (failed) return ;
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end Iso8601DateTime

    // $ANTLR start Number 
    public void mNumber() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = Number;
            // MacroScope\\MacroScope.g:912:8: ( ( ( Digit )+ ( '.' | 'e' ) )=> ( Digit )+ ( '.' ( Digit )* ( Exponent )? | Exponent ) | '.' ( ( Digit )+ ( Exponent )? )? | ( Digit )+ | '0x' ( 'a' .. 'f' | Digit )* )
            int alt12 = 4;
            alt12 = dfa12.Predict(input);
            switch (alt12) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:913:2: ( ( Digit )+ ( '.' | 'e' ) )=> ( Digit )+ ( '.' ( Digit )* ( Exponent )? | Exponent )
                    {
                    	// MacroScope\\MacroScope.g:913:30: ( Digit )+
                    	int cnt3 = 0;
                    	do 
                    	{
                    	    int alt3 = 2;
                    	    int LA3_0 = input.LA(1);
                    	    
                    	    if ( ((LA3_0 >= '0' && LA3_0 <= '9')) )
                    	    {
                    	        alt3 = 1;
                    	    }
                    	    
                    	
                    	    switch (alt3) 
                    		{
                    			case 1 :
                    			    // MacroScope\\MacroScope.g:913:31: Digit
                    			    {
                    			    	mDigit(); if (failed) return ;
                    			    
                    			    }
                    			    break;
                    	
                    			default:
                    			    if ( cnt3 >= 1 ) goto loop3;
                    			    if ( backtracking > 0 ) {failed = true; return ;}
                    		            EarlyExitException eee =
                    		                new EarlyExitException(3, input);
                    		            throw eee;
                    	    }
                    	    cnt3++;
                    	} while (true);
                    	
                    	loop3:
                    		;	// Stops C# compiler whinging that label 'loop3' has no statements

                    	// MacroScope\\MacroScope.g:913:39: ( '.' ( Digit )* ( Exponent )? | Exponent )
                    	int alt6 = 2;
                    	int LA6_0 = input.LA(1);
                    	
                    	if ( (LA6_0 == '.') )
                    	{
                    	    alt6 = 1;
                    	}
                    	else if ( (LA6_0 == 'e') )
                    	{
                    	    alt6 = 2;
                    	}
                    	else 
                    	{
                    	    if ( backtracking > 0 ) {failed = true; return ;}
                    	    NoViableAltException nvae_d6s0 =
                    	        new NoViableAltException("913:39: ( '.' ( Digit )* ( Exponent )? | Exponent )", 6, 0, input);
                    	
                    	    throw nvae_d6s0;
                    	}
                    	switch (alt6) 
                    	{
                    	    case 1 :
                    	        // MacroScope\\MacroScope.g:913:41: '.' ( Digit )* ( Exponent )?
                    	        {
                    	        	Match('.'); if (failed) return ;
                    	        	// MacroScope\\MacroScope.g:913:45: ( Digit )*
                    	        	do 
                    	        	{
                    	        	    int alt4 = 2;
                    	        	    int LA4_0 = input.LA(1);
                    	        	    
                    	        	    if ( ((LA4_0 >= '0' && LA4_0 <= '9')) )
                    	        	    {
                    	        	        alt4 = 1;
                    	        	    }
                    	        	    
                    	        	
                    	        	    switch (alt4) 
                    	        		{
                    	        			case 1 :
                    	        			    // MacroScope\\MacroScope.g:913:46: Digit
                    	        			    {
                    	        			    	mDigit(); if (failed) return ;
                    	        			    
                    	        			    }
                    	        			    break;
                    	        	
                    	        			default:
                    	        			    goto loop4;
                    	        	    }
                    	        	} while (true);
                    	        	
                    	        	loop4:
                    	        		;	// Stops C# compiler whinging that label 'loop4' has no statements

                    	        	// MacroScope\\MacroScope.g:913:54: ( Exponent )?
                    	        	int alt5 = 2;
                    	        	int LA5_0 = input.LA(1);
                    	        	
                    	        	if ( (LA5_0 == 'e') )
                    	        	{
                    	        	    alt5 = 1;
                    	        	}
                    	        	switch (alt5) 
                    	        	{
                    	        	    case 1 :
                    	        	        // MacroScope\\MacroScope.g:913:55: Exponent
                    	        	        {
                    	        	        	mExponent(); if (failed) return ;
                    	        	        
                    	        	        }
                    	        	        break;
                    	        	
                    	        	}

                    	        
                    	        }
                    	        break;
                    	    case 2 :
                    	        // MacroScope\\MacroScope.g:913:68: Exponent
                    	        {
                    	        	mExponent(); if (failed) return ;
                    	        
                    	        }
                    	        break;
                    	
                    	}

                    	if ( backtracking == 0 ) 
                    	{
                    	   _type = Real; 
                    	}
                    
                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:914:4: '.' ( ( Digit )+ ( Exponent )? )?
                    {
                    	Match('.'); if (failed) return ;
                    	if ( backtracking == 0 ) 
                    	{
                    	   _type = DOT; 
                    	}
                    	// MacroScope\\MacroScope.g:914:25: ( ( Digit )+ ( Exponent )? )?
                    	int alt9 = 2;
                    	int LA9_0 = input.LA(1);
                    	
                    	if ( ((LA9_0 >= '0' && LA9_0 <= '9')) )
                    	{
                    	    alt9 = 1;
                    	}
                    	switch (alt9) 
                    	{
                    	    case 1 :
                    	        // MacroScope\\MacroScope.g:914:27: ( Digit )+ ( Exponent )?
                    	        {
                    	        	// MacroScope\\MacroScope.g:914:27: ( Digit )+
                    	        	int cnt7 = 0;
                    	        	do 
                    	        	{
                    	        	    int alt7 = 2;
                    	        	    int LA7_0 = input.LA(1);
                    	        	    
                    	        	    if ( ((LA7_0 >= '0' && LA7_0 <= '9')) )
                    	        	    {
                    	        	        alt7 = 1;
                    	        	    }
                    	        	    
                    	        	
                    	        	    switch (alt7) 
                    	        		{
                    	        			case 1 :
                    	        			    // MacroScope\\MacroScope.g:914:28: Digit
                    	        			    {
                    	        			    	mDigit(); if (failed) return ;
                    	        			    
                    	        			    }
                    	        			    break;
                    	        	
                    	        			default:
                    	        			    if ( cnt7 >= 1 ) goto loop7;
                    	        			    if ( backtracking > 0 ) {failed = true; return ;}
                    	        		            EarlyExitException eee =
                    	        		                new EarlyExitException(7, input);
                    	        		            throw eee;
                    	        	    }
                    	        	    cnt7++;
                    	        	} while (true);
                    	        	
                    	        	loop7:
                    	        		;	// Stops C# compiler whinging that label 'loop7' has no statements

                    	        	// MacroScope\\MacroScope.g:914:36: ( Exponent )?
                    	        	int alt8 = 2;
                    	        	int LA8_0 = input.LA(1);
                    	        	
                    	        	if ( (LA8_0 == 'e') )
                    	        	{
                    	        	    alt8 = 1;
                    	        	}
                    	        	switch (alt8) 
                    	        	{
                    	        	    case 1 :
                    	        	        // MacroScope\\MacroScope.g:914:37: Exponent
                    	        	        {
                    	        	        	mExponent(); if (failed) return ;
                    	        	        
                    	        	        }
                    	        	        break;
                    	        	
                    	        	}

                    	        	if ( backtracking == 0 ) 
                    	        	{
                    	        	   _type = Real; 
                    	        	}
                    	        
                    	        }
                    	        break;
                    	
                    	}

                    
                    }
                    break;
                case 3 :
                    // MacroScope\\MacroScope.g:915:4: ( Digit )+
                    {
                    	// MacroScope\\MacroScope.g:915:4: ( Digit )+
                    	int cnt10 = 0;
                    	do 
                    	{
                    	    int alt10 = 2;
                    	    int LA10_0 = input.LA(1);
                    	    
                    	    if ( ((LA10_0 >= '0' && LA10_0 <= '9')) )
                    	    {
                    	        alt10 = 1;
                    	    }
                    	    
                    	
                    	    switch (alt10) 
                    		{
                    			case 1 :
                    			    // MacroScope\\MacroScope.g:915:5: Digit
                    			    {
                    			    	mDigit(); if (failed) return ;
                    			    
                    			    }
                    			    break;
                    	
                    			default:
                    			    if ( cnt10 >= 1 ) goto loop10;
                    			    if ( backtracking > 0 ) {failed = true; return ;}
                    		            EarlyExitException eee =
                    		                new EarlyExitException(10, input);
                    		            throw eee;
                    	    }
                    	    cnt10++;
                    	} while (true);
                    	
                    	loop10:
                    		;	// Stops C# compiler whinging that label 'loop10' has no statements

                    	if ( backtracking == 0 ) 
                    	{
                    	   _type = Integer; 
                    	}
                    
                    }
                    break;
                case 4 :
                    // MacroScope\\MacroScope.g:916:4: '0x' ( 'a' .. 'f' | Digit )*
                    {
                    	Match("0x"); if (failed) return ;

                    	// MacroScope\\MacroScope.g:916:9: ( 'a' .. 'f' | Digit )*
                    	do 
                    	{
                    	    int alt11 = 2;
                    	    int LA11_0 = input.LA(1);
                    	    
                    	    if ( ((LA11_0 >= '0' && LA11_0 <= '9') || (LA11_0 >= 'a' && LA11_0 <= 'f')) )
                    	    {
                    	        alt11 = 1;
                    	    }
                    	    
                    	
                    	    switch (alt11) 
                    		{
                    			case 1 :
                    			    // MacroScope\\MacroScope.g:
                    			    {
                    			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'a' && input.LA(1) <= 'f') ) 
                    			    	{
                    			    	    input.Consume();
                    			    	failed = false;
                    			    	}
                    			    	else 
                    			    	{
                    			    	    if ( backtracking > 0 ) {failed = true; return ;}
                    			    	    MismatchedSetException mse =
                    			    	        new MismatchedSetException(null,input);
                    			    	    Recover(mse);    throw mse;
                    			    	}

                    			    
                    			    }
                    			    break;
                    	
                    			default:
                    			    goto loop11;
                    	    }
                    	} while (true);
                    	
                    	loop11:
                    		;	// Stops C# compiler whinging that label 'loop11' has no statements

                    	if ( backtracking == 0 ) 
                    	{
                    	   _type = HexLiteral; 
                    	}
                    
                    }
                    break;
            
            }
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end Number

    // $ANTLR start WordTail 
    public void mWordTail() // throws RecognitionException [2]
    {
        try 
    	{
            // MacroScope\\MacroScope.g:920:10: ( ( Letter | Digit | '_' )* )
            // MacroScope\\MacroScope.g:921:2: ( Letter | Digit | '_' )*
            {
            	// MacroScope\\MacroScope.g:921:2: ( Letter | Digit | '_' )*
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);
            	    
            	    if ( ((LA13_0 >= '0' && LA13_0 <= '9') || LA13_0 == '_' || (LA13_0 >= 'a' && LA13_0 <= 'z')) )
            	    {
            	        alt13 = 1;
            	    }
            	    
            	
            	    switch (alt13) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();
            			    	failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( backtracking > 0 ) {failed = true; return ;}
            			    	    MismatchedSetException mse =
            			    	        new MismatchedSetException(null,input);
            			    	    Recover(mse);    throw mse;
            			    	}

            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop13;
            	    }
            	} while (true);
            	
            	loop13:
            		;	// Stops C# compiler whinging that label 'loop13' has no statements

            
            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end WordTail

    // $ANTLR start NonQuotedIdentifier 
    public void mNonQuotedIdentifier() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = NonQuotedIdentifier;
            // MacroScope\\MacroScope.g:924:21: ( Letter WordTail )
            // MacroScope\\MacroScope.g:924:23: Letter WordTail
            {
            	mLetter(); if (failed) return ;
            	mWordTail(); if (failed) return ;
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end NonQuotedIdentifier

    // $ANTLR start QuotedIdentifier 
    public void mQuotedIdentifier() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = QuotedIdentifier;
            // MacroScope\\MacroScope.g:926:18: ( '[' (~ ']' )* ']' ( ']' (~ ']' )* ']' )* | '\"' (~ '\"' )* '\"' ( '\"' (~ '\"' )* '\"' )* | '`' (~ '`' )* '`' )
            int alt21 = 3;
            switch ( input.LA(1) ) 
            {
            case '[':
            	{
                alt21 = 1;
                }
                break;
            case '\"':
            	{
                alt21 = 2;
                }
                break;
            case '`':
            	{
                alt21 = 3;
                }
                break;
            	default:
            	    if ( backtracking > 0 ) {failed = true; return ;}
            	    NoViableAltException nvae_d21s0 =
            	        new NoViableAltException("926:1: QuotedIdentifier : ( '[' (~ ']' )* ']' ( ']' (~ ']' )* ']' )* | '\"' (~ '\"' )* '\"' ( '\"' (~ '\"' )* '\"' )* | '`' (~ '`' )* '`' );", 21, 0, input);
            
            	    throw nvae_d21s0;
            }
            
            switch (alt21) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:927:2: '[' (~ ']' )* ']' ( ']' (~ ']' )* ']' )*
                    {
                    	Match('['); if (failed) return ;
                    	// MacroScope\\MacroScope.g:927:6: (~ ']' )*
                    	do 
                    	{
                    	    int alt14 = 2;
                    	    int LA14_0 = input.LA(1);
                    	    
                    	    if ( ((LA14_0 >= '\u0000' && LA14_0 <= '\\') || (LA14_0 >= '^' && LA14_0 <= '\uFFFE')) )
                    	    {
                    	        alt14 = 1;
                    	    }
                    	    
                    	
                    	    switch (alt14) 
                    		{
                    			case 1 :
                    			    // MacroScope\\MacroScope.g:927:7: ~ ']'
                    			    {
                    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\\') || (input.LA(1) >= '^' && input.LA(1) <= '\uFFFE') ) 
                    			    	{
                    			    	    input.Consume();
                    			    	failed = false;
                    			    	}
                    			    	else 
                    			    	{
                    			    	    if ( backtracking > 0 ) {failed = true; return ;}
                    			    	    MismatchedSetException mse =
                    			    	        new MismatchedSetException(null,input);
                    			    	    Recover(mse);    throw mse;
                    			    	}

                    			    
                    			    }
                    			    break;
                    	
                    			default:
                    			    goto loop14;
                    	    }
                    	} while (true);
                    	
                    	loop14:
                    		;	// Stops C# compiler whinging that label 'loop14' has no statements

                    	Match(']'); if (failed) return ;
                    	// MacroScope\\MacroScope.g:927:18: ( ']' (~ ']' )* ']' )*
                    	do 
                    	{
                    	    int alt16 = 2;
                    	    int LA16_0 = input.LA(1);
                    	    
                    	    if ( (LA16_0 == ']') )
                    	    {
                    	        alt16 = 1;
                    	    }
                    	    
                    	
                    	    switch (alt16) 
                    		{
                    			case 1 :
                    			    // MacroScope\\MacroScope.g:927:19: ']' (~ ']' )* ']'
                    			    {
                    			    	Match(']'); if (failed) return ;
                    			    	// MacroScope\\MacroScope.g:927:23: (~ ']' )*
                    			    	do 
                    			    	{
                    			    	    int alt15 = 2;
                    			    	    int LA15_0 = input.LA(1);
                    			    	    
                    			    	    if ( ((LA15_0 >= '\u0000' && LA15_0 <= '\\') || (LA15_0 >= '^' && LA15_0 <= '\uFFFE')) )
                    			    	    {
                    			    	        alt15 = 1;
                    			    	    }
                    			    	    
                    			    	
                    			    	    switch (alt15) 
                    			    		{
                    			    			case 1 :
                    			    			    // MacroScope\\MacroScope.g:927:24: ~ ']'
                    			    			    {
                    			    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\\') || (input.LA(1) >= '^' && input.LA(1) <= '\uFFFE') ) 
                    			    			    	{
                    			    			    	    input.Consume();
                    			    			    	failed = false;
                    			    			    	}
                    			    			    	else 
                    			    			    	{
                    			    			    	    if ( backtracking > 0 ) {failed = true; return ;}
                    			    			    	    MismatchedSetException mse =
                    			    			    	        new MismatchedSetException(null,input);
                    			    			    	    Recover(mse);    throw mse;
                    			    			    	}

                    			    			    
                    			    			    }
                    			    			    break;
                    			    	
                    			    			default:
                    			    			    goto loop15;
                    			    	    }
                    			    	} while (true);
                    			    	
                    			    	loop15:
                    			    		;	// Stops C# compiler whinging that label 'loop15' has no statements

                    			    	Match(']'); if (failed) return ;
                    			    
                    			    }
                    			    break;
                    	
                    			default:
                    			    goto loop16;
                    	    }
                    	} while (true);
                    	
                    	loop16:
                    		;	// Stops C# compiler whinging that label 'loop16' has no statements

                    
                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:928:4: '\"' (~ '\"' )* '\"' ( '\"' (~ '\"' )* '\"' )*
                    {
                    	Match('\"'); if (failed) return ;
                    	// MacroScope\\MacroScope.g:928:8: (~ '\"' )*
                    	do 
                    	{
                    	    int alt17 = 2;
                    	    int LA17_0 = input.LA(1);
                    	    
                    	    if ( ((LA17_0 >= '\u0000' && LA17_0 <= '!') || (LA17_0 >= '#' && LA17_0 <= '\uFFFE')) )
                    	    {
                    	        alt17 = 1;
                    	    }
                    	    
                    	
                    	    switch (alt17) 
                    		{
                    			case 1 :
                    			    // MacroScope\\MacroScope.g:928:9: ~ '\"'
                    			    {
                    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '\uFFFE') ) 
                    			    	{
                    			    	    input.Consume();
                    			    	failed = false;
                    			    	}
                    			    	else 
                    			    	{
                    			    	    if ( backtracking > 0 ) {failed = true; return ;}
                    			    	    MismatchedSetException mse =
                    			    	        new MismatchedSetException(null,input);
                    			    	    Recover(mse);    throw mse;
                    			    	}

                    			    
                    			    }
                    			    break;
                    	
                    			default:
                    			    goto loop17;
                    	    }
                    	} while (true);
                    	
                    	loop17:
                    		;	// Stops C# compiler whinging that label 'loop17' has no statements

                    	Match('\"'); if (failed) return ;
                    	// MacroScope\\MacroScope.g:928:20: ( '\"' (~ '\"' )* '\"' )*
                    	do 
                    	{
                    	    int alt19 = 2;
                    	    int LA19_0 = input.LA(1);
                    	    
                    	    if ( (LA19_0 == '\"') )
                    	    {
                    	        alt19 = 1;
                    	    }
                    	    
                    	
                    	    switch (alt19) 
                    		{
                    			case 1 :
                    			    // MacroScope\\MacroScope.g:928:21: '\"' (~ '\"' )* '\"'
                    			    {
                    			    	Match('\"'); if (failed) return ;
                    			    	// MacroScope\\MacroScope.g:928:25: (~ '\"' )*
                    			    	do 
                    			    	{
                    			    	    int alt18 = 2;
                    			    	    int LA18_0 = input.LA(1);
                    			    	    
                    			    	    if ( ((LA18_0 >= '\u0000' && LA18_0 <= '!') || (LA18_0 >= '#' && LA18_0 <= '\uFFFE')) )
                    			    	    {
                    			    	        alt18 = 1;
                    			    	    }
                    			    	    
                    			    	
                    			    	    switch (alt18) 
                    			    		{
                    			    			case 1 :
                    			    			    // MacroScope\\MacroScope.g:928:26: ~ '\"'
                    			    			    {
                    			    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '\uFFFE') ) 
                    			    			    	{
                    			    			    	    input.Consume();
                    			    			    	failed = false;
                    			    			    	}
                    			    			    	else 
                    			    			    	{
                    			    			    	    if ( backtracking > 0 ) {failed = true; return ;}
                    			    			    	    MismatchedSetException mse =
                    			    			    	        new MismatchedSetException(null,input);
                    			    			    	    Recover(mse);    throw mse;
                    			    			    	}

                    			    			    
                    			    			    }
                    			    			    break;
                    			    	
                    			    			default:
                    			    			    goto loop18;
                    			    	    }
                    			    	} while (true);
                    			    	
                    			    	loop18:
                    			    		;	// Stops C# compiler whinging that label 'loop18' has no statements

                    			    	Match('\"'); if (failed) return ;
                    			    
                    			    }
                    			    break;
                    	
                    			default:
                    			    goto loop19;
                    	    }
                    	} while (true);
                    	
                    	loop19:
                    		;	// Stops C# compiler whinging that label 'loop19' has no statements

                    
                    }
                    break;
                case 3 :
                    // MacroScope\\MacroScope.g:929:4: '`' (~ '`' )* '`'
                    {
                    	Match('`'); if (failed) return ;
                    	// MacroScope\\MacroScope.g:929:8: (~ '`' )*
                    	do 
                    	{
                    	    int alt20 = 2;
                    	    int LA20_0 = input.LA(1);
                    	    
                    	    if ( ((LA20_0 >= '\u0000' && LA20_0 <= '_') || (LA20_0 >= 'a' && LA20_0 <= '\uFFFE')) )
                    	    {
                    	        alt20 = 1;
                    	    }
                    	    
                    	
                    	    switch (alt20) 
                    		{
                    			case 1 :
                    			    // MacroScope\\MacroScope.g:929:9: ~ '`'
                    			    {
                    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '_') || (input.LA(1) >= 'a' && input.LA(1) <= '\uFFFE') ) 
                    			    	{
                    			    	    input.Consume();
                    			    	failed = false;
                    			    	}
                    			    	else 
                    			    	{
                    			    	    if ( backtracking > 0 ) {failed = true; return ;}
                    			    	    MismatchedSetException mse =
                    			    	        new MismatchedSetException(null,input);
                    			    	    Recover(mse);    throw mse;
                    			    	}

                    			    
                    			    }
                    			    break;
                    	
                    			default:
                    			    goto loop20;
                    	    }
                    	} while (true);
                    	
                    	loop20:
                    		;	// Stops C# compiler whinging that label 'loop20' has no statements

                    	Match('`'); if (failed) return ;
                    
                    }
                    break;
            
            }
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end QuotedIdentifier

    // $ANTLR start Variable 
    public void mVariable() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = Variable;
            // MacroScope\\MacroScope.g:939:10: ( ( '@' | ':' ) Letter WordTail )
            // MacroScope\\MacroScope.g:940:2: ( '@' | ':' ) Letter WordTail
            {
            	if ( input.LA(1) == ':' || input.LA(1) == '@' ) 
            	{
            	    input.Consume();
            	failed = false;
            	}
            	else 
            	{
            	    if ( backtracking > 0 ) {failed = true; return ;}
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
            	    Recover(mse);    throw mse;
            	}

            	mLetter(); if (failed) return ;
            	mWordTail(); if (failed) return ;
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end Variable

    // $ANTLR start AsciiStringRun 
    public void mAsciiStringRun() // throws RecognitionException [2]
    {
        try 
    	{
            // MacroScope\\MacroScope.g:944:16: ( ( '\\t' | ' ' .. '&' | '(' .. '~' )+ )
            // MacroScope\\MacroScope.g:946:2: ( '\\t' | ' ' .. '&' | '(' .. '~' )+
            {
            	// MacroScope\\MacroScope.g:946:2: ( '\\t' | ' ' .. '&' | '(' .. '~' )+
            	int cnt22 = 0;
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);
            	    
            	    if ( (LA22_0 == '\t' || (LA22_0 >= ' ' && LA22_0 <= '&') || (LA22_0 >= '(' && LA22_0 <= '~')) )
            	    {
            	        alt22 = 1;
            	    }
            	    
            	
            	    switch (alt22) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:
            			    {
            			    	if ( input.LA(1) == '\t' || (input.LA(1) >= ' ' && input.LA(1) <= '&') || (input.LA(1) >= '(' && input.LA(1) <= '~') ) 
            			    	{
            			    	    input.Consume();
            			    	failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( backtracking > 0 ) {failed = true; return ;}
            			    	    MismatchedSetException mse =
            			    	        new MismatchedSetException(null,input);
            			    	    Recover(mse);    throw mse;
            			    	}

            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt22 >= 1 ) goto loop22;
            			    if ( backtracking > 0 ) {failed = true; return ;}
            		            EarlyExitException eee =
            		                new EarlyExitException(22, input);
            		            throw eee;
            	    }
            	    cnt22++;
            	} while (true);
            	
            	loop22:
            		;	// Stops C# compiler whinging that label 'loop22' has no statements

            
            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end AsciiStringRun

    // $ANTLR start AsciiStringLiteral 
    public void mAsciiStringLiteral() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = AsciiStringLiteral;
            Token s = null;
    
            // MacroScope\\MacroScope.g:949:20: ( '\\'' (s= AsciiStringRun )? '\\'' ( '\\'' (s= AsciiStringRun )? '\\'' )* )
            // MacroScope\\MacroScope.g:950:2: '\\'' (s= AsciiStringRun )? '\\'' ( '\\'' (s= AsciiStringRun )? '\\'' )*
            {
            	Match('\''); if (failed) return ;
            	if ( backtracking == 0 ) 
            	{
            	   text = ""; 
            	}
            	// MacroScope\\MacroScope.g:951:2: (s= AsciiStringRun )?
            	int alt23 = 2;
            	int LA23_0 = input.LA(1);
            	
            	if ( (LA23_0 == '\t' || (LA23_0 >= ' ' && LA23_0 <= '&') || (LA23_0 >= '(' && LA23_0 <= '~')) )
            	{
            	    alt23 = 1;
            	}
            	switch (alt23) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:951:4: s= AsciiStringRun
            	        {
            	        	int sStart1227 = CharIndex;
            	        	mAsciiStringRun(); if (failed) return ;
            	        	s = new CommonToken(input, Token.INVALID_TOKEN_TYPE, Token.DEFAULT_CHANNEL, sStart1227, CharIndex-1);
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	   text = s.Text; 
            	        	}
            	        
            	        }
            	        break;
            	
            	}

            	Match('\''); if (failed) return ;
            	// MacroScope\\MacroScope.g:952:2: ( '\\'' (s= AsciiStringRun )? '\\'' )*
            	do 
            	{
            	    int alt25 = 2;
            	    int LA25_0 = input.LA(1);
            	    
            	    if ( (LA25_0 == '\'') )
            	    {
            	        alt25 = 1;
            	    }
            	    
            	
            	    switch (alt25) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:952:4: '\\'' (s= AsciiStringRun )? '\\''
            			    {
            			    	Match('\''); if (failed) return ;
            			    	if ( backtracking == 0 ) 
            			    	{
            			    	  
            			    	  			text = text + "\'";
            			    	  		
            			    	}
            			    	// MacroScope\\MacroScope.g:954:5: (s= AsciiStringRun )?
            			    	int alt24 = 2;
            			    	int LA24_0 = input.LA(1);
            			    	
            			    	if ( (LA24_0 == '\t' || (LA24_0 >= ' ' && LA24_0 <= '&') || (LA24_0 >= '(' && LA24_0 <= '~')) )
            			    	{
            			    	    alt24 = 1;
            			    	}
            			    	switch (alt24) 
            			    	{
            			    	    case 1 :
            			    	        // MacroScope\\MacroScope.g:954:7: s= AsciiStringRun
            			    	        {
            			    	        	int sStart1249 = CharIndex;
            			    	        	mAsciiStringRun(); if (failed) return ;
            			    	        	s = new CommonToken(input, Token.INVALID_TOKEN_TYPE, Token.DEFAULT_CHANNEL, sStart1249, CharIndex-1);
            			    	        	if ( backtracking == 0 ) 
            			    	        	{
            			    	        	   text = text + s.Text; 
            			    	        	}
            			    	        
            			    	        }
            			    	        break;
            			    	
            			    	}

            			    	Match('\''); if (failed) return ;
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop25;
            	    }
            	} while (true);
            	
            	loop25:
            		;	// Stops C# compiler whinging that label 'loop25' has no statements

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end AsciiStringLiteral

    // $ANTLR start UnicodeStringRun 
    public void mUnicodeStringRun() // throws RecognitionException [2]
    {
        try 
    	{
            // MacroScope\\MacroScope.g:959:18: ( (~ '\\'' )+ )
            // MacroScope\\MacroScope.g:960:2: (~ '\\'' )+
            {
            	// MacroScope\\MacroScope.g:960:2: (~ '\\'' )+
            	int cnt26 = 0;
            	do 
            	{
            	    int alt26 = 2;
            	    int LA26_0 = input.LA(1);
            	    
            	    if ( ((LA26_0 >= '\u0000' && LA26_0 <= '&') || (LA26_0 >= '(' && LA26_0 <= '\uFFFE')) )
            	    {
            	        alt26 = 1;
            	    }
            	    
            	
            	    switch (alt26) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:960:3: ~ '\\''
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '&') || (input.LA(1) >= '(' && input.LA(1) <= '\uFFFE') ) 
            			    	{
            			    	    input.Consume();
            			    	failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( backtracking > 0 ) {failed = true; return ;}
            			    	    MismatchedSetException mse =
            			    	        new MismatchedSetException(null,input);
            			    	    Recover(mse);    throw mse;
            			    	}

            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt26 >= 1 ) goto loop26;
            			    if ( backtracking > 0 ) {failed = true; return ;}
            		            EarlyExitException eee =
            		                new EarlyExitException(26, input);
            		            throw eee;
            	    }
            	    cnt26++;
            	} while (true);
            	
            	loop26:
            		;	// Stops C# compiler whinging that label 'loop26' has no statements

            
            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end UnicodeStringRun

    // $ANTLR start UnicodeStringLiteral 
    public void mUnicodeStringLiteral() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = UnicodeStringLiteral;
            Token s = null;
    
            // MacroScope\\MacroScope.g:963:22: ( 'n' '\\'' (s= UnicodeStringRun )? '\\'' ( '\\'' (s= UnicodeStringRun )? '\\'' )* )
            // MacroScope\\MacroScope.g:964:2: 'n' '\\'' (s= UnicodeStringRun )? '\\'' ( '\\'' (s= UnicodeStringRun )? '\\'' )*
            {
            	Match('n'); if (failed) return ;
            	Match('\''); if (failed) return ;
            	if ( backtracking == 0 ) 
            	{
            	   text = ""; 
            	}
            	// MacroScope\\MacroScope.g:965:2: (s= UnicodeStringRun )?
            	int alt27 = 2;
            	int LA27_0 = input.LA(1);
            	
            	if ( ((LA27_0 >= '\u0000' && LA27_0 <= '&') || (LA27_0 >= '(' && LA27_0 <= '\uFFFE')) )
            	{
            	    alt27 = 1;
            	}
            	switch (alt27) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:965:4: s= UnicodeStringRun
            	        {
            	        	int sStart1305 = CharIndex;
            	        	mUnicodeStringRun(); if (failed) return ;
            	        	s = new CommonToken(input, Token.INVALID_TOKEN_TYPE, Token.DEFAULT_CHANNEL, sStart1305, CharIndex-1);
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	   text = s.Text; 
            	        	}
            	        
            	        }
            	        break;
            	
            	}

            	Match('\''); if (failed) return ;
            	// MacroScope\\MacroScope.g:966:2: ( '\\'' (s= UnicodeStringRun )? '\\'' )*
            	do 
            	{
            	    int alt29 = 2;
            	    int LA29_0 = input.LA(1);
            	    
            	    if ( (LA29_0 == '\'') )
            	    {
            	        alt29 = 1;
            	    }
            	    
            	
            	    switch (alt29) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:966:4: '\\'' (s= UnicodeStringRun )? '\\''
            			    {
            			    	Match('\''); if (failed) return ;
            			    	if ( backtracking == 0 ) 
            			    	{
            			    	  
            			    	  			text = text + "\'";
            			    	  		
            			    	}
            			    	// MacroScope\\MacroScope.g:968:5: (s= UnicodeStringRun )?
            			    	int alt28 = 2;
            			    	int LA28_0 = input.LA(1);
            			    	
            			    	if ( ((LA28_0 >= '\u0000' && LA28_0 <= '&') || (LA28_0 >= '(' && LA28_0 <= '\uFFFE')) )
            			    	{
            			    	    alt28 = 1;
            			    	}
            			    	switch (alt28) 
            			    	{
            			    	    case 1 :
            			    	        // MacroScope\\MacroScope.g:968:7: s= UnicodeStringRun
            			    	        {
            			    	        	int sStart1327 = CharIndex;
            			    	        	mUnicodeStringRun(); if (failed) return ;
            			    	        	s = new CommonToken(input, Token.INVALID_TOKEN_TYPE, Token.DEFAULT_CHANNEL, sStart1327, CharIndex-1);
            			    	        	if ( backtracking == 0 ) 
            			    	        	{
            			    	        	   text = text + s.Text; 
            			    	        	}
            			    	        
            			    	        }
            			    	        break;
            			    	
            			    	}

            			    	Match('\''); if (failed) return ;
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop29;
            	    }
            	} while (true);
            	
            	loop29:
            		;	// Stops C# compiler whinging that label 'loop29' has no statements

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end UnicodeStringLiteral

    // $ANTLR start HexLiteral 
    public void mHexLiteral() // throws RecognitionException [2]
    {
        try 
    	{
            // MacroScope\\MacroScope.g:973:12: ()
            // MacroScope\\MacroScope.g:975:2: 
            {
            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end HexLiteral

    // $ANTLR start MINUS 
    public void mMINUS() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = MINUS;
            // MacroScope\\MacroScope.g:977:7: ( '-' )
            // MacroScope\\MacroScope.g:977:9: '-'
            {
            	Match('-'); if (failed) return ;
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end MINUS

    // $ANTLR start COLON 
    public void mCOLON() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = COLON;
            // MacroScope\\MacroScope.g:978:7: ( ':' )
            // MacroScope\\MacroScope.g:978:9: ':'
            {
            	Match(':'); if (failed) return ;
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end COLON

    // $ANTLR start Whitespace 
    public void mWhitespace() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = Whitespace;
            // MacroScope\\MacroScope.g:980:12: ( ( '\\t' | ' ' | '\\r' | '\\n' )+ )
            // MacroScope\\MacroScope.g:980:14: ( '\\t' | ' ' | '\\r' | '\\n' )+
            {
            	// MacroScope\\MacroScope.g:980:14: ( '\\t' | ' ' | '\\r' | '\\n' )+
            	int cnt30 = 0;
            	do 
            	{
            	    int alt30 = 2;
            	    int LA30_0 = input.LA(1);
            	    
            	    if ( ((LA30_0 >= '\t' && LA30_0 <= '\n') || LA30_0 == '\r' || LA30_0 == ' ') )
            	    {
            	        alt30 = 1;
            	    }
            	    
            	
            	    switch (alt30) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();
            			    	failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( backtracking > 0 ) {failed = true; return ;}
            			    	    MismatchedSetException mse =
            			    	        new MismatchedSetException(null,input);
            			    	    Recover(mse);    throw mse;
            			    	}

            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt30 >= 1 ) goto loop30;
            			    if ( backtracking > 0 ) {failed = true; return ;}
            		            EarlyExitException eee =
            		                new EarlyExitException(30, input);
            		            throw eee;
            	    }
            	    cnt30++;
            	} while (true);
            	
            	loop30:
            		;	// Stops C# compiler whinging that label 'loop30' has no statements

            	if ( backtracking == 0 ) 
            	{
            	   channel = HIDDEN; 
            	}
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end Whitespace

    override public void mTokens() // throws RecognitionException 
    {
        // MacroScope\\MacroScope.g:1:8: ( ALL | AND | ANY | AS | ASC | BETWEEN | BY | CASE | CAST | CROSS | DAY | DEFAULT | DELETE | DESC | DISTINCT | ELSE | END | ESCAPE | EXISTS | EXTRACT | FOR | FROM | FULL | GROUP | HAVING | HOUR | IN | INNER | INSERT | INTERVAL | INTO | IS | JOIN | LEFT | LIKE | MINUTE | MONTH | NOT | NULL | ON | OR | ORDER | OUTER | RIGHT | SECOND | SELECT | SET | SOME | SUBSTRING | THEN | TOP | UNION | UPDATE | VALUES | WHEN | WHERE | YEAR | DOT_STAR | DOT | COMMA | LPAREN | RPAREN | ASSIGNEQUAL | NOTEQUAL1 | NOTEQUAL2 | LESSTHANOREQUALTO1 | LESSTHAN | GREATERTHANOREQUALTO1 | GREATERTHAN | DIVIDE | PLUS | STAR | MOD | STRCONCAT | PLACEHOLDER | MAccessDateTime | Iso8601DateTime | Number | NonQuotedIdentifier | QuotedIdentifier | Variable | AsciiStringLiteral | UnicodeStringLiteral | MINUS | COLON | Whitespace )
        int alt31 = 86;
        switch ( input.LA(1) ) 
        {
        case 'a':
        	{
            switch ( input.LA(2) ) 
            {
            case 'n':
            	{
                switch ( input.LA(3) ) 
                {
                case 'y':
                	{
                    int LA31_100 = input.LA(4);
                    
                    if ( ((LA31_100 >= '0' && LA31_100 <= '9') || LA31_100 == '_' || (LA31_100 >= 'a' && LA31_100 <= 'z')) )
                    {
                        alt31 = 79;
                    }
                    else 
                    {
                        alt31 = 3;}
                    }
                    break;
                case 'd':
                	{
                    int LA31_101 = input.LA(4);
                    
                    if ( ((LA31_101 >= '0' && LA31_101 <= '9') || LA31_101 == '_' || (LA31_101 >= 'a' && LA31_101 <= 'z')) )
                    {
                        alt31 = 79;
                    }
                    else 
                    {
                        alt31 = 2;}
                    }
                    break;
                	default:
                    	alt31 = 79;
                    	break;}
            
                }
                break;
            case 'l':
            	{
                int LA31_47 = input.LA(3);
                
                if ( (LA31_47 == 'l') )
                {
                    int LA31_102 = input.LA(4);
                    
                    if ( ((LA31_102 >= '0' && LA31_102 <= '9') || LA31_102 == '_' || (LA31_102 >= 'a' && LA31_102 <= 'z')) )
                    {
                        alt31 = 79;
                    }
                    else 
                    {
                        alt31 = 1;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            case 's':
            	{
                switch ( input.LA(3) ) 
                {
                case 'c':
                	{
                    int LA31_103 = input.LA(4);
                    
                    if ( ((LA31_103 >= '0' && LA31_103 <= '9') || LA31_103 == '_' || (LA31_103 >= 'a' && LA31_103 <= 'z')) )
                    {
                        alt31 = 79;
                    }
                    else 
                    {
                        alt31 = 5;}
                    }
                    break;
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '_':
                case 'a':
                case 'b':
                case 'd':
                case 'e':
                case 'f':
                case 'g':
                case 'h':
                case 'i':
                case 'j':
                case 'k':
                case 'l':
                case 'm':
                case 'n':
                case 'o':
                case 'p':
                case 'q':
                case 'r':
                case 's':
                case 't':
                case 'u':
                case 'v':
                case 'w':
                case 'x':
                case 'y':
                case 'z':
                	{
                    alt31 = 79;
                    }
                    break;
                	default:
                    	alt31 = 4;
                    	break;}
            
                }
                break;
            	default:
                	alt31 = 79;
                	break;}
        
            }
            break;
        case 'b':
        	{
            switch ( input.LA(2) ) 
            {
            case 'e':
            	{
                int LA31_49 = input.LA(3);
                
                if ( (LA31_49 == 't') )
                {
                    int LA31_105 = input.LA(4);
                    
                    if ( (LA31_105 == 'w') )
                    {
                        int LA31_159 = input.LA(5);
                        
                        if ( (LA31_159 == 'e') )
                        {
                            int LA31_207 = input.LA(6);
                            
                            if ( (LA31_207 == 'e') )
                            {
                                int LA31_249 = input.LA(7);
                                
                                if ( (LA31_249 == 'n') )
                                {
                                    int LA31_274 = input.LA(8);
                                    
                                    if ( ((LA31_274 >= '0' && LA31_274 <= '9') || LA31_274 == '_' || (LA31_274 >= 'a' && LA31_274 <= 'z')) )
                                    {
                                        alt31 = 79;
                                    }
                                    else 
                                    {
                                        alt31 = 6;}
                                }
                                else 
                                {
                                    alt31 = 79;}
                            }
                            else 
                            {
                                alt31 = 79;}
                        }
                        else 
                        {
                            alt31 = 79;}
                    }
                    else 
                    {
                        alt31 = 79;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            case 'y':
            	{
                int LA31_50 = input.LA(3);
                
                if ( ((LA31_50 >= '0' && LA31_50 <= '9') || LA31_50 == '_' || (LA31_50 >= 'a' && LA31_50 <= 'z')) )
                {
                    alt31 = 79;
                }
                else 
                {
                    alt31 = 7;}
                }
                break;
            	default:
                	alt31 = 79;
                	break;}
        
            }
            break;
        case 'c':
        	{
            switch ( input.LA(2) ) 
            {
            case 'r':
            	{
                int LA31_51 = input.LA(3);
                
                if ( (LA31_51 == 'o') )
                {
                    int LA31_107 = input.LA(4);
                    
                    if ( (LA31_107 == 's') )
                    {
                        int LA31_160 = input.LA(5);
                        
                        if ( (LA31_160 == 's') )
                        {
                            int LA31_208 = input.LA(6);
                            
                            if ( ((LA31_208 >= '0' && LA31_208 <= '9') || LA31_208 == '_' || (LA31_208 >= 'a' && LA31_208 <= 'z')) )
                            {
                                alt31 = 79;
                            }
                            else 
                            {
                                alt31 = 10;}
                        }
                        else 
                        {
                            alt31 = 79;}
                    }
                    else 
                    {
                        alt31 = 79;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            case 'a':
            	{
                int LA31_52 = input.LA(3);
                
                if ( (LA31_52 == 's') )
                {
                    switch ( input.LA(4) ) 
                    {
                    case 'e':
                    	{
                        int LA31_161 = input.LA(5);
                        
                        if ( ((LA31_161 >= '0' && LA31_161 <= '9') || LA31_161 == '_' || (LA31_161 >= 'a' && LA31_161 <= 'z')) )
                        {
                            alt31 = 79;
                        }
                        else 
                        {
                            alt31 = 8;}
                        }
                        break;
                    case 't':
                    	{
                        int LA31_162 = input.LA(5);
                        
                        if ( ((LA31_162 >= '0' && LA31_162 <= '9') || LA31_162 == '_' || (LA31_162 >= 'a' && LA31_162 <= 'z')) )
                        {
                            alt31 = 79;
                        }
                        else 
                        {
                            alt31 = 9;}
                        }
                        break;
                    	default:
                        	alt31 = 79;
                        	break;}
                
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            	default:
                	alt31 = 79;
                	break;}
        
            }
            break;
        case 'd':
        	{
            switch ( input.LA(2) ) 
            {
            case 'a':
            	{
                int LA31_53 = input.LA(3);
                
                if ( (LA31_53 == 'y') )
                {
                    int LA31_109 = input.LA(4);
                    
                    if ( ((LA31_109 >= '0' && LA31_109 <= '9') || LA31_109 == '_' || (LA31_109 >= 'a' && LA31_109 <= 'z')) )
                    {
                        alt31 = 79;
                    }
                    else 
                    {
                        alt31 = 11;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            case 'e':
            	{
                switch ( input.LA(3) ) 
                {
                case 'l':
                	{
                    int LA31_110 = input.LA(4);
                    
                    if ( (LA31_110 == 'e') )
                    {
                        int LA31_164 = input.LA(5);
                        
                        if ( (LA31_164 == 't') )
                        {
                            int LA31_211 = input.LA(6);
                            
                            if ( (LA31_211 == 'e') )
                            {
                                int LA31_251 = input.LA(7);
                                
                                if ( ((LA31_251 >= '0' && LA31_251 <= '9') || LA31_251 == '_' || (LA31_251 >= 'a' && LA31_251 <= 'z')) )
                                {
                                    alt31 = 79;
                                }
                                else 
                                {
                                    alt31 = 13;}
                            }
                            else 
                            {
                                alt31 = 79;}
                        }
                        else 
                        {
                            alt31 = 79;}
                    }
                    else 
                    {
                        alt31 = 79;}
                    }
                    break;
                case 's':
                	{
                    int LA31_111 = input.LA(4);
                    
                    if ( (LA31_111 == 'c') )
                    {
                        int LA31_165 = input.LA(5);
                        
                        if ( ((LA31_165 >= '0' && LA31_165 <= '9') || LA31_165 == '_' || (LA31_165 >= 'a' && LA31_165 <= 'z')) )
                        {
                            alt31 = 79;
                        }
                        else 
                        {
                            alt31 = 14;}
                    }
                    else 
                    {
                        alt31 = 79;}
                    }
                    break;
                case 'f':
                	{
                    int LA31_112 = input.LA(4);
                    
                    if ( (LA31_112 == 'a') )
                    {
                        int LA31_166 = input.LA(5);
                        
                        if ( (LA31_166 == 'u') )
                        {
                            int LA31_213 = input.LA(6);
                            
                            if ( (LA31_213 == 'l') )
                            {
                                int LA31_252 = input.LA(7);
                                
                                if ( (LA31_252 == 't') )
                                {
                                    int LA31_276 = input.LA(8);
                                    
                                    if ( ((LA31_276 >= '0' && LA31_276 <= '9') || LA31_276 == '_' || (LA31_276 >= 'a' && LA31_276 <= 'z')) )
                                    {
                                        alt31 = 79;
                                    }
                                    else 
                                    {
                                        alt31 = 12;}
                                }
                                else 
                                {
                                    alt31 = 79;}
                            }
                            else 
                            {
                                alt31 = 79;}
                        }
                        else 
                        {
                            alt31 = 79;}
                    }
                    else 
                    {
                        alt31 = 79;}
                    }
                    break;
                	default:
                    	alt31 = 79;
                    	break;}
            
                }
                break;
            case 'i':
            	{
                int LA31_55 = input.LA(3);
                
                if ( (LA31_55 == 's') )
                {
                    int LA31_113 = input.LA(4);
                    
                    if ( (LA31_113 == 't') )
                    {
                        int LA31_167 = input.LA(5);
                        
                        if ( (LA31_167 == 'i') )
                        {
                            int LA31_214 = input.LA(6);
                            
                            if ( (LA31_214 == 'n') )
                            {
                                int LA31_253 = input.LA(7);
                                
                                if ( (LA31_253 == 'c') )
                                {
                                    int LA31_277 = input.LA(8);
                                    
                                    if ( (LA31_277 == 't') )
                                    {
                                        int LA31_292 = input.LA(9);
                                        
                                        if ( ((LA31_292 >= '0' && LA31_292 <= '9') || LA31_292 == '_' || (LA31_292 >= 'a' && LA31_292 <= 'z')) )
                                        {
                                            alt31 = 79;
                                        }
                                        else 
                                        {
                                            alt31 = 15;}
                                    }
                                    else 
                                    {
                                        alt31 = 79;}
                                }
                                else 
                                {
                                    alt31 = 79;}
                            }
                            else 
                            {
                                alt31 = 79;}
                        }
                        else 
                        {
                            alt31 = 79;}
                    }
                    else 
                    {
                        alt31 = 79;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            	default:
                	alt31 = 79;
                	break;}
        
            }
            break;
        case 'e':
        	{
            switch ( input.LA(2) ) 
            {
            case 'x':
            	{
                switch ( input.LA(3) ) 
                {
                case 'i':
                	{
                    int LA31_114 = input.LA(4);
                    
                    if ( (LA31_114 == 's') )
                    {
                        int LA31_168 = input.LA(5);
                        
                        if ( (LA31_168 == 't') )
                        {
                            int LA31_215 = input.LA(6);
                            
                            if ( (LA31_215 == 's') )
                            {
                                int LA31_254 = input.LA(7);
                                
                                if ( ((LA31_254 >= '0' && LA31_254 <= '9') || LA31_254 == '_' || (LA31_254 >= 'a' && LA31_254 <= 'z')) )
                                {
                                    alt31 = 79;
                                }
                                else 
                                {
                                    alt31 = 19;}
                            }
                            else 
                            {
                                alt31 = 79;}
                        }
                        else 
                        {
                            alt31 = 79;}
                    }
                    else 
                    {
                        alt31 = 79;}
                    }
                    break;
                case 't':
                	{
                    int LA31_115 = input.LA(4);
                    
                    if ( (LA31_115 == 'r') )
                    {
                        int LA31_169 = input.LA(5);
                        
                        if ( (LA31_169 == 'a') )
                        {
                            int LA31_216 = input.LA(6);
                            
                            if ( (LA31_216 == 'c') )
                            {
                                int LA31_255 = input.LA(7);
                                
                                if ( (LA31_255 == 't') )
                                {
                                    int LA31_279 = input.LA(8);
                                    
                                    if ( ((LA31_279 >= '0' && LA31_279 <= '9') || LA31_279 == '_' || (LA31_279 >= 'a' && LA31_279 <= 'z')) )
                                    {
                                        alt31 = 79;
                                    }
                                    else 
                                    {
                                        alt31 = 20;}
                                }
                                else 
                                {
                                    alt31 = 79;}
                            }
                            else 
                            {
                                alt31 = 79;}
                        }
                        else 
                        {
                            alt31 = 79;}
                    }
                    else 
                    {
                        alt31 = 79;}
                    }
                    break;
                	default:
                    	alt31 = 79;
                    	break;}
            
                }
                break;
            case 's':
            	{
                int LA31_57 = input.LA(3);
                
                if ( (LA31_57 == 'c') )
                {
                    int LA31_116 = input.LA(4);
                    
                    if ( (LA31_116 == 'a') )
                    {
                        int LA31_170 = input.LA(5);
                        
                        if ( (LA31_170 == 'p') )
                        {
                            int LA31_217 = input.LA(6);
                            
                            if ( (LA31_217 == 'e') )
                            {
                                int LA31_256 = input.LA(7);
                                
                                if ( ((LA31_256 >= '0' && LA31_256 <= '9') || LA31_256 == '_' || (LA31_256 >= 'a' && LA31_256 <= 'z')) )
                                {
                                    alt31 = 79;
                                }
                                else 
                                {
                                    alt31 = 18;}
                            }
                            else 
                            {
                                alt31 = 79;}
                        }
                        else 
                        {
                            alt31 = 79;}
                    }
                    else 
                    {
                        alt31 = 79;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            case 'n':
            	{
                int LA31_58 = input.LA(3);
                
                if ( (LA31_58 == 'd') )
                {
                    int LA31_117 = input.LA(4);
                    
                    if ( ((LA31_117 >= '0' && LA31_117 <= '9') || LA31_117 == '_' || (LA31_117 >= 'a' && LA31_117 <= 'z')) )
                    {
                        alt31 = 79;
                    }
                    else 
                    {
                        alt31 = 17;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            case 'l':
            	{
                int LA31_59 = input.LA(3);
                
                if ( (LA31_59 == 's') )
                {
                    int LA31_118 = input.LA(4);
                    
                    if ( (LA31_118 == 'e') )
                    {
                        int LA31_172 = input.LA(5);
                        
                        if ( ((LA31_172 >= '0' && LA31_172 <= '9') || LA31_172 == '_' || (LA31_172 >= 'a' && LA31_172 <= 'z')) )
                        {
                            alt31 = 79;
                        }
                        else 
                        {
                            alt31 = 16;}
                    }
                    else 
                    {
                        alt31 = 79;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            	default:
                	alt31 = 79;
                	break;}
        
            }
            break;
        case 'f':
        	{
            switch ( input.LA(2) ) 
            {
            case 'u':
            	{
                int LA31_60 = input.LA(3);
                
                if ( (LA31_60 == 'l') )
                {
                    int LA31_119 = input.LA(4);
                    
                    if ( (LA31_119 == 'l') )
                    {
                        int LA31_173 = input.LA(5);
                        
                        if ( ((LA31_173 >= '0' && LA31_173 <= '9') || LA31_173 == '_' || (LA31_173 >= 'a' && LA31_173 <= 'z')) )
                        {
                            alt31 = 79;
                        }
                        else 
                        {
                            alt31 = 23;}
                    }
                    else 
                    {
                        alt31 = 79;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            case 'r':
            	{
                int LA31_61 = input.LA(3);
                
                if ( (LA31_61 == 'o') )
                {
                    int LA31_120 = input.LA(4);
                    
                    if ( (LA31_120 == 'm') )
                    {
                        int LA31_174 = input.LA(5);
                        
                        if ( ((LA31_174 >= '0' && LA31_174 <= '9') || LA31_174 == '_' || (LA31_174 >= 'a' && LA31_174 <= 'z')) )
                        {
                            alt31 = 79;
                        }
                        else 
                        {
                            alt31 = 22;}
                    }
                    else 
                    {
                        alt31 = 79;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            case 'o':
            	{
                int LA31_62 = input.LA(3);
                
                if ( (LA31_62 == 'r') )
                {
                    int LA31_121 = input.LA(4);
                    
                    if ( ((LA31_121 >= '0' && LA31_121 <= '9') || LA31_121 == '_' || (LA31_121 >= 'a' && LA31_121 <= 'z')) )
                    {
                        alt31 = 79;
                    }
                    else 
                    {
                        alt31 = 21;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            	default:
                	alt31 = 79;
                	break;}
        
            }
            break;
        case 'g':
        	{
            int LA31_7 = input.LA(2);
            
            if ( (LA31_7 == 'r') )
            {
                int LA31_63 = input.LA(3);
                
                if ( (LA31_63 == 'o') )
                {
                    int LA31_122 = input.LA(4);
                    
                    if ( (LA31_122 == 'u') )
                    {
                        int LA31_176 = input.LA(5);
                        
                        if ( (LA31_176 == 'p') )
                        {
                            int LA31_221 = input.LA(6);
                            
                            if ( ((LA31_221 >= '0' && LA31_221 <= '9') || LA31_221 == '_' || (LA31_221 >= 'a' && LA31_221 <= 'z')) )
                            {
                                alt31 = 79;
                            }
                            else 
                            {
                                alt31 = 24;}
                        }
                        else 
                        {
                            alt31 = 79;}
                    }
                    else 
                    {
                        alt31 = 79;}
                }
                else 
                {
                    alt31 = 79;}
            }
            else 
            {
                alt31 = 79;}
            }
            break;
        case 'h':
        	{
            switch ( input.LA(2) ) 
            {
            case 'a':
            	{
                int LA31_64 = input.LA(3);
                
                if ( (LA31_64 == 'v') )
                {
                    int LA31_123 = input.LA(4);
                    
                    if ( (LA31_123 == 'i') )
                    {
                        int LA31_177 = input.LA(5);
                        
                        if ( (LA31_177 == 'n') )
                        {
                            int LA31_222 = input.LA(6);
                            
                            if ( (LA31_222 == 'g') )
                            {
                                int LA31_258 = input.LA(7);
                                
                                if ( ((LA31_258 >= '0' && LA31_258 <= '9') || LA31_258 == '_' || (LA31_258 >= 'a' && LA31_258 <= 'z')) )
                                {
                                    alt31 = 79;
                                }
                                else 
                                {
                                    alt31 = 25;}
                            }
                            else 
                            {
                                alt31 = 79;}
                        }
                        else 
                        {
                            alt31 = 79;}
                    }
                    else 
                    {
                        alt31 = 79;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            case 'o':
            	{
                int LA31_65 = input.LA(3);
                
                if ( (LA31_65 == 'u') )
                {
                    int LA31_124 = input.LA(4);
                    
                    if ( (LA31_124 == 'r') )
                    {
                        int LA31_178 = input.LA(5);
                        
                        if ( ((LA31_178 >= '0' && LA31_178 <= '9') || LA31_178 == '_' || (LA31_178 >= 'a' && LA31_178 <= 'z')) )
                        {
                            alt31 = 79;
                        }
                        else 
                        {
                            alt31 = 26;}
                    }
                    else 
                    {
                        alt31 = 79;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            	default:
                	alt31 = 79;
                	break;}
        
            }
            break;
        case 'i':
        	{
            switch ( input.LA(2) ) 
            {
            case 'n':
            	{
                switch ( input.LA(3) ) 
                {
                case 's':
                	{
                    int LA31_125 = input.LA(4);
                    
                    if ( (LA31_125 == 'e') )
                    {
                        int LA31_179 = input.LA(5);
                        
                        if ( (LA31_179 == 'r') )
                        {
                            int LA31_224 = input.LA(6);
                            
                            if ( (LA31_224 == 't') )
                            {
                                int LA31_259 = input.LA(7);
                                
                                if ( ((LA31_259 >= '0' && LA31_259 <= '9') || LA31_259 == '_' || (LA31_259 >= 'a' && LA31_259 <= 'z')) )
                                {
                                    alt31 = 79;
                                }
                                else 
                                {
                                    alt31 = 29;}
                            }
                            else 
                            {
                                alt31 = 79;}
                        }
                        else 
                        {
                            alt31 = 79;}
                    }
                    else 
                    {
                        alt31 = 79;}
                    }
                    break;
                case 't':
                	{
                    switch ( input.LA(4) ) 
                    {
                    case 'o':
                    	{
                        int LA31_180 = input.LA(5);
                        
                        if ( ((LA31_180 >= '0' && LA31_180 <= '9') || LA31_180 == '_' || (LA31_180 >= 'a' && LA31_180 <= 'z')) )
                        {
                            alt31 = 79;
                        }
                        else 
                        {
                            alt31 = 31;}
                        }
                        break;
                    case 'e':
                    	{
                        int LA31_181 = input.LA(5);
                        
                        if ( (LA31_181 == 'r') )
                        {
                            int LA31_226 = input.LA(6);
                            
                            if ( (LA31_226 == 'v') )
                            {
                                int LA31_260 = input.LA(7);
                                
                                if ( (LA31_260 == 'a') )
                                {
                                    int LA31_283 = input.LA(8);
                                    
                                    if ( (LA31_283 == 'l') )
                                    {
                                        int LA31_294 = input.LA(9);
                                        
                                        if ( ((LA31_294 >= '0' && LA31_294 <= '9') || LA31_294 == '_' || (LA31_294 >= 'a' && LA31_294 <= 'z')) )
                                        {
                                            alt31 = 79;
                                        }
                                        else 
                                        {
                                            alt31 = 30;}
                                    }
                                    else 
                                    {
                                        alt31 = 79;}
                                }
                                else 
                                {
                                    alt31 = 79;}
                            }
                            else 
                            {
                                alt31 = 79;}
                        }
                        else 
                        {
                            alt31 = 79;}
                        }
                        break;
                    	default:
                        	alt31 = 79;
                        	break;}
                
                    }
                    break;
                case 'n':
                	{
                    int LA31_127 = input.LA(4);
                    
                    if ( (LA31_127 == 'e') )
                    {
                        int LA31_182 = input.LA(5);
                        
                        if ( (LA31_182 == 'r') )
                        {
                            int LA31_227 = input.LA(6);
                            
                            if ( ((LA31_227 >= '0' && LA31_227 <= '9') || LA31_227 == '_' || (LA31_227 >= 'a' && LA31_227 <= 'z')) )
                            {
                                alt31 = 79;
                            }
                            else 
                            {
                                alt31 = 28;}
                        }
                        else 
                        {
                            alt31 = 79;}
                    }
                    else 
                    {
                        alt31 = 79;}
                    }
                    break;
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '_':
                case 'a':
                case 'b':
                case 'c':
                case 'd':
                case 'e':
                case 'f':
                case 'g':
                case 'h':
                case 'i':
                case 'j':
                case 'k':
                case 'l':
                case 'm':
                case 'o':
                case 'p':
                case 'q':
                case 'r':
                case 'u':
                case 'v':
                case 'w':
                case 'x':
                case 'y':
                case 'z':
                	{
                    alt31 = 79;
                    }
                    break;
                	default:
                    	alt31 = 27;
                    	break;}
            
                }
                break;
            case 's':
            	{
                int LA31_67 = input.LA(3);
                
                if ( ((LA31_67 >= '0' && LA31_67 <= '9') || LA31_67 == '_' || (LA31_67 >= 'a' && LA31_67 <= 'z')) )
                {
                    alt31 = 79;
                }
                else 
                {
                    alt31 = 32;}
                }
                break;
            	default:
                	alt31 = 79;
                	break;}
        
            }
            break;
        case 'j':
        	{
            int LA31_10 = input.LA(2);
            
            if ( (LA31_10 == 'o') )
            {
                int LA31_68 = input.LA(3);
                
                if ( (LA31_68 == 'i') )
                {
                    int LA31_130 = input.LA(4);
                    
                    if ( (LA31_130 == 'n') )
                    {
                        int LA31_183 = input.LA(5);
                        
                        if ( ((LA31_183 >= '0' && LA31_183 <= '9') || LA31_183 == '_' || (LA31_183 >= 'a' && LA31_183 <= 'z')) )
                        {
                            alt31 = 79;
                        }
                        else 
                        {
                            alt31 = 33;}
                    }
                    else 
                    {
                        alt31 = 79;}
                }
                else 
                {
                    alt31 = 79;}
            }
            else 
            {
                alt31 = 79;}
            }
            break;
        case 'l':
        	{
            switch ( input.LA(2) ) 
            {
            case 'i':
            	{
                int LA31_69 = input.LA(3);
                
                if ( (LA31_69 == 'k') )
                {
                    int LA31_131 = input.LA(4);
                    
                    if ( (LA31_131 == 'e') )
                    {
                        int LA31_184 = input.LA(5);
                        
                        if ( ((LA31_184 >= '0' && LA31_184 <= '9') || LA31_184 == '_' || (LA31_184 >= 'a' && LA31_184 <= 'z')) )
                        {
                            alt31 = 79;
                        }
                        else 
                        {
                            alt31 = 35;}
                    }
                    else 
                    {
                        alt31 = 79;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            case 'e':
            	{
                int LA31_70 = input.LA(3);
                
                if ( (LA31_70 == 'f') )
                {
                    int LA31_132 = input.LA(4);
                    
                    if ( (LA31_132 == 't') )
                    {
                        int LA31_185 = input.LA(5);
                        
                        if ( ((LA31_185 >= '0' && LA31_185 <= '9') || LA31_185 == '_' || (LA31_185 >= 'a' && LA31_185 <= 'z')) )
                        {
                            alt31 = 79;
                        }
                        else 
                        {
                            alt31 = 34;}
                    }
                    else 
                    {
                        alt31 = 79;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            	default:
                	alt31 = 79;
                	break;}
        
            }
            break;
        case 'm':
        	{
            switch ( input.LA(2) ) 
            {
            case 'i':
            	{
                int LA31_71 = input.LA(3);
                
                if ( (LA31_71 == 'n') )
                {
                    int LA31_133 = input.LA(4);
                    
                    if ( (LA31_133 == 'u') )
                    {
                        int LA31_186 = input.LA(5);
                        
                        if ( (LA31_186 == 't') )
                        {
                            int LA31_231 = input.LA(6);
                            
                            if ( (LA31_231 == 'e') )
                            {
                                int LA31_262 = input.LA(7);
                                
                                if ( ((LA31_262 >= '0' && LA31_262 <= '9') || LA31_262 == '_' || (LA31_262 >= 'a' && LA31_262 <= 'z')) )
                                {
                                    alt31 = 79;
                                }
                                else 
                                {
                                    alt31 = 36;}
                            }
                            else 
                            {
                                alt31 = 79;}
                        }
                        else 
                        {
                            alt31 = 79;}
                    }
                    else 
                    {
                        alt31 = 79;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            case 'o':
            	{
                int LA31_72 = input.LA(3);
                
                if ( (LA31_72 == 'n') )
                {
                    int LA31_134 = input.LA(4);
                    
                    if ( (LA31_134 == 't') )
                    {
                        int LA31_187 = input.LA(5);
                        
                        if ( (LA31_187 == 'h') )
                        {
                            int LA31_232 = input.LA(6);
                            
                            if ( ((LA31_232 >= '0' && LA31_232 <= '9') || LA31_232 == '_' || (LA31_232 >= 'a' && LA31_232 <= 'z')) )
                            {
                                alt31 = 79;
                            }
                            else 
                            {
                                alt31 = 37;}
                        }
                        else 
                        {
                            alt31 = 79;}
                    }
                    else 
                    {
                        alt31 = 79;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            	default:
                	alt31 = 79;
                	break;}
        
            }
            break;
        case 'n':
        	{
            switch ( input.LA(2) ) 
            {
            case '\'':
            	{
                alt31 = 83;
                }
                break;
            case 'o':
            	{
                int LA31_74 = input.LA(3);
                
                if ( (LA31_74 == 't') )
                {
                    int LA31_135 = input.LA(4);
                    
                    if ( ((LA31_135 >= '0' && LA31_135 <= '9') || LA31_135 == '_' || (LA31_135 >= 'a' && LA31_135 <= 'z')) )
                    {
                        alt31 = 79;
                    }
                    else 
                    {
                        alt31 = 38;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            case 'u':
            	{
                int LA31_75 = input.LA(3);
                
                if ( (LA31_75 == 'l') )
                {
                    int LA31_136 = input.LA(4);
                    
                    if ( (LA31_136 == 'l') )
                    {
                        int LA31_189 = input.LA(5);
                        
                        if ( ((LA31_189 >= '0' && LA31_189 <= '9') || LA31_189 == '_' || (LA31_189 >= 'a' && LA31_189 <= 'z')) )
                        {
                            alt31 = 79;
                        }
                        else 
                        {
                            alt31 = 39;}
                    }
                    else 
                    {
                        alt31 = 79;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            	default:
                	alt31 = 79;
                	break;}
        
            }
            break;
        case 'o':
        	{
            switch ( input.LA(2) ) 
            {
            case 'r':
            	{
                switch ( input.LA(3) ) 
                {
                case 'd':
                	{
                    int LA31_137 = input.LA(4);
                    
                    if ( (LA31_137 == 'e') )
                    {
                        int LA31_190 = input.LA(5);
                        
                        if ( (LA31_190 == 'r') )
                        {
                            int LA31_234 = input.LA(6);
                            
                            if ( ((LA31_234 >= '0' && LA31_234 <= '9') || LA31_234 == '_' || (LA31_234 >= 'a' && LA31_234 <= 'z')) )
                            {
                                alt31 = 79;
                            }
                            else 
                            {
                                alt31 = 42;}
                        }
                        else 
                        {
                            alt31 = 79;}
                    }
                    else 
                    {
                        alt31 = 79;}
                    }
                    break;
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '_':
                case 'a':
                case 'b':
                case 'c':
                case 'e':
                case 'f':
                case 'g':
                case 'h':
                case 'i':
                case 'j':
                case 'k':
                case 'l':
                case 'm':
                case 'n':
                case 'o':
                case 'p':
                case 'q':
                case 'r':
                case 's':
                case 't':
                case 'u':
                case 'v':
                case 'w':
                case 'x':
                case 'y':
                case 'z':
                	{
                    alt31 = 79;
                    }
                    break;
                	default:
                    	alt31 = 41;
                    	break;}
            
                }
                break;
            case 'u':
            	{
                int LA31_77 = input.LA(3);
                
                if ( (LA31_77 == 't') )
                {
                    int LA31_139 = input.LA(4);
                    
                    if ( (LA31_139 == 'e') )
                    {
                        int LA31_191 = input.LA(5);
                        
                        if ( (LA31_191 == 'r') )
                        {
                            int LA31_235 = input.LA(6);
                            
                            if ( ((LA31_235 >= '0' && LA31_235 <= '9') || LA31_235 == '_' || (LA31_235 >= 'a' && LA31_235 <= 'z')) )
                            {
                                alt31 = 79;
                            }
                            else 
                            {
                                alt31 = 43;}
                        }
                        else 
                        {
                            alt31 = 79;}
                    }
                    else 
                    {
                        alt31 = 79;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            case 'n':
            	{
                int LA31_78 = input.LA(3);
                
                if ( ((LA31_78 >= '0' && LA31_78 <= '9') || LA31_78 == '_' || (LA31_78 >= 'a' && LA31_78 <= 'z')) )
                {
                    alt31 = 79;
                }
                else 
                {
                    alt31 = 40;}
                }
                break;
            	default:
                	alt31 = 79;
                	break;}
        
            }
            break;
        case 'r':
        	{
            int LA31_15 = input.LA(2);
            
            if ( (LA31_15 == 'i') )
            {
                int LA31_79 = input.LA(3);
                
                if ( (LA31_79 == 'g') )
                {
                    int LA31_141 = input.LA(4);
                    
                    if ( (LA31_141 == 'h') )
                    {
                        int LA31_192 = input.LA(5);
                        
                        if ( (LA31_192 == 't') )
                        {
                            int LA31_236 = input.LA(6);
                            
                            if ( ((LA31_236 >= '0' && LA31_236 <= '9') || LA31_236 == '_' || (LA31_236 >= 'a' && LA31_236 <= 'z')) )
                            {
                                alt31 = 79;
                            }
                            else 
                            {
                                alt31 = 44;}
                        }
                        else 
                        {
                            alt31 = 79;}
                    }
                    else 
                    {
                        alt31 = 79;}
                }
                else 
                {
                    alt31 = 79;}
            }
            else 
            {
                alt31 = 79;}
            }
            break;
        case 's':
        	{
            switch ( input.LA(2) ) 
            {
            case 'e':
            	{
                switch ( input.LA(3) ) 
                {
                case 't':
                	{
                    int LA31_142 = input.LA(4);
                    
                    if ( ((LA31_142 >= '0' && LA31_142 <= '9') || LA31_142 == '_' || (LA31_142 >= 'a' && LA31_142 <= 'z')) )
                    {
                        alt31 = 79;
                    }
                    else 
                    {
                        alt31 = 47;}
                    }
                    break;
                case 'l':
                	{
                    int LA31_143 = input.LA(4);
                    
                    if ( (LA31_143 == 'e') )
                    {
                        int LA31_194 = input.LA(5);
                        
                        if ( (LA31_194 == 'c') )
                        {
                            int LA31_237 = input.LA(6);
                            
                            if ( (LA31_237 == 't') )
                            {
                                int LA31_267 = input.LA(7);
                                
                                if ( ((LA31_267 >= '0' && LA31_267 <= '9') || LA31_267 == '_' || (LA31_267 >= 'a' && LA31_267 <= 'z')) )
                                {
                                    alt31 = 79;
                                }
                                else 
                                {
                                    alt31 = 46;}
                            }
                            else 
                            {
                                alt31 = 79;}
                        }
                        else 
                        {
                            alt31 = 79;}
                    }
                    else 
                    {
                        alt31 = 79;}
                    }
                    break;
                case 'c':
                	{
                    int LA31_144 = input.LA(4);
                    
                    if ( (LA31_144 == 'o') )
                    {
                        int LA31_195 = input.LA(5);
                        
                        if ( (LA31_195 == 'n') )
                        {
                            int LA31_238 = input.LA(6);
                            
                            if ( (LA31_238 == 'd') )
                            {
                                int LA31_268 = input.LA(7);
                                
                                if ( ((LA31_268 >= '0' && LA31_268 <= '9') || LA31_268 == '_' || (LA31_268 >= 'a' && LA31_268 <= 'z')) )
                                {
                                    alt31 = 79;
                                }
                                else 
                                {
                                    alt31 = 45;}
                            }
                            else 
                            {
                                alt31 = 79;}
                        }
                        else 
                        {
                            alt31 = 79;}
                    }
                    else 
                    {
                        alt31 = 79;}
                    }
                    break;
                	default:
                    	alt31 = 79;
                    	break;}
            
                }
                break;
            case 'u':
            	{
                int LA31_81 = input.LA(3);
                
                if ( (LA31_81 == 'b') )
                {
                    int LA31_145 = input.LA(4);
                    
                    if ( (LA31_145 == 's') )
                    {
                        int LA31_196 = input.LA(5);
                        
                        if ( (LA31_196 == 't') )
                        {
                            int LA31_239 = input.LA(6);
                            
                            if ( (LA31_239 == 'r') )
                            {
                                int LA31_269 = input.LA(7);
                                
                                if ( (LA31_269 == 'i') )
                                {
                                    int LA31_287 = input.LA(8);
                                    
                                    if ( (LA31_287 == 'n') )
                                    {
                                        int LA31_295 = input.LA(9);
                                        
                                        if ( (LA31_295 == 'g') )
                                        {
                                            int LA31_298 = input.LA(10);
                                            
                                            if ( ((LA31_298 >= '0' && LA31_298 <= '9') || LA31_298 == '_' || (LA31_298 >= 'a' && LA31_298 <= 'z')) )
                                            {
                                                alt31 = 79;
                                            }
                                            else 
                                            {
                                                alt31 = 49;}
                                        }
                                        else 
                                        {
                                            alt31 = 79;}
                                    }
                                    else 
                                    {
                                        alt31 = 79;}
                                }
                                else 
                                {
                                    alt31 = 79;}
                            }
                            else 
                            {
                                alt31 = 79;}
                        }
                        else 
                        {
                            alt31 = 79;}
                    }
                    else 
                    {
                        alt31 = 79;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            case 'o':
            	{
                int LA31_82 = input.LA(3);
                
                if ( (LA31_82 == 'm') )
                {
                    int LA31_146 = input.LA(4);
                    
                    if ( (LA31_146 == 'e') )
                    {
                        int LA31_197 = input.LA(5);
                        
                        if ( ((LA31_197 >= '0' && LA31_197 <= '9') || LA31_197 == '_' || (LA31_197 >= 'a' && LA31_197 <= 'z')) )
                        {
                            alt31 = 79;
                        }
                        else 
                        {
                            alt31 = 48;}
                    }
                    else 
                    {
                        alt31 = 79;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            	default:
                	alt31 = 79;
                	break;}
        
            }
            break;
        case 't':
        	{
            switch ( input.LA(2) ) 
            {
            case 'h':
            	{
                int LA31_83 = input.LA(3);
                
                if ( (LA31_83 == 'e') )
                {
                    int LA31_147 = input.LA(4);
                    
                    if ( (LA31_147 == 'n') )
                    {
                        int LA31_198 = input.LA(5);
                        
                        if ( ((LA31_198 >= '0' && LA31_198 <= '9') || LA31_198 == '_' || (LA31_198 >= 'a' && LA31_198 <= 'z')) )
                        {
                            alt31 = 79;
                        }
                        else 
                        {
                            alt31 = 50;}
                    }
                    else 
                    {
                        alt31 = 79;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            case 'o':
            	{
                int LA31_84 = input.LA(3);
                
                if ( (LA31_84 == 'p') )
                {
                    int LA31_148 = input.LA(4);
                    
                    if ( ((LA31_148 >= '0' && LA31_148 <= '9') || LA31_148 == '_' || (LA31_148 >= 'a' && LA31_148 <= 'z')) )
                    {
                        alt31 = 79;
                    }
                    else 
                    {
                        alt31 = 51;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            	default:
                	alt31 = 79;
                	break;}
        
            }
            break;
        case 'u':
        	{
            switch ( input.LA(2) ) 
            {
            case 'p':
            	{
                int LA31_85 = input.LA(3);
                
                if ( (LA31_85 == 'd') )
                {
                    int LA31_149 = input.LA(4);
                    
                    if ( (LA31_149 == 'a') )
                    {
                        int LA31_200 = input.LA(5);
                        
                        if ( (LA31_200 == 't') )
                        {
                            int LA31_242 = input.LA(6);
                            
                            if ( (LA31_242 == 'e') )
                            {
                                int LA31_270 = input.LA(7);
                                
                                if ( ((LA31_270 >= '0' && LA31_270 <= '9') || LA31_270 == '_' || (LA31_270 >= 'a' && LA31_270 <= 'z')) )
                                {
                                    alt31 = 79;
                                }
                                else 
                                {
                                    alt31 = 53;}
                            }
                            else 
                            {
                                alt31 = 79;}
                        }
                        else 
                        {
                            alt31 = 79;}
                    }
                    else 
                    {
                        alt31 = 79;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            case 'n':
            	{
                int LA31_86 = input.LA(3);
                
                if ( (LA31_86 == 'i') )
                {
                    int LA31_150 = input.LA(4);
                    
                    if ( (LA31_150 == 'o') )
                    {
                        int LA31_201 = input.LA(5);
                        
                        if ( (LA31_201 == 'n') )
                        {
                            int LA31_243 = input.LA(6);
                            
                            if ( ((LA31_243 >= '0' && LA31_243 <= '9') || LA31_243 == '_' || (LA31_243 >= 'a' && LA31_243 <= 'z')) )
                            {
                                alt31 = 79;
                            }
                            else 
                            {
                                alt31 = 52;}
                        }
                        else 
                        {
                            alt31 = 79;}
                    }
                    else 
                    {
                        alt31 = 79;}
                }
                else 
                {
                    alt31 = 79;}
                }
                break;
            	default:
                	alt31 = 79;
                	break;}
        
            }
            break;
        case 'v':
        	{
            int LA31_19 = input.LA(2);
            
            if ( (LA31_19 == 'a') )
            {
                int LA31_87 = input.LA(3);
                
                if ( (LA31_87 == 'l') )
                {
                    int LA31_151 = input.LA(4);
                    
                    if ( (LA31_151 == 'u') )
                    {
                        int LA31_202 = input.LA(5);
                        
                        if ( (LA31_202 == 'e') )
                        {
                            int LA31_244 = input.LA(6);
                            
                            if ( (LA31_244 == 's') )
                            {
                                int LA31_272 = input.LA(7);
                                
                                if ( ((LA31_272 >= '0' && LA31_272 <= '9') || LA31_272 == '_' || (LA31_272 >= 'a' && LA31_272 <= 'z')) )
                                {
                                    alt31 = 79;
                                }
                                else 
                                {
                                    alt31 = 54;}
                            }
                            else 
                            {
                                alt31 = 79;}
                        }
                        else 
                        {
                            alt31 = 79;}
                    }
                    else 
                    {
                        alt31 = 79;}
                }
                else 
                {
                    alt31 = 79;}
            }
            else 
            {
                alt31 = 79;}
            }
            break;
        case 'w':
        	{
            int LA31_20 = input.LA(2);
            
            if ( (LA31_20 == 'h') )
            {
                int LA31_88 = input.LA(3);
                
                if ( (LA31_88 == 'e') )
                {
                    switch ( input.LA(4) ) 
                    {
                    case 'n':
                    	{
                        int LA31_203 = input.LA(5);
                        
                        if ( ((LA31_203 >= '0' && LA31_203 <= '9') || LA31_203 == '_' || (LA31_203 >= 'a' && LA31_203 <= 'z')) )
                        {
                            alt31 = 79;
                        }
                        else 
                        {
                            alt31 = 55;}
                        }
                        break;
                    case 'r':
                    	{
                        int LA31_204 = input.LA(5);
                        
                        if ( (LA31_204 == 'e') )
                        {
                            int LA31_246 = input.LA(6);
                            
                            if ( ((LA31_246 >= '0' && LA31_246 <= '9') || LA31_246 == '_' || (LA31_246 >= 'a' && LA31_246 <= 'z')) )
                            {
                                alt31 = 79;
                            }
                            else 
                            {
                                alt31 = 56;}
                        }
                        else 
                        {
                            alt31 = 79;}
                        }
                        break;
                    	default:
                        	alt31 = 79;
                        	break;}
                
                }
                else 
                {
                    alt31 = 79;}
            }
            else 
            {
                alt31 = 79;}
            }
            break;
        case 'y':
        	{
            int LA31_21 = input.LA(2);
            
            if ( (LA31_21 == 'e') )
            {
                int LA31_89 = input.LA(3);
                
                if ( (LA31_89 == 'a') )
                {
                    int LA31_153 = input.LA(4);
                    
                    if ( (LA31_153 == 'r') )
                    {
                        int LA31_205 = input.LA(5);
                        
                        if ( ((LA31_205 >= '0' && LA31_205 <= '9') || LA31_205 == '_' || (LA31_205 >= 'a' && LA31_205 <= 'z')) )
                        {
                            alt31 = 79;
                        }
                        else 
                        {
                            alt31 = 57;}
                    }
                    else 
                    {
                        alt31 = 79;}
                }
                else 
                {
                    alt31 = 79;}
            }
            else 
            {
                alt31 = 79;}
            }
            break;
        case '.':
        	{
            switch ( input.LA(2) ) 
            {
            case '*':
            	{
                alt31 = 58;
                }
                break;
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
            	{
                alt31 = 78;
                }
                break;
            	default:
                	alt31 = 59;
                	break;}
        
            }
            break;
        case ',':
        	{
            alt31 = 60;
            }
            break;
        case '(':
        	{
            alt31 = 61;
            }
            break;
        case ')':
        	{
            alt31 = 62;
            }
            break;
        case '=':
        	{
            alt31 = 63;
            }
            break;
        case '<':
        	{
            switch ( input.LA(2) ) 
            {
            case '=':
            	{
                alt31 = 66;
                }
                break;
            case '>':
            	{
                alt31 = 64;
                }
                break;
            	default:
                	alt31 = 67;
                	break;}
        
            }
            break;
        case '!':
        	{
            alt31 = 65;
            }
            break;
        case '>':
        	{
            int LA31_29 = input.LA(2);
            
            if ( (LA31_29 == '=') )
            {
                alt31 = 68;
            }
            else 
            {
                alt31 = 69;}
            }
            break;
        case '/':
        	{
            alt31 = 70;
            }
            break;
        case '+':
        	{
            alt31 = 71;
            }
            break;
        case '*':
        	{
            alt31 = 72;
            }
            break;
        case '%':
        	{
            alt31 = 73;
            }
            break;
        case '|':
        	{
            alt31 = 74;
            }
            break;
        case '?':
        	{
            alt31 = 75;
            }
            break;
        case '#':
        	{
            alt31 = 76;
            }
            break;
        case '0':
        	{
            int LA31_37 = input.LA(2);
            
            if ( ((LA31_37 >= '0' && LA31_37 <= '9')) )
            {
                int LA31_98 = input.LA(3);
                
                if ( ((LA31_98 >= '0' && LA31_98 <= '9')) )
                {
                    int LA31_154 = input.LA(4);
                    
                    if ( ((LA31_154 >= '0' && LA31_154 <= '9')) )
                    {
                        int LA31_206 = input.LA(5);
                        
                        if ( (LA31_206 == '-') )
                        {
                            alt31 = 77;
                        }
                        else 
                        {
                            alt31 = 78;}
                    }
                    else 
                    {
                        alt31 = 78;}
                }
                else 
                {
                    alt31 = 78;}
            }
            else 
            {
                alt31 = 78;}
            }
            break;
        case '1':
        case '2':
        case '3':
        case '4':
        case '5':
        case '6':
        case '7':
        case '8':
        case '9':
        	{
            int LA31_38 = input.LA(2);
            
            if ( ((LA31_38 >= '0' && LA31_38 <= '9')) )
            {
                int LA31_98 = input.LA(3);
                
                if ( ((LA31_98 >= '0' && LA31_98 <= '9')) )
                {
                    int LA31_154 = input.LA(4);
                    
                    if ( ((LA31_154 >= '0' && LA31_154 <= '9')) )
                    {
                        int LA31_206 = input.LA(5);
                        
                        if ( (LA31_206 == '-') )
                        {
                            alt31 = 77;
                        }
                        else 
                        {
                            alt31 = 78;}
                    }
                    else 
                    {
                        alt31 = 78;}
                }
                else 
                {
                    alt31 = 78;}
            }
            else 
            {
                alt31 = 78;}
            }
            break;
        case 'k':
        case 'p':
        case 'q':
        case 'x':
        case 'z':
        	{
            alt31 = 79;
            }
            break;
        case '\"':
        case '[':
        case '`':
        	{
            alt31 = 80;
            }
            break;
        case ':':
        	{
            int LA31_41 = input.LA(2);
            
            if ( ((LA31_41 >= 'a' && LA31_41 <= 'z')) )
            {
                alt31 = 81;
            }
            else 
            {
                alt31 = 85;}
            }
            break;
        case '\'':
        	{
            alt31 = 82;
            }
            break;
        case '-':
        	{
            alt31 = 84;
            }
            break;
        case '@':
        	{
            alt31 = 81;
            }
            break;
        case '\t':
        case '\n':
        case '\r':
        case ' ':
        	{
            alt31 = 86;
            }
            break;
        	default:
        	    if ( backtracking > 0 ) {failed = true; return ;}
        	    NoViableAltException nvae_d31s0 =
        	        new NoViableAltException("1:1: Tokens : ( ALL | AND | ANY | AS | ASC | BETWEEN | BY | CASE | CAST | CROSS | DAY | DEFAULT | DELETE | DESC | DISTINCT | ELSE | END | ESCAPE | EXISTS | EXTRACT | FOR | FROM | FULL | GROUP | HAVING | HOUR | IN | INNER | INSERT | INTERVAL | INTO | IS | JOIN | LEFT | LIKE | MINUTE | MONTH | NOT | NULL | ON | OR | ORDER | OUTER | RIGHT | SECOND | SELECT | SET | SOME | SUBSTRING | THEN | TOP | UNION | UPDATE | VALUES | WHEN | WHERE | YEAR | DOT_STAR | DOT | COMMA | LPAREN | RPAREN | ASSIGNEQUAL | NOTEQUAL1 | NOTEQUAL2 | LESSTHANOREQUALTO1 | LESSTHAN | GREATERTHANOREQUALTO1 | GREATERTHAN | DIVIDE | PLUS | STAR | MOD | STRCONCAT | PLACEHOLDER | MAccessDateTime | Iso8601DateTime | Number | NonQuotedIdentifier | QuotedIdentifier | Variable | AsciiStringLiteral | UnicodeStringLiteral | MINUS | COLON | Whitespace );", 31, 0, input);
        
        	    throw nvae_d31s0;
        }
        
        switch (alt31) 
        {
            case 1 :
                // MacroScope\\MacroScope.g:1:10: ALL
                {
                	mALL(); if (failed) return ;
                
                }
                break;
            case 2 :
                // MacroScope\\MacroScope.g:1:14: AND
                {
                	mAND(); if (failed) return ;
                
                }
                break;
            case 3 :
                // MacroScope\\MacroScope.g:1:18: ANY
                {
                	mANY(); if (failed) return ;
                
                }
                break;
            case 4 :
                // MacroScope\\MacroScope.g:1:22: AS
                {
                	mAS(); if (failed) return ;
                
                }
                break;
            case 5 :
                // MacroScope\\MacroScope.g:1:25: ASC
                {
                	mASC(); if (failed) return ;
                
                }
                break;
            case 6 :
                // MacroScope\\MacroScope.g:1:29: BETWEEN
                {
                	mBETWEEN(); if (failed) return ;
                
                }
                break;
            case 7 :
                // MacroScope\\MacroScope.g:1:37: BY
                {
                	mBY(); if (failed) return ;
                
                }
                break;
            case 8 :
                // MacroScope\\MacroScope.g:1:40: CASE
                {
                	mCASE(); if (failed) return ;
                
                }
                break;
            case 9 :
                // MacroScope\\MacroScope.g:1:45: CAST
                {
                	mCAST(); if (failed) return ;
                
                }
                break;
            case 10 :
                // MacroScope\\MacroScope.g:1:50: CROSS
                {
                	mCROSS(); if (failed) return ;
                
                }
                break;
            case 11 :
                // MacroScope\\MacroScope.g:1:56: DAY
                {
                	mDAY(); if (failed) return ;
                
                }
                break;
            case 12 :
                // MacroScope\\MacroScope.g:1:60: DEFAULT
                {
                	mDEFAULT(); if (failed) return ;
                
                }
                break;
            case 13 :
                // MacroScope\\MacroScope.g:1:68: DELETE
                {
                	mDELETE(); if (failed) return ;
                
                }
                break;
            case 14 :
                // MacroScope\\MacroScope.g:1:75: DESC
                {
                	mDESC(); if (failed) return ;
                
                }
                break;
            case 15 :
                // MacroScope\\MacroScope.g:1:80: DISTINCT
                {
                	mDISTINCT(); if (failed) return ;
                
                }
                break;
            case 16 :
                // MacroScope\\MacroScope.g:1:89: ELSE
                {
                	mELSE(); if (failed) return ;
                
                }
                break;
            case 17 :
                // MacroScope\\MacroScope.g:1:94: END
                {
                	mEND(); if (failed) return ;
                
                }
                break;
            case 18 :
                // MacroScope\\MacroScope.g:1:98: ESCAPE
                {
                	mESCAPE(); if (failed) return ;
                
                }
                break;
            case 19 :
                // MacroScope\\MacroScope.g:1:105: EXISTS
                {
                	mEXISTS(); if (failed) return ;
                
                }
                break;
            case 20 :
                // MacroScope\\MacroScope.g:1:112: EXTRACT
                {
                	mEXTRACT(); if (failed) return ;
                
                }
                break;
            case 21 :
                // MacroScope\\MacroScope.g:1:120: FOR
                {
                	mFOR(); if (failed) return ;
                
                }
                break;
            case 22 :
                // MacroScope\\MacroScope.g:1:124: FROM
                {
                	mFROM(); if (failed) return ;
                
                }
                break;
            case 23 :
                // MacroScope\\MacroScope.g:1:129: FULL
                {
                	mFULL(); if (failed) return ;
                
                }
                break;
            case 24 :
                // MacroScope\\MacroScope.g:1:134: GROUP
                {
                	mGROUP(); if (failed) return ;
                
                }
                break;
            case 25 :
                // MacroScope\\MacroScope.g:1:140: HAVING
                {
                	mHAVING(); if (failed) return ;
                
                }
                break;
            case 26 :
                // MacroScope\\MacroScope.g:1:147: HOUR
                {
                	mHOUR(); if (failed) return ;
                
                }
                break;
            case 27 :
                // MacroScope\\MacroScope.g:1:152: IN
                {
                	mIN(); if (failed) return ;
                
                }
                break;
            case 28 :
                // MacroScope\\MacroScope.g:1:155: INNER
                {
                	mINNER(); if (failed) return ;
                
                }
                break;
            case 29 :
                // MacroScope\\MacroScope.g:1:161: INSERT
                {
                	mINSERT(); if (failed) return ;
                
                }
                break;
            case 30 :
                // MacroScope\\MacroScope.g:1:168: INTERVAL
                {
                	mINTERVAL(); if (failed) return ;
                
                }
                break;
            case 31 :
                // MacroScope\\MacroScope.g:1:177: INTO
                {
                	mINTO(); if (failed) return ;
                
                }
                break;
            case 32 :
                // MacroScope\\MacroScope.g:1:182: IS
                {
                	mIS(); if (failed) return ;
                
                }
                break;
            case 33 :
                // MacroScope\\MacroScope.g:1:185: JOIN
                {
                	mJOIN(); if (failed) return ;
                
                }
                break;
            case 34 :
                // MacroScope\\MacroScope.g:1:190: LEFT
                {
                	mLEFT(); if (failed) return ;
                
                }
                break;
            case 35 :
                // MacroScope\\MacroScope.g:1:195: LIKE
                {
                	mLIKE(); if (failed) return ;
                
                }
                break;
            case 36 :
                // MacroScope\\MacroScope.g:1:200: MINUTE
                {
                	mMINUTE(); if (failed) return ;
                
                }
                break;
            case 37 :
                // MacroScope\\MacroScope.g:1:207: MONTH
                {
                	mMONTH(); if (failed) return ;
                
                }
                break;
            case 38 :
                // MacroScope\\MacroScope.g:1:213: NOT
                {
                	mNOT(); if (failed) return ;
                
                }
                break;
            case 39 :
                // MacroScope\\MacroScope.g:1:217: NULL
                {
                	mNULL(); if (failed) return ;
                
                }
                break;
            case 40 :
                // MacroScope\\MacroScope.g:1:222: ON
                {
                	mON(); if (failed) return ;
                
                }
                break;
            case 41 :
                // MacroScope\\MacroScope.g:1:225: OR
                {
                	mOR(); if (failed) return ;
                
                }
                break;
            case 42 :
                // MacroScope\\MacroScope.g:1:228: ORDER
                {
                	mORDER(); if (failed) return ;
                
                }
                break;
            case 43 :
                // MacroScope\\MacroScope.g:1:234: OUTER
                {
                	mOUTER(); if (failed) return ;
                
                }
                break;
            case 44 :
                // MacroScope\\MacroScope.g:1:240: RIGHT
                {
                	mRIGHT(); if (failed) return ;
                
                }
                break;
            case 45 :
                // MacroScope\\MacroScope.g:1:246: SECOND
                {
                	mSECOND(); if (failed) return ;
                
                }
                break;
            case 46 :
                // MacroScope\\MacroScope.g:1:253: SELECT
                {
                	mSELECT(); if (failed) return ;
                
                }
                break;
            case 47 :
                // MacroScope\\MacroScope.g:1:260: SET
                {
                	mSET(); if (failed) return ;
                
                }
                break;
            case 48 :
                // MacroScope\\MacroScope.g:1:264: SOME
                {
                	mSOME(); if (failed) return ;
                
                }
                break;
            case 49 :
                // MacroScope\\MacroScope.g:1:269: SUBSTRING
                {
                	mSUBSTRING(); if (failed) return ;
                
                }
                break;
            case 50 :
                // MacroScope\\MacroScope.g:1:279: THEN
                {
                	mTHEN(); if (failed) return ;
                
                }
                break;
            case 51 :
                // MacroScope\\MacroScope.g:1:284: TOP
                {
                	mTOP(); if (failed) return ;
                
                }
                break;
            case 52 :
                // MacroScope\\MacroScope.g:1:288: UNION
                {
                	mUNION(); if (failed) return ;
                
                }
                break;
            case 53 :
                // MacroScope\\MacroScope.g:1:294: UPDATE
                {
                	mUPDATE(); if (failed) return ;
                
                }
                break;
            case 54 :
                // MacroScope\\MacroScope.g:1:301: VALUES
                {
                	mVALUES(); if (failed) return ;
                
                }
                break;
            case 55 :
                // MacroScope\\MacroScope.g:1:308: WHEN
                {
                	mWHEN(); if (failed) return ;
                
                }
                break;
            case 56 :
                // MacroScope\\MacroScope.g:1:313: WHERE
                {
                	mWHERE(); if (failed) return ;
                
                }
                break;
            case 57 :
                // MacroScope\\MacroScope.g:1:319: YEAR
                {
                	mYEAR(); if (failed) return ;
                
                }
                break;
            case 58 :
                // MacroScope\\MacroScope.g:1:324: DOT_STAR
                {
                	mDOT_STAR(); if (failed) return ;
                
                }
                break;
            case 59 :
                // MacroScope\\MacroScope.g:1:333: DOT
                {
                	mDOT(); if (failed) return ;
                
                }
                break;
            case 60 :
                // MacroScope\\MacroScope.g:1:337: COMMA
                {
                	mCOMMA(); if (failed) return ;
                
                }
                break;
            case 61 :
                // MacroScope\\MacroScope.g:1:343: LPAREN
                {
                	mLPAREN(); if (failed) return ;
                
                }
                break;
            case 62 :
                // MacroScope\\MacroScope.g:1:350: RPAREN
                {
                	mRPAREN(); if (failed) return ;
                
                }
                break;
            case 63 :
                // MacroScope\\MacroScope.g:1:357: ASSIGNEQUAL
                {
                	mASSIGNEQUAL(); if (failed) return ;
                
                }
                break;
            case 64 :
                // MacroScope\\MacroScope.g:1:369: NOTEQUAL1
                {
                	mNOTEQUAL1(); if (failed) return ;
                
                }
                break;
            case 65 :
                // MacroScope\\MacroScope.g:1:379: NOTEQUAL2
                {
                	mNOTEQUAL2(); if (failed) return ;
                
                }
                break;
            case 66 :
                // MacroScope\\MacroScope.g:1:389: LESSTHANOREQUALTO1
                {
                	mLESSTHANOREQUALTO1(); if (failed) return ;
                
                }
                break;
            case 67 :
                // MacroScope\\MacroScope.g:1:408: LESSTHAN
                {
                	mLESSTHAN(); if (failed) return ;
                
                }
                break;
            case 68 :
                // MacroScope\\MacroScope.g:1:417: GREATERTHANOREQUALTO1
                {
                	mGREATERTHANOREQUALTO1(); if (failed) return ;
                
                }
                break;
            case 69 :
                // MacroScope\\MacroScope.g:1:439: GREATERTHAN
                {
                	mGREATERTHAN(); if (failed) return ;
                
                }
                break;
            case 70 :
                // MacroScope\\MacroScope.g:1:451: DIVIDE
                {
                	mDIVIDE(); if (failed) return ;
                
                }
                break;
            case 71 :
                // MacroScope\\MacroScope.g:1:458: PLUS
                {
                	mPLUS(); if (failed) return ;
                
                }
                break;
            case 72 :
                // MacroScope\\MacroScope.g:1:463: STAR
                {
                	mSTAR(); if (failed) return ;
                
                }
                break;
            case 73 :
                // MacroScope\\MacroScope.g:1:468: MOD
                {
                	mMOD(); if (failed) return ;
                
                }
                break;
            case 74 :
                // MacroScope\\MacroScope.g:1:472: STRCONCAT
                {
                	mSTRCONCAT(); if (failed) return ;
                
                }
                break;
            case 75 :
                // MacroScope\\MacroScope.g:1:482: PLACEHOLDER
                {
                	mPLACEHOLDER(); if (failed) return ;
                
                }
                break;
            case 76 :
                // MacroScope\\MacroScope.g:1:494: MAccessDateTime
                {
                	mMAccessDateTime(); if (failed) return ;
                
                }
                break;
            case 77 :
                // MacroScope\\MacroScope.g:1:510: Iso8601DateTime
                {
                	mIso8601DateTime(); if (failed) return ;
                
                }
                break;
            case 78 :
                // MacroScope\\MacroScope.g:1:526: Number
                {
                	mNumber(); if (failed) return ;
                
                }
                break;
            case 79 :
                // MacroScope\\MacroScope.g:1:533: NonQuotedIdentifier
                {
                	mNonQuotedIdentifier(); if (failed) return ;
                
                }
                break;
            case 80 :
                // MacroScope\\MacroScope.g:1:553: QuotedIdentifier
                {
                	mQuotedIdentifier(); if (failed) return ;
                
                }
                break;
            case 81 :
                // MacroScope\\MacroScope.g:1:570: Variable
                {
                	mVariable(); if (failed) return ;
                
                }
                break;
            case 82 :
                // MacroScope\\MacroScope.g:1:579: AsciiStringLiteral
                {
                	mAsciiStringLiteral(); if (failed) return ;
                
                }
                break;
            case 83 :
                // MacroScope\\MacroScope.g:1:598: UnicodeStringLiteral
                {
                	mUnicodeStringLiteral(); if (failed) return ;
                
                }
                break;
            case 84 :
                // MacroScope\\MacroScope.g:1:619: MINUS
                {
                	mMINUS(); if (failed) return ;
                
                }
                break;
            case 85 :
                // MacroScope\\MacroScope.g:1:625: COLON
                {
                	mCOLON(); if (failed) return ;
                
                }
                break;
            case 86 :
                // MacroScope\\MacroScope.g:1:631: Whitespace
                {
                	mWhitespace(); if (failed) return ;
                
                }
                break;
        
        }
    
    }

    // $ANTLR start synpred1
    public void synpred1_fragment() //throws RecognitionException
    {   
        // MacroScope\\MacroScope.g:913:2: ( ( Digit )+ ( '.' | 'e' ) )
        // MacroScope\\MacroScope.g:913:4: ( Digit )+ ( '.' | 'e' )
        {
        	// MacroScope\\MacroScope.g:913:4: ( Digit )+
        	int cnt32 = 0;
        	do 
        	{
        	    int alt32 = 2;
        	    int LA32_0 = input.LA(1);
        	    
        	    if ( ((LA32_0 >= '0' && LA32_0 <= '9')) )
        	    {
        	        alt32 = 1;
        	    }
        	    
        	
        	    switch (alt32) 
        		{
        			case 1 :
        			    // MacroScope\\MacroScope.g:913:5: Digit
        			    {
        			    	mDigit(); if (failed) return ;
        			    
        			    }
        			    break;
        	
        			default:
        			    if ( cnt32 >= 1 ) goto loop32;
        			    if ( backtracking > 0 ) {failed = true; return ;}
        		            EarlyExitException eee =
        		                new EarlyExitException(32, input);
        		            throw eee;
        	    }
        	    cnt32++;
        	} while (true);
        	
        	loop32:
        		;	// Stops C# compiler whinging that label 'loop32' has no statements

        	if ( input.LA(1) == '.' || input.LA(1) == 'e' ) 
        	{
        	    input.Consume();
        	failed = false;
        	}
        	else 
        	{
        	    if ( backtracking > 0 ) {failed = true; return ;}
        	    MismatchedSetException mse =
        	        new MismatchedSetException(null,input);
        	    Recover(mse);    throw mse;
        	}

        
        }
    }
    // $ANTLR end synpred1

   	public bool synpred1() 
   	{
   	    backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred1_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !failed;
   	    input.Rewind(start);
   	    backtracking--;
   	    failed = false;
   	    return success;
   	}


    protected DFA12 dfa12;
	private void InitializeCyclicDFAs()
	{
	    this.dfa12 = new DFA12(this);
	    this.dfa12.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA12_SpecialStateTransition);
	}

    static readonly short[] DFA12_eot = {
        -1, 5, -1, 5, -1, -1, -1, -1
        };
    static readonly short[] DFA12_eof = {
        -1, -1, -1, -1, -1, -1, -1, -1
        };
    static readonly int[] DFA12_min = {
        46, 46, 0, 46, 0, 0, 0, 0
        };
    static readonly int[] DFA12_max = {
        57, 120, 0, 101, 0, 0, 0, 0
        };
    static readonly short[] DFA12_accept = {
        -1, -1, 2, -1, 4, 3, 1, 1
        };
    static readonly short[] DFA12_special = {
        -1, 1, -1, 0, -1, -1, -1, -1
        };
    
    static readonly short[] dfa12_transition_null = null;

    static readonly short[] dfa12_transition0 = {
    	2, -1, 1, 3, 3, 3, 3, 3, 3, 3, 3, 3
    	};
    static readonly short[] dfa12_transition1 = {
    	6, -1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, -1, -1, -1, -1, -1, -1, -1, -1, 
    	    -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 
    	    -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 
    	    -1, -1, -1, 7
    	};
    static readonly short[] dfa12_transition2 = {
    	6, -1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, -1, -1, -1, -1, -1, -1, -1, -1, 
    	    -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 
    	    -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 
    	    -1, -1, -1, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 
    	    -1, -1, -1, -1, -1, -1, 4
    	};
    
    static readonly short[][] DFA12_transition = {
    	dfa12_transition0,
    	dfa12_transition2,
    	dfa12_transition_null,
    	dfa12_transition1,
    	dfa12_transition_null,
    	dfa12_transition_null,
    	dfa12_transition_null,
    	dfa12_transition_null
        };
    
    protected class DFA12 : DFA
    {
        public DFA12(BaseRecognizer recognizer) 
        {
            this.recognizer = recognizer;
            this.decisionNumber = 12;
            this.eot = DFA12_eot;
            this.eof = DFA12_eof;
            this.min = DFA12_min;
            this.max = DFA12_max;
            this.accept     = DFA12_accept;
            this.special    = DFA12_special;
            this.transition = DFA12_transition;
        }
    
        override public string Description
        {
            get { return "912:1: Number : ( ( ( Digit )+ ( '.' | 'e' ) )=> ( Digit )+ ( '.' ( Digit )* ( Exponent )? | Exponent ) | '.' ( ( Digit )+ ( Exponent )? )? | ( Digit )+ | '0x' ( 'a' .. 'f' | Digit )* );"; }
        }
    
    }
    
    
    protected internal int DFA12_SpecialStateTransition(DFA dfa, int s, IIntStream input) //throws NoViableAltException
    {
    	int _s = s;
        switch ( s )
        {

               	case 0 : 
                   	int LA12_3 = input.LA(1);
                   	
                   	 
                   	int index12_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( ((LA12_3 >= '0' && LA12_3 <= '9')) ) { s = 3; }

                   	else if ( (LA12_3 == '.') && (synpred1()) ) { s = 6; }

                   	else if ( (LA12_3 == 'e') && (synpred1()) ) { s = 7; }

                   	else s = 5;
                   	
                   	 
                   	input.Seek(index12_3);
                   	if ( s >= 0 ) return s;
                   	break;

               	case 1 : 
                   	int LA12_1 = input.LA(1);
                   	
                   	 
                   	int index12_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA12_1 == 'x') ) { s = 4; }

                   	else if ( ((LA12_1 >= '0' && LA12_1 <= '9')) ) { s = 3; }

                   	else if ( (LA12_1 == '.') && (synpred1()) ) { s = 6; }

                   	else if ( (LA12_1 == 'e') && (synpred1()) ) { s = 7; }

                   	else s = 5;
                   	
                   	 
                   	input.Seek(index12_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (backtracking > 0) {failed = true; return -1;}
        NoViableAltException nvae =
            new NoViableAltException(dfa.Description, 12, _s, input);
        dfa.Error(nvae);
        throw nvae;
    }
 
    
}
}