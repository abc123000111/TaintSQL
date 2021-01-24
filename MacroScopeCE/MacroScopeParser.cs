// $ANTLR 3.0.1 MacroScope\\MacroScope.g 2008-01-12 20:02:54
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


public class MacroScopeParser : Parser 
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"INSERT", 
		"INTO", 
		"LPAREN", 
		"RPAREN", 
		"VALUES", 
		"UPDATE", 
		"SET", 
		"DELETE", 
		"FROM", 
		"COMMA", 
		"ASSIGNEQUAL", 
		"DEFAULT", 
		"SELECT", 
		"ALL", 
		"DISTINCT", 
		"TOP", 
		"Integer", 
		"WHERE", 
		"ORDER", 
		"BY", 
		"ASC", 
		"DESC", 
		"GROUP", 
		"HAVING", 
		"OR", 
		"AND", 
		"NOT", 
		"IS", 
		"NULL", 
		"LIKE", 
		"ESCAPE", 
		"BETWEEN", 
		"IN", 
		"EXISTS", 
		"SOME", 
		"ANY", 
		"STAR", 
		"INNER", 
		"LEFT", 
		"RIGHT", 
		"FULL", 
		"OUTER", 
		"JOIN", 
		"CROSS", 
		"ON", 
		"AS", 
		"DOT_STAR", 
		"PLACEHOLDER", 
		"Variable", 
		"SUBSTRING", 
		"FOR", 
		"EXTRACT", 
		"NonQuotedIdentifier", 
		"CASE", 
		"WHEN", 
		"THEN", 
		"ELSE", 
		"END", 
		"CAST", 
		"DOT", 
		"UnicodeStringLiteral", 
		"AsciiStringLiteral", 
		"QuotedIdentifier", 
		"Real", 
		"HexLiteral", 
		"MAccessDateTime", 
		"Iso8601DateTime", 
		"INTERVAL", 
		"PLUS", 
		"MINUS", 
		"STRCONCAT", 
		"DIVIDE", 
		"MOD", 
		"NOTEQUAL1", 
		"NOTEQUAL2", 
		"LESSTHANOREQUALTO1", 
		"LESSTHAN", 
		"GREATERTHANOREQUALTO1", 
		"GREATERTHAN", 
		"UNION", 
		"YEAR", 
		"MONTH", 
		"DAY", 
		"HOUR", 
		"MINUTE", 
		"SECOND", 
		"Letter", 
		"Digit", 
		"Exponent", 
		"Number", 
		"WordTail", 
		"AsciiStringRun", 
		"UnicodeStringRun", 
		"COLON", 
		"Whitespace"
    };

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
    public const int FROM = 12;
    public const int END = 61;
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
    
    
        public MacroScopeParser(ITokenStream input) 
    		: base(input)
    	{
    		InitializeCyclicDFAs();
            ruleMemo = new IDictionary[70+1];
         }
        

    override public string[] TokenNames
	{
		get { return tokenNames; }
	}

    override public string GrammarFileName
	{
		get { return "MacroScope\\MacroScope.g"; }
	}


    
    // $ANTLR start statement
    // MacroScope\\MacroScope.g:27:1: statement returns [ IStatement value ] : (i= insertStatement EOF | s= selectStatement EOF | u= updateStatement EOF | d= deleteStatement EOF );
    public IStatement statement() // throws RecognitionException [1]
    {   

        IStatement value = null;
    
        InsertStatement i = null;

        SelectStatement s = null;

        UpdateStatement u = null;

        DeleteStatement d = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:27:40: (i= insertStatement EOF | s= selectStatement EOF | u= updateStatement EOF | d= deleteStatement EOF )
            int alt1 = 4;
            switch ( input.LA(1) ) 
            {
            case INSERT:
            	{
                alt1 = 1;
                }
                break;
            case LPAREN:
            case SELECT:
            	{
                alt1 = 2;
                }
                break;
            case UPDATE:
            	{
                alt1 = 3;
                }
                break;
            case DELETE:
            	{
                alt1 = 4;
                }
                break;
            	default:
            	    if ( backtracking > 0 ) {failed = true; return value;}
            	    NoViableAltException nvae_d1s0 =
            	        new NoViableAltException("27:1: statement returns [ IStatement value ] : (i= insertStatement EOF | s= selectStatement EOF | u= updateStatement EOF | d= deleteStatement EOF );", 1, 0, input);
            
            	    throw nvae_d1s0;
            }
            
            switch (alt1) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:28:2: i= insertStatement EOF
                    {
                    	PushFollow(FOLLOW_insertStatement_in_statement66);
                    	i = insertStatement();
                    	followingStackPointer_--;
                    	if (failed) return value;
                    	Match(input,EOF,FOLLOW_EOF_in_statement68); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  i; 
                    	}
                    
                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:29:4: s= selectStatement EOF
                    {
                    	PushFollow(FOLLOW_selectStatement_in_statement79);
                    	s = selectStatement();
                    	followingStackPointer_--;
                    	if (failed) return value;
                    	Match(input,EOF,FOLLOW_EOF_in_statement81); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  s; 
                    	}
                    
                    }
                    break;
                case 3 :
                    // MacroScope\\MacroScope.g:30:4: u= updateStatement EOF
                    {
                    	PushFollow(FOLLOW_updateStatement_in_statement92);
                    	u = updateStatement();
                    	followingStackPointer_--;
                    	if (failed) return value;
                    	Match(input,EOF,FOLLOW_EOF_in_statement94); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  u; 
                    	}
                    
                    }
                    break;
                case 4 :
                    // MacroScope\\MacroScope.g:31:4: d= deleteStatement EOF
                    {
                    	PushFollow(FOLLOW_deleteStatement_in_statement105);
                    	d = deleteStatement();
                    	followingStackPointer_--;
                    	if (failed) return value;
                    	Match(input,EOF,FOLLOW_EOF_in_statement107); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  d; 
                    	}
                    
                    }
                    break;
            
            }
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end statement

    
    // $ANTLR start insertStatement
    // MacroScope\\MacroScope.g:34:1: insertStatement returns [ InsertStatement value ] : INSERT ( INTO )? o= dbObject LPAREN c= columnNameList RPAREN VALUES LPAREN e= columnValueList RPAREN ;
    public InsertStatement insertStatement() // throws RecognitionException [1]
    {   

        InsertStatement value = null;
    
        DbObject o = null;

        AliasedItem c = null;

        ExpressionItem e = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:34:51: ( INSERT ( INTO )? o= dbObject LPAREN c= columnNameList RPAREN VALUES LPAREN e= columnValueList RPAREN )
            // MacroScope\\MacroScope.g:36:2: INSERT ( INTO )? o= dbObject LPAREN c= columnNameList RPAREN VALUES LPAREN e= columnValueList RPAREN
            {
            	Match(input,INSERT,FOLLOW_INSERT_in_insertStatement126); if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  new InsertStatement(); 
            	}
            	// MacroScope\\MacroScope.g:36:45: ( INTO )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);
            	
            	if ( (LA2_0 == INTO) )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:36:47: INTO
            	        {
            	        	Match(input,INTO,FOLLOW_INTO_in_insertStatement132); if (failed) return value;
            	        
            	        }
            	        break;
            	
            	}

            	PushFollow(FOLLOW_dbObject_in_insertStatement143);
            	o = dbObject();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	  
            	  			value.Table = o;
            	  		
            	}
            	Match(input,LPAREN,FOLLOW_LPAREN_in_insertStatement155); if (failed) return value;
            	PushFollow(FOLLOW_columnNameList_in_insertStatement161);
            	c = columnNameList();
            	followingStackPointer_--;
            	if (failed) return value;
            	Match(input,RPAREN,FOLLOW_RPAREN_in_insertStatement163); if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	  
            	  			value.ColumnNames = c;
            	  		
            	}
            	Match(input,VALUES,FOLLOW_VALUES_in_insertStatement169); if (failed) return value;
            	Match(input,LPAREN,FOLLOW_LPAREN_in_insertStatement171); if (failed) return value;
            	PushFollow(FOLLOW_columnValueList_in_insertStatement177);
            	e = columnValueList();
            	followingStackPointer_--;
            	if (failed) return value;
            	Match(input,RPAREN,FOLLOW_RPAREN_in_insertStatement179); if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	  
            	  			value.ColumnValues = e;
            	  		
            	}
            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end insertStatement

    
    // $ANTLR start selectStatement
    // MacroScope\\MacroScope.g:52:1: selectStatement returns [ SelectStatement value ] : q= queryExpression ;
    public SelectStatement selectStatement() // throws RecognitionException [1]
    {   

        SelectStatement value = null;
    
        QueryExpression q = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:52:51: (q= queryExpression )
            // MacroScope\\MacroScope.g:53:2: q= queryExpression
            {
            	PushFollow(FOLLOW_queryExpression_in_selectStatement206);
            	q = queryExpression();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  new SelectStatement(q); 
            	}
            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end selectStatement

    
    // $ANTLR start updateStatement
    // MacroScope\\MacroScope.g:56:1: updateStatement returns [ UpdateStatement value ] : UPDATE o= dbObject SET a= assignmentList (w= whereClause )? ;
    public UpdateStatement updateStatement() // throws RecognitionException [1]
    {   

        UpdateStatement value = null;
    
        DbObject o = null;

        Assignment a = null;

        IExpression w = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:56:51: ( UPDATE o= dbObject SET a= assignmentList (w= whereClause )? )
            // MacroScope\\MacroScope.g:58:2: UPDATE o= dbObject SET a= assignmentList (w= whereClause )?
            {
            	Match(input,UPDATE,FOLLOW_UPDATE_in_updateStatement225); if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  new UpdateStatement(); 
            	}
            	PushFollow(FOLLOW_dbObject_in_updateStatement235);
            	o = dbObject();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value.Table = o; 
            	}
            	Match(input,SET,FOLLOW_SET_in_updateStatement241); if (failed) return value;
            	PushFollow(FOLLOW_assignmentList_in_updateStatement247);
            	a = assignmentList();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	  
            	  			value.Assignments = a;
            	  		
            	}
            	// MacroScope\\MacroScope.g:64:3: (w= whereClause )?
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);
            	
            	if ( (LA3_0 == WHERE) )
            	{
            	    alt3 = 1;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:65:4: w= whereClause
            	        {
            	        	PushFollow(FOLLOW_whereClause_in_updateStatement266);
            	        	w = whereClause();
            	        	followingStackPointer_--;
            	        	if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	   value.Where = w; 
            	        	}
            	        
            	        }
            	        break;
            	
            	}

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end updateStatement

    
    // $ANTLR start deleteStatement
    // MacroScope\\MacroScope.g:70:1: deleteStatement returns [ DeleteStatement value ] : DELETE ( FROM )? o= dbObject (w= whereClause )? ;
    public DeleteStatement deleteStatement() // throws RecognitionException [1]
    {   

        DeleteStatement value = null;
    
        DbObject o = null;

        IExpression w = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:70:51: ( DELETE ( FROM )? o= dbObject (w= whereClause )? )
            // MacroScope\\MacroScope.g:72:2: DELETE ( FROM )? o= dbObject (w= whereClause )?
            {
            	Match(input,DELETE,FOLLOW_DELETE_in_deleteStatement293); if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  new DeleteStatement(); 
            	}
            	// MacroScope\\MacroScope.g:72:45: ( FROM )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);
            	
            	if ( (LA4_0 == FROM) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:72:47: FROM
            	        {
            	        	Match(input,FROM,FOLLOW_FROM_in_deleteStatement299); if (failed) return value;
            	        
            	        }
            	        break;
            	
            	}

            	PushFollow(FOLLOW_dbObject_in_deleteStatement310);
            	o = dbObject();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value.Table = o; 
            	}
            	// MacroScope\\MacroScope.g:74:3: (w= whereClause )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);
            	
            	if ( (LA5_0 == WHERE) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:75:4: w= whereClause
            	        {
            	        	PushFollow(FOLLOW_whereClause_in_deleteStatement326);
            	        	w = whereClause();
            	        	followingStackPointer_--;
            	        	if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	   value.Where = w; 
            	        	}
            	        
            	        }
            	        break;
            	
            	}

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end deleteStatement

    
    // $ANTLR start assignmentList
    // MacroScope\\MacroScope.g:80:1: assignmentList returns [ Assignment value ] : a= assignment ( COMMA a= assignment )* ;
    public Assignment assignmentList() // throws RecognitionException [1]
    {   

        Assignment value = null;
    
        Assignment a = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:80:45: (a= assignment ( COMMA a= assignment )* )
            // MacroScope\\MacroScope.g:81:2: a= assignment ( COMMA a= assignment )*
            {
            	PushFollow(FOLLOW_assignment_in_assignmentList356);
            	a = assignment();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	  
            	  		value =  a;
            	  	
            	}
            	// MacroScope\\MacroScope.g:83:4: ( COMMA a= assignment )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);
            	    
            	    if ( (LA6_0 == COMMA) )
            	    {
            	        alt6 = 1;
            	    }
            	    
            	
            	    switch (alt6) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:83:6: COMMA a= assignment
            			    {
            			    	Match(input,COMMA,FOLLOW_COMMA_in_assignmentList362); if (failed) return value;
            			    	PushFollow(FOLLOW_assignment_in_assignmentList368);
            			    	a = assignment();
            			    	followingStackPointer_--;
            			    	if (failed) return value;
            			    	if ( backtracking == 0 ) 
            			    	{
            			    	  
            			    	  			value.Add(a);
            			    	  		
            			    	}
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop6;
            	    }
            	} while (true);
            	
            	loop6:
            		;	// Stops C# compiler whinging that label 'loop6' has no statements

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end assignmentList

    
    // $ANTLR start assignment
    // MacroScope\\MacroScope.g:88:1: assignment returns [ Assignment value ] : c= column ASSIGNEQUAL v= columnValue ;
    public Assignment assignment() // throws RecognitionException [1]
    {   

        Assignment value = null;
    
        DbObject c = null;

        INode v = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:88:41: (c= column ASSIGNEQUAL v= columnValue )
            // MacroScope\\MacroScope.g:89:2: c= column ASSIGNEQUAL v= columnValue
            {
            	PushFollow(FOLLOW_column_in_assignment392);
            	c = column();
            	followingStackPointer_--;
            	if (failed) return value;
            	Match(input,ASSIGNEQUAL,FOLLOW_ASSIGNEQUAL_in_assignment394); if (failed) return value;
            	PushFollow(FOLLOW_columnValue_in_assignment400);
            	v = columnValue();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	  
            	  		value =  new Assignment(c, v);
            	  	
            	}
            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end assignment

    
    // $ANTLR start columnNameList
    // MacroScope\\MacroScope.g:94:1: columnNameList returns [ AliasedItem value ] : c= column ( COMMA c= column )* ;
    public AliasedItem columnNameList() // throws RecognitionException [1]
    {   

        AliasedItem value = null;
    
        DbObject c = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:94:46: (c= column ( COMMA c= column )* )
            // MacroScope\\MacroScope.g:95:2: c= column ( COMMA c= column )*
            {
            	PushFollow(FOLLOW_column_in_columnNameList421);
            	c = column();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  new AliasedItem(c); 
            	}
            	// MacroScope\\MacroScope.g:96:3: ( COMMA c= column )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);
            	    
            	    if ( (LA7_0 == COMMA) )
            	    {
            	        alt7 = 1;
            	    }
            	    
            	
            	    switch (alt7) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:96:5: COMMA c= column
            			    {
            			    	Match(input,COMMA,FOLLOW_COMMA_in_columnNameList429); if (failed) return value;
            			    	PushFollow(FOLLOW_column_in_columnNameList435);
            			    	c = column();
            			    	followingStackPointer_--;
            			    	if (failed) return value;
            			    	if ( backtracking == 0 ) 
            			    	{
            			    	  
            			    	  			value.Add(new AliasedItem(c));
            			    	  		
            			    	}
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop7;
            	    }
            	} while (true);
            	
            	loop7:
            		;	// Stops C# compiler whinging that label 'loop7' has no statements

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end columnNameList

    
    // $ANTLR start columnValueList
    // MacroScope\\MacroScope.g:101:1: columnValueList returns [ ExpressionItem value ] : v= columnValue ( COMMA v= columnValue )* ;
    public ExpressionItem columnValueList() // throws RecognitionException [1]
    {   

        ExpressionItem value = null;
    
        INode v = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:101:50: (v= columnValue ( COMMA v= columnValue )* )
            // MacroScope\\MacroScope.g:102:2: v= columnValue ( COMMA v= columnValue )*
            {
            	PushFollow(FOLLOW_columnValue_in_columnValueList459);
            	v = columnValue();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	  
            	  		value =  new ExpressionItem(v);
            	  	
            	}
            	// MacroScope\\MacroScope.g:104:4: ( COMMA v= columnValue )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);
            	    
            	    if ( (LA8_0 == COMMA) )
            	    {
            	        alt8 = 1;
            	    }
            	    
            	
            	    switch (alt8) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:104:6: COMMA v= columnValue
            			    {
            			    	Match(input,COMMA,FOLLOW_COMMA_in_columnValueList465); if (failed) return value;
            			    	PushFollow(FOLLOW_columnValue_in_columnValueList471);
            			    	v = columnValue();
            			    	followingStackPointer_--;
            			    	if (failed) return value;
            			    	if ( backtracking == 0 ) 
            			    	{
            			    	  
            			    	  			value.Add(new ExpressionItem(v));
            			    	  		
            			    	}
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop8;
            	    }
            	} while (true);
            	
            	loop8:
            		;	// Stops C# compiler whinging that label 'loop8' has no statements

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end columnValueList

    
    // $ANTLR start columnValue
    // MacroScope\\MacroScope.g:109:1: columnValue returns [ INode value ] : ( DEFAULT | e= expression );
    public INode columnValue() // throws RecognitionException [1]
    {   

        INode value = null;
    
        IExpression e = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:109:37: ( DEFAULT | e= expression )
            int alt9 = 2;
            int LA9_0 = input.LA(1);
            
            if ( (LA9_0 == DEFAULT) )
            {
                alt9 = 1;
            }
            else if ( (LA9_0 == LPAREN || LA9_0 == Integer || LA9_0 == NULL || (LA9_0 >= LEFT && LA9_0 <= RIGHT) || (LA9_0 >= PLACEHOLDER && LA9_0 <= SUBSTRING) || (LA9_0 >= EXTRACT && LA9_0 <= CASE) || LA9_0 == CAST || (LA9_0 >= UnicodeStringLiteral && LA9_0 <= MINUS)) )
            {
                alt9 = 2;
            }
            else 
            {
                if ( backtracking > 0 ) {failed = true; return value;}
                NoViableAltException nvae_d9s0 =
                    new NoViableAltException("109:1: columnValue returns [ INode value ] : ( DEFAULT | e= expression );", 9, 0, input);
            
                throw nvae_d9s0;
            }
            switch (alt9) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:110:2: DEFAULT
                    {
                    	Match(input,DEFAULT,FOLLOW_DEFAULT_in_columnValue491); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  DefaultValue.Value; 
                    	}
                    
                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:111:4: e= expression
                    {
                    	PushFollow(FOLLOW_expression_in_columnValue502);
                    	e = expression();
                    	followingStackPointer_--;
                    	if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  e; 
                    	}
                    
                    }
                    break;
            
            }
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end columnValue

    
    // $ANTLR start queryExpression
    // MacroScope\\MacroScope.g:114:1: queryExpression returns [ QueryExpression value ] : s= subQueryExpression (u= unionOperator s= subQueryExpression )* (o= orderByClause )? ;
    public QueryExpression queryExpression() // throws RecognitionException [1]
    {   

        QueryExpression value = null;
    
        QueryExpression s = null;

        bool u = false;

        OrderExpression o = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:114:51: (s= subQueryExpression (u= unionOperator s= subQueryExpression )* (o= orderByClause )? )
            // MacroScope\\MacroScope.g:115:2: s= subQueryExpression (u= unionOperator s= subQueryExpression )* (o= orderByClause )?
            {
            	PushFollow(FOLLOW_subQueryExpression_in_queryExpression523);
            	s = subQueryExpression();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  s; 
            	}
            	// MacroScope\\MacroScope.g:116:2: (u= unionOperator s= subQueryExpression )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);
            	    
            	    if ( (LA10_0 == UNION) )
            	    {
            	        alt10 = 1;
            	    }
            	    
            	
            	    switch (alt10) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:116:4: u= unionOperator s= subQueryExpression
            			    {
            			    	PushFollow(FOLLOW_unionOperator_in_queryExpression535);
            			    	u = unionOperator();
            			    	followingStackPointer_--;
            			    	if (failed) return value;
            			    	PushFollow(FOLLOW_subQueryExpression_in_queryExpression543);
            			    	s = subQueryExpression();
            			    	followingStackPointer_--;
            			    	if (failed) return value;
            			    	if ( backtracking == 0 ) 
            			    	{
            			    	  
            			    	  			s.All = u;
            			    	  			value.Add(s);
            			    	  		
            			    	}
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop10;
            	    }
            	} while (true);
            	
            	loop10:
            		;	// Stops C# compiler whinging that label 'loop10' has no statements

            	// MacroScope\\MacroScope.g:122:2: (o= orderByClause )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);
            	
            	if ( (LA11_0 == ORDER) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:122:4: o= orderByClause
            	        {
            	        	PushFollow(FOLLOW_orderByClause_in_queryExpression558);
            	        	o = orderByClause();
            	        	followingStackPointer_--;
            	        	if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	   value.SetOrderBy(o); 
            	        	}
            	        
            	        }
            	        break;
            	
            	}

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end queryExpression

    
    // $ANTLR start subQueryExpression
    // MacroScope\\MacroScope.g:125:1: subQueryExpression returns [ QueryExpression value ] : (s= querySpecification | LPAREN s= queryExpression RPAREN );
    public QueryExpression subQueryExpression() // throws RecognitionException [1]
    {   

        QueryExpression value = null;
    
        QueryExpression s = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:125:54: (s= querySpecification | LPAREN s= queryExpression RPAREN )
            int alt12 = 2;
            int LA12_0 = input.LA(1);
            
            if ( (LA12_0 == SELECT) )
            {
                alt12 = 1;
            }
            else if ( (LA12_0 == LPAREN) )
            {
                alt12 = 2;
            }
            else 
            {
                if ( backtracking > 0 ) {failed = true; return value;}
                NoViableAltException nvae_d12s0 =
                    new NoViableAltException("125:1: subQueryExpression returns [ QueryExpression value ] : (s= querySpecification | LPAREN s= queryExpression RPAREN );", 12, 0, input);
            
                throw nvae_d12s0;
            }
            switch (alt12) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:126:2: s= querySpecification
                    {
                    	PushFollow(FOLLOW_querySpecification_in_subQueryExpression582);
                    	s = querySpecification();
                    	followingStackPointer_--;
                    	if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  s; 
                    	}
                    
                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:127:4: LPAREN s= queryExpression RPAREN
                    {
                    	Match(input,LPAREN,FOLLOW_LPAREN_in_subQueryExpression590); if (failed) return value;
                    	PushFollow(FOLLOW_queryExpression_in_subQueryExpression596);
                    	s = queryExpression();
                    	followingStackPointer_--;
                    	if (failed) return value;
                    	Match(input,RPAREN,FOLLOW_RPAREN_in_subQueryExpression598); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  s; 
                    	}
                    
                    }
                    break;
            
            }
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end subQueryExpression

    
    // $ANTLR start querySpecification
    // MacroScope\\MacroScope.g:130:1: querySpecification returns [ QueryExpression value ] : s= selectClause (f= fromClause )? (w= whereClause )? (g= groupByClause (h= havingClause )? )? ;
    public QueryExpression querySpecification() // throws RecognitionException [1]
    {   

        QueryExpression value = null;
    
        QueryExpression s = null;

        AliasedItem f = null;

        IExpression w = null;

        GroupByClause g = null;

        IExpression h = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:130:54: (s= selectClause (f= fromClause )? (w= whereClause )? (g= groupByClause (h= havingClause )? )? )
            // MacroScope\\MacroScope.g:131:2: s= selectClause (f= fromClause )? (w= whereClause )? (g= groupByClause (h= havingClause )? )?
            {
            	PushFollow(FOLLOW_selectClause_in_querySpecification619);
            	s = selectClause();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  s; 
            	}
            	// MacroScope\\MacroScope.g:132:2: (f= fromClause )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);
            	
            	if ( (LA13_0 == FROM) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:132:4: f= fromClause
            	        {
            	        	PushFollow(FOLLOW_fromClause_in_querySpecification630);
            	        	f = fromClause();
            	        	followingStackPointer_--;
            	        	if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	   value.From = f; 
            	        	}
            	        
            	        }
            	        break;
            	
            	}

            	// MacroScope\\MacroScope.g:133:2: (w= whereClause )?
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);
            	
            	if ( (LA14_0 == WHERE) )
            	{
            	    alt14 = 1;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:133:4: w= whereClause
            	        {
            	        	PushFollow(FOLLOW_whereClause_in_querySpecification644);
            	        	w = whereClause();
            	        	followingStackPointer_--;
            	        	if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	   value.Where = w; 
            	        	}
            	        
            	        }
            	        break;
            	
            	}

            	// MacroScope\\MacroScope.g:134:2: (g= groupByClause (h= havingClause )? )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);
            	
            	if ( (LA16_0 == GROUP) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:134:4: g= groupByClause (h= havingClause )?
            	        {
            	        	PushFollow(FOLLOW_groupByClause_in_querySpecification658);
            	        	g = groupByClause();
            	        	followingStackPointer_--;
            	        	if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	   value.GroupBy = g; 
            	        	}
            	        	// MacroScope\\MacroScope.g:135:3: (h= havingClause )?
            	        	int alt15 = 2;
            	        	int LA15_0 = input.LA(1);
            	        	
            	        	if ( (LA15_0 == HAVING) )
            	        	{
            	        	    alt15 = 1;
            	        	}
            	        	switch (alt15) 
            	        	{
            	        	    case 1 :
            	        	        // MacroScope\\MacroScope.g:135:5: h= havingClause
            	        	        {
            	        	        	PushFollow(FOLLOW_havingClause_in_querySpecification670);
            	        	        	h = havingClause();
            	        	        	followingStackPointer_--;
            	        	        	if (failed) return value;
            	        	        	if ( backtracking == 0 ) 
            	        	        	{
            	        	        	   value.GroupBy.Having = h; 
            	        	        	}
            	        	        
            	        	        }
            	        	        break;
            	        	
            	        	}

            	        
            	        }
            	        break;
            	
            	}

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end querySpecification

    
    // $ANTLR start selectClause
    // MacroScope\\MacroScope.g:139:1: selectClause returns [ QueryExpression value ] : SELECT ( ALL | DISTINCT )? ( TOP Integer )? s= selectList ;
    public QueryExpression selectClause() // throws RecognitionException [1]
    {   

        QueryExpression value = null;
    
        IToken Integer1 = null;
        AliasedItem s = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:139:48: ( SELECT ( ALL | DISTINCT )? ( TOP Integer )? s= selectList )
            // MacroScope\\MacroScope.g:140:2: SELECT ( ALL | DISTINCT )? ( TOP Integer )? s= selectList
            {
            	Match(input,SELECT,FOLLOW_SELECT_in_selectClause694); if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  new QueryExpression(); 
            	}
            	// MacroScope\\MacroScope.g:141:2: ( ALL | DISTINCT )?
            	int alt17 = 3;
            	int LA17_0 = input.LA(1);
            	
            	if ( (LA17_0 == ALL) )
            	{
            	    alt17 = 1;
            	}
            	else if ( (LA17_0 == DISTINCT) )
            	{
            	    alt17 = 2;
            	}
            	switch (alt17) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:141:4: ALL
            	        {
            	        	Match(input,ALL,FOLLOW_ALL_in_selectClause701); if (failed) return value;
            	        
            	        }
            	        break;
            	    case 2 :
            	        // MacroScope\\MacroScope.g:141:10: DISTINCT
            	        {
            	        	Match(input,DISTINCT,FOLLOW_DISTINCT_in_selectClause705); if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	   value.Distinct = true; 
            	        	}
            	        
            	        }
            	        break;
            	
            	}

            	// MacroScope\\MacroScope.g:142:2: ( TOP Integer )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);
            	
            	if ( (LA18_0 == TOP) )
            	{
            	    alt18 = 1;
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:142:3: TOP Integer
            	        {
            	        	Match(input,TOP,FOLLOW_TOP_in_selectClause714); if (failed) return value;
            	        	Integer1 = (IToken)input.LT(1);
            	        	Match(input,Integer,FOLLOW_Integer_in_selectClause716); if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	   value.Top = int.Parse(Integer1.Text); 
            	        	}
            	        
            	        }
            	        break;
            	
            	}

            	PushFollow(FOLLOW_selectList_in_selectClause728);
            	s = selectList();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value.SelectItems = s; 
            	}
            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end selectClause

    
    // $ANTLR start whereClause
    // MacroScope\\MacroScope.g:146:1: whereClause returns [ IExpression value ] : WHERE c= searchCondition ;
    public IExpression whereClause() // throws RecognitionException [1]
    {   

        IExpression value = null;
    
        IExpression c = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:146:43: ( WHERE c= searchCondition )
            // MacroScope\\MacroScope.g:147:2: WHERE c= searchCondition
            {
            	Match(input,WHERE,FOLLOW_WHERE_in_whereClause745); if (failed) return value;
            	PushFollow(FOLLOW_searchCondition_in_whereClause751);
            	c = searchCondition();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  c; 
            	}
            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end whereClause

    
    // $ANTLR start orderByClause
    // MacroScope\\MacroScope.g:150:1: orderByClause returns [ OrderExpression value ] : ORDER BY e= orderExpression ( COMMA e= orderExpression )* ;
    public OrderExpression orderByClause() // throws RecognitionException [1]
    {   

        OrderExpression value = null;
    
        OrderExpression e = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:150:49: ( ORDER BY e= orderExpression ( COMMA e= orderExpression )* )
            // MacroScope\\MacroScope.g:151:2: ORDER BY e= orderExpression ( COMMA e= orderExpression )*
            {
            	Match(input,ORDER,FOLLOW_ORDER_in_orderByClause768); if (failed) return value;
            	Match(input,BY,FOLLOW_BY_in_orderByClause770); if (failed) return value;
            	PushFollow(FOLLOW_orderExpression_in_orderByClause777);
            	e = orderExpression();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  e; 
            	}
            	// MacroScope\\MacroScope.g:153:2: ( COMMA e= orderExpression )*
            	do 
            	{
            	    int alt19 = 2;
            	    int LA19_0 = input.LA(1);
            	    
            	    if ( (LA19_0 == COMMA) )
            	    {
            	        alt19 = 1;
            	    }
            	    
            	
            	    switch (alt19) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:153:4: COMMA e= orderExpression
            			    {
            			    	Match(input,COMMA,FOLLOW_COMMA_in_orderByClause784); if (failed) return value;
            			    	PushFollow(FOLLOW_orderExpression_in_orderByClause790);
            			    	e = orderExpression();
            			    	followingStackPointer_--;
            			    	if (failed) return value;
            			    	if ( backtracking == 0 ) 
            			    	{
            			    	   value.Add(e); 
            			    	}
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop19;
            	    }
            	} while (true);
            	
            	loop19:
            		;	// Stops C# compiler whinging that label 'loop19' has no statements

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end orderByClause

    
    // $ANTLR start orderExpression
    // MacroScope\\MacroScope.g:156:1: orderExpression returns [ OrderExpression value ] : e= expression ( ASC | DESC )? ;
    public OrderExpression orderExpression() // throws RecognitionException [1]
    {   

        OrderExpression value = null;
    
        IExpression e = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:156:51: (e= expression ( ASC | DESC )? )
            // MacroScope\\MacroScope.g:157:2: e= expression ( ASC | DESC )?
            {
            	PushFollow(FOLLOW_expression_in_orderExpression814);
            	e = expression();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  new OrderExpression(e); 
            	}
            	// MacroScope\\MacroScope.g:158:2: ( ASC | DESC )?
            	int alt20 = 3;
            	int LA20_0 = input.LA(1);
            	
            	if ( (LA20_0 == ASC) )
            	{
            	    alt20 = 1;
            	}
            	else if ( (LA20_0 == DESC) )
            	{
            	    alt20 = 2;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:158:4: ASC
            	        {
            	        	Match(input,ASC,FOLLOW_ASC_in_orderExpression821); if (failed) return value;
            	        
            	        }
            	        break;
            	    case 2 :
            	        // MacroScope\\MacroScope.g:158:10: DESC
            	        {
            	        	Match(input,DESC,FOLLOW_DESC_in_orderExpression825); if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	   value.Asc = false; 
            	        	}
            	        
            	        }
            	        break;
            	
            	}

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end orderExpression

    
    // $ANTLR start groupByClause
    // MacroScope\\MacroScope.g:161:1: groupByClause returns [ GroupByClause value ] : GROUP BY ( ALL )? e= expression ( COMMA e= expression )* ;
    public GroupByClause groupByClause() // throws RecognitionException [1]
    {   

        GroupByClause value = null;
    
        IExpression e = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:161:47: ( GROUP BY ( ALL )? e= expression ( COMMA e= expression )* )
            // MacroScope\\MacroScope.g:162:2: GROUP BY ( ALL )? e= expression ( COMMA e= expression )*
            {
            	Match(input,GROUP,FOLLOW_GROUP_in_groupByClause845); if (failed) return value;
            	Match(input,BY,FOLLOW_BY_in_groupByClause847); if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  new GroupByClause(); 
            	}
            	// MacroScope\\MacroScope.g:163:3: ( ALL )?
            	int alt21 = 2;
            	int LA21_0 = input.LA(1);
            	
            	if ( (LA21_0 == ALL) )
            	{
            	    alt21 = 1;
            	}
            	switch (alt21) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:163:5: ALL
            	        {
            	        	Match(input,ALL,FOLLOW_ALL_in_groupByClause855); if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	   value.All = true; 
            	        	}
            	        
            	        }
            	        break;
            	
            	}

            	PushFollow(FOLLOW_expression_in_groupByClause868);
            	e = expression();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	  
            	  			value.Expression = new ExpressionItem(e);
            	  		
            	}
            	// MacroScope\\MacroScope.g:166:5: ( COMMA e= expression )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);
            	    
            	    if ( (LA22_0 == COMMA) )
            	    {
            	        alt22 = 1;
            	    }
            	    
            	
            	    switch (alt22) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:166:7: COMMA e= expression
            			    {
            			    	Match(input,COMMA,FOLLOW_COMMA_in_groupByClause874); if (failed) return value;
            			    	PushFollow(FOLLOW_expression_in_groupByClause880);
            			    	e = expression();
            			    	followingStackPointer_--;
            			    	if (failed) return value;
            			    	if ( backtracking == 0 ) 
            			    	{
            			    	  
            			    	  				value.Expression.Add(
            			    	  					new ExpressionItem(e));
            			    	  			
            			    	}
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop22;
            	    }
            	} while (true);
            	
            	loop22:
            		;	// Stops C# compiler whinging that label 'loop22' has no statements

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end groupByClause

    
    // $ANTLR start havingClause
    // MacroScope\\MacroScope.g:172:1: havingClause returns [ IExpression value ] : HAVING c= searchCondition ;
    public IExpression havingClause() // throws RecognitionException [1]
    {   

        IExpression value = null;
    
        IExpression c = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:172:44: ( HAVING c= searchCondition )
            // MacroScope\\MacroScope.g:173:2: HAVING c= searchCondition
            {
            	Match(input,HAVING,FOLLOW_HAVING_in_havingClause900); if (failed) return value;
            	PushFollow(FOLLOW_searchCondition_in_havingClause906);
            	c = searchCondition();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  c; 
            	}
            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end havingClause

    
    // $ANTLR start searchCondition
    // MacroScope\\MacroScope.g:176:1: searchCondition returns [ IExpression value ] : e= additiveSubSearchCondition ( OR r= additiveSubSearchCondition )* ;
    public IExpression searchCondition() // throws RecognitionException [1]
    {   

        IExpression value = null;
    
        IExpression e = null;

        IExpression r = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:176:47: (e= additiveSubSearchCondition ( OR r= additiveSubSearchCondition )* )
            // MacroScope\\MacroScope.g:177:2: e= additiveSubSearchCondition ( OR r= additiveSubSearchCondition )*
            {
            	PushFollow(FOLLOW_additiveSubSearchCondition_in_searchCondition927);
            	e = additiveSubSearchCondition();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  e; 
            	}
            	// MacroScope\\MacroScope.g:178:3: ( OR r= additiveSubSearchCondition )*
            	do 
            	{
            	    int alt23 = 2;
            	    int LA23_0 = input.LA(1);
            	    
            	    if ( (LA23_0 == OR) )
            	    {
            	        alt23 = 1;
            	    }
            	    
            	
            	    switch (alt23) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:178:5: OR r= additiveSubSearchCondition
            			    {
            			    	Match(input,OR,FOLLOW_OR_in_searchCondition935); if (failed) return value;
            			    	PushFollow(FOLLOW_additiveSubSearchCondition_in_searchCondition941);
            			    	r = additiveSubSearchCondition();
            			    	followingStackPointer_--;
            			    	if (failed) return value;
            			    	if ( backtracking == 0 ) 
            			    	{
            			    	  
            			    	  			value =  new Expression(value,
            			    	  				ExpressionOperator.Or,
            			    	  				r);
            			    	  		
            			    	}
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop23;
            	    }
            	} while (true);
            	
            	loop23:
            		;	// Stops C# compiler whinging that label 'loop23' has no statements

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end searchCondition

    
    // $ANTLR start additiveSubSearchCondition
    // MacroScope\\MacroScope.g:186:1: additiveSubSearchCondition returns [ IExpression value ] : e= subSearchCondition ( AND r= subSearchCondition )* ;
    public IExpression additiveSubSearchCondition() // throws RecognitionException [1]
    {   

        IExpression value = null;
    
        IExpression e = null;

        IExpression r = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:186:58: (e= subSearchCondition ( AND r= subSearchCondition )* )
            // MacroScope\\MacroScope.g:187:2: e= subSearchCondition ( AND r= subSearchCondition )*
            {
            	PushFollow(FOLLOW_subSearchCondition_in_additiveSubSearchCondition967);
            	e = subSearchCondition();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  e; 
            	}
            	// MacroScope\\MacroScope.g:188:3: ( AND r= subSearchCondition )*
            	do 
            	{
            	    int alt24 = 2;
            	    int LA24_0 = input.LA(1);
            	    
            	    if ( (LA24_0 == AND) )
            	    {
            	        alt24 = 1;
            	    }
            	    
            	
            	    switch (alt24) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:188:5: AND r= subSearchCondition
            			    {
            			    	Match(input,AND,FOLLOW_AND_in_additiveSubSearchCondition975); if (failed) return value;
            			    	PushFollow(FOLLOW_subSearchCondition_in_additiveSubSearchCondition981);
            			    	r = subSearchCondition();
            			    	followingStackPointer_--;
            			    	if (failed) return value;
            			    	if ( backtracking == 0 ) 
            			    	{
            			    	  
            			    	  			value =  new Expression(value,
            			    	  				ExpressionOperator.And,
            			    	  				r);
            			    	  		
            			    	}
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop24;
            	    }
            	} while (true);
            	
            	loop24:
            		;	// Stops C# compiler whinging that label 'loop24' has no statements

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end additiveSubSearchCondition

    
    // $ANTLR start bracketedSearchCondition
    // MacroScope\\MacroScope.g:196:1: bracketedSearchCondition returns [ IExpression value ] : LPAREN e= searchCondition RPAREN ;
    public IExpression bracketedSearchCondition() // throws RecognitionException [1]
    {   

        IExpression value = null;
    
        IExpression e = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:196:56: ( LPAREN e= searchCondition RPAREN )
            // MacroScope\\MacroScope.g:197:2: LPAREN e= searchCondition RPAREN
            {
            	Match(input,LPAREN,FOLLOW_LPAREN_in_bracketedSearchCondition1003); if (failed) return value;
            	PushFollow(FOLLOW_searchCondition_in_bracketedSearchCondition1009);
            	e = searchCondition();
            	followingStackPointer_--;
            	if (failed) return value;
            	Match(input,RPAREN,FOLLOW_RPAREN_in_bracketedSearchCondition1011); if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	  
            	  		value =  e;
            	  	
            	}
            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end bracketedSearchCondition

    
    // $ANTLR start subSearchCondition
    // MacroScope\\MacroScope.g:202:1: subSearchCondition returns [ IExpression value ] : ( NOT )? ( ( bracketedSearchCondition )=>e= bracketedSearchCondition | p= predicate ) ;
    public IExpression subSearchCondition() // throws RecognitionException [1]
    {   

        IExpression value = null;
    
        IExpression e = null;

        IExpression p = null;
        
    
         bool negated = false; 
        try 
    	{
            // MacroScope\\MacroScope.g:203:33: ( ( NOT )? ( ( bracketedSearchCondition )=>e= bracketedSearchCondition | p= predicate ) )
            // MacroScope\\MacroScope.g:204:2: ( NOT )? ( ( bracketedSearchCondition )=>e= bracketedSearchCondition | p= predicate )
            {
            	// MacroScope\\MacroScope.g:204:2: ( NOT )?
            	int alt25 = 2;
            	int LA25_0 = input.LA(1);
            	
            	if ( (LA25_0 == NOT) )
            	{
            	    alt25 = 1;
            	}
            	switch (alt25) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:204:4: NOT
            	        {
            	        	Match(input,NOT,FOLLOW_NOT_in_subSearchCondition1035); if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	   negated = true; 
            	        	}
            	        
            	        }
            	        break;
            	
            	}

            	// MacroScope\\MacroScope.g:204:31: ( ( bracketedSearchCondition )=>e= bracketedSearchCondition | p= predicate )
            	int alt26 = 2;
            	int LA26_0 = input.LA(1);
            	
            	if ( (LA26_0 == LPAREN) )
            	{
            	    int LA26_1 = input.LA(2);
            	    
            	    if ( (synpred1()) )
            	    {
            	        alt26 = 1;
            	    }
            	    else if ( (true) )
            	    {
            	        alt26 = 2;
            	    }
            	    else 
            	    {
            	        if ( backtracking > 0 ) {failed = true; return value;}
            	        NoViableAltException nvae_d26s1 =
            	            new NoViableAltException("204:31: ( ( bracketedSearchCondition )=>e= bracketedSearchCondition | p= predicate )", 26, 1, input);
            	    
            	        throw nvae_d26s1;
            	    }
            	}
            	else if ( (LA26_0 == Integer || LA26_0 == NULL || LA26_0 == EXISTS || (LA26_0 >= LEFT && LA26_0 <= RIGHT) || (LA26_0 >= PLACEHOLDER && LA26_0 <= SUBSTRING) || (LA26_0 >= EXTRACT && LA26_0 <= CASE) || LA26_0 == CAST || (LA26_0 >= UnicodeStringLiteral && LA26_0 <= MINUS)) )
            	{
            	    alt26 = 2;
            	}
            	else 
            	{
            	    if ( backtracking > 0 ) {failed = true; return value;}
            	    NoViableAltException nvae_d26s0 =
            	        new NoViableAltException("204:31: ( ( bracketedSearchCondition )=>e= bracketedSearchCondition | p= predicate )", 26, 0, input);
            	
            	    throw nvae_d26s0;
            	}
            	switch (alt26) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:205:3: ( bracketedSearchCondition )=>e= bracketedSearchCondition
            	        {
            	        	PushFollow(FOLLOW_bracketedSearchCondition_in_subSearchCondition1059);
            	        	e = bracketedSearchCondition();
            	        	followingStackPointer_--;
            	        	if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	  
            	        	  				if (!negated)
            	        	  				{
            	        	  					value =  e;
            	        	  				}
            	        	  				else
            	        	  				{
            	        	  					Expression output = new Expression();
            	        	  					output.Operator =
            	        	  						ExpressionOperator.Not;
            	        	  					output.Right = e;
            	        	  					value =  output;
            	        	  				}
            	        	  		
            	        	}
            	        
            	        }
            	        break;
            	    case 2 :
            	        // MacroScope\\MacroScope.g:220:5: p= predicate
            	        {
            	        	PushFollow(FOLLOW_predicate_in_subSearchCondition1071);
            	        	p = predicate();
            	        	followingStackPointer_--;
            	        	if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	  
            	        	  			if (!negated)
            	        	  			{
            	        	  				value =  p;
            	        	  			}
            	        	  			else
            	        	  			{
            	        	  				Expression output = new Expression();
            	        	  				output.Operator = ExpressionOperator.Not;
            	        	  				output.Right = p;
            	        	  				value =  output;
            	        	  			}
            	        	  		
            	        	}
            	        
            	        }
            	        break;
            	
            	}

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end subSearchCondition

    
    // $ANTLR start predicate
    // MacroScope\\MacroScope.g:236:1: predicate returns [ IExpression value ] : (l= expression (o= comparisonOperator (r= expression | q= quantifierSpec LPAREN s= selectStatement RPAREN ) | IS ( NOT )? NULL | ( NOT )? ( LIKE e= expression ( ESCAPE f= expression )? | BETWEEN e= expression AND f= expression | IN LPAREN ( ( selectStatement )=>s= selectStatement | e= expression ( COMMA e= expression )* ) RPAREN ) ) | EXISTS LPAREN s= selectStatement RPAREN );
    public IExpression predicate() // throws RecognitionException [1]
    {   

        IExpression value = null;
    
        IExpression l = null;

        ExpressionOperator o = null;

        IExpression r = null;

        PredicateQuantifier q = null;

        SelectStatement s = null;

        IExpression e = null;

        IExpression f = null;
        
    
        
        	bool negated = false; 
        	ExpressionItem inSet = null;
    
        try 
    	{
            // MacroScope\\MacroScope.g:240:3: (l= expression (o= comparisonOperator (r= expression | q= quantifierSpec LPAREN s= selectStatement RPAREN ) | IS ( NOT )? NULL | ( NOT )? ( LIKE e= expression ( ESCAPE f= expression )? | BETWEEN e= expression AND f= expression | IN LPAREN ( ( selectStatement )=>s= selectStatement | e= expression ( COMMA e= expression )* ) RPAREN ) ) | EXISTS LPAREN s= selectStatement RPAREN )
            int alt35 = 2;
            int LA35_0 = input.LA(1);
            
            if ( (LA35_0 == LPAREN || LA35_0 == Integer || LA35_0 == NULL || (LA35_0 >= LEFT && LA35_0 <= RIGHT) || (LA35_0 >= PLACEHOLDER && LA35_0 <= SUBSTRING) || (LA35_0 >= EXTRACT && LA35_0 <= CASE) || LA35_0 == CAST || (LA35_0 >= UnicodeStringLiteral && LA35_0 <= MINUS)) )
            {
                alt35 = 1;
            }
            else if ( (LA35_0 == EXISTS) )
            {
                alt35 = 2;
            }
            else 
            {
                if ( backtracking > 0 ) {failed = true; return value;}
                NoViableAltException nvae_d35s0 =
                    new NoViableAltException("236:1: predicate returns [ IExpression value ] : (l= expression (o= comparisonOperator (r= expression | q= quantifierSpec LPAREN s= selectStatement RPAREN ) | IS ( NOT )? NULL | ( NOT )? ( LIKE e= expression ( ESCAPE f= expression )? | BETWEEN e= expression AND f= expression | IN LPAREN ( ( selectStatement )=>s= selectStatement | e= expression ( COMMA e= expression )* ) RPAREN ) ) | EXISTS LPAREN s= selectStatement RPAREN );", 35, 0, input);
            
                throw nvae_d35s0;
            }
            switch (alt35) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:241:2: l= expression (o= comparisonOperator (r= expression | q= quantifierSpec LPAREN s= selectStatement RPAREN ) | IS ( NOT )? NULL | ( NOT )? ( LIKE e= expression ( ESCAPE f= expression )? | BETWEEN e= expression AND f= expression | IN LPAREN ( ( selectStatement )=>s= selectStatement | e= expression ( COMMA e= expression )* ) RPAREN ) )
                    {
                    	PushFollow(FOLLOW_expression_in_predicate1101);
                    	l = expression();
                    	followingStackPointer_--;
                    	if (failed) return value;
                    	// MacroScope\\MacroScope.g:241:17: (o= comparisonOperator (r= expression | q= quantifierSpec LPAREN s= selectStatement RPAREN ) | IS ( NOT )? NULL | ( NOT )? ( LIKE e= expression ( ESCAPE f= expression )? | BETWEEN e= expression AND f= expression | IN LPAREN ( ( selectStatement )=>s= selectStatement | e= expression ( COMMA e= expression )* ) RPAREN ) )
                    	int alt34 = 3;
                    	switch ( input.LA(1) ) 
                    	{
                    	case ASSIGNEQUAL:
                    	case NOTEQUAL1:
                    	case NOTEQUAL2:
                    	case LESSTHANOREQUALTO1:
                    	case LESSTHAN:
                    	case GREATERTHANOREQUALTO1:
                    	case GREATERTHAN:
                    		{
                    	    alt34 = 1;
                    	    }
                    	    break;
                    	case IS:
                    		{
                    	    alt34 = 2;
                    	    }
                    	    break;
                    	case NOT:
                    	case LIKE:
                    	case BETWEEN:
                    	case IN:
                    		{
                    	    alt34 = 3;
                    	    }
                    	    break;
                    		default:
                    		    if ( backtracking > 0 ) {failed = true; return value;}
                    		    NoViableAltException nvae_d34s0 =
                    		        new NoViableAltException("241:17: (o= comparisonOperator (r= expression | q= quantifierSpec LPAREN s= selectStatement RPAREN ) | IS ( NOT )? NULL | ( NOT )? ( LIKE e= expression ( ESCAPE f= expression )? | BETWEEN e= expression AND f= expression | IN LPAREN ( ( selectStatement )=>s= selectStatement | e= expression ( COMMA e= expression )* ) RPAREN ) )", 34, 0, input);
                    	
                    		    throw nvae_d34s0;
                    	}
                    	
                    	switch (alt34) 
                    	{
                    	    case 1 :
                    	        // MacroScope\\MacroScope.g:242:10: o= comparisonOperator (r= expression | q= quantifierSpec LPAREN s= selectStatement RPAREN )
                    	        {
                    	        	PushFollow(FOLLOW_comparisonOperator_in_predicate1118);
                    	        	o = comparisonOperator();
                    	        	followingStackPointer_--;
                    	        	if (failed) return value;
                    	        	// MacroScope\\MacroScope.g:242:33: (r= expression | q= quantifierSpec LPAREN s= selectStatement RPAREN )
                    	        	int alt27 = 2;
                    	        	int LA27_0 = input.LA(1);
                    	        	
                    	        	if ( (LA27_0 == LPAREN || LA27_0 == Integer || LA27_0 == NULL || (LA27_0 >= LEFT && LA27_0 <= RIGHT) || (LA27_0 >= PLACEHOLDER && LA27_0 <= SUBSTRING) || (LA27_0 >= EXTRACT && LA27_0 <= CASE) || LA27_0 == CAST || (LA27_0 >= UnicodeStringLiteral && LA27_0 <= MINUS)) )
                    	        	{
                    	        	    alt27 = 1;
                    	        	}
                    	        	else if ( (LA27_0 == ALL || (LA27_0 >= SOME && LA27_0 <= ANY)) )
                    	        	{
                    	        	    alt27 = 2;
                    	        	}
                    	        	else 
                    	        	{
                    	        	    if ( backtracking > 0 ) {failed = true; return value;}
                    	        	    NoViableAltException nvae_d27s0 =
                    	        	        new NoViableAltException("242:33: (r= expression | q= quantifierSpec LPAREN s= selectStatement RPAREN )", 27, 0, input);
                    	        	
                    	        	    throw nvae_d27s0;
                    	        	}
                    	        	switch (alt27) 
                    	        	{
                    	        	    case 1 :
                    	        	        // MacroScope\\MacroScope.g:243:15: r= expression
                    	        	        {
                    	        	        	PushFollow(FOLLOW_expression_in_predicate1140);
                    	        	        	r = expression();
                    	        	        	followingStackPointer_--;
                    	        	        	if (failed) return value;
                    	        	        	if ( backtracking == 0 ) 
                    	        	        	{
                    	        	        	  
                    	        	        	  				value =  new Expression(l,
                    	        	        	  					o, r);
                    	        	        	  			
                    	        	        	}
                    	        	        
                    	        	        }
                    	        	        break;
                    	        	    case 2 :
                    	        	        // MacroScope\\MacroScope.g:247:6: q= quantifierSpec LPAREN s= selectStatement RPAREN
                    	        	        {
                    	        	        	PushFollow(FOLLOW_quantifierSpec_in_predicate1153);
                    	        	        	q = quantifierSpec();
                    	        	        	followingStackPointer_--;
                    	        	        	if (failed) return value;
                    	        	        	Match(input,LPAREN,FOLLOW_LPAREN_in_predicate1159); if (failed) return value;
                    	        	        	PushFollow(FOLLOW_selectStatement_in_predicate1165);
                    	        	        	s = selectStatement();
                    	        	        	followingStackPointer_--;
                    	        	        	if (failed) return value;
                    	        	        	Match(input,RPAREN,FOLLOW_RPAREN_in_predicate1167); if (failed) return value;
                    	        	        	if ( backtracking == 0 ) 
                    	        	        	{
                    	        	        	  
                    	        	        	  					BracketedExpression expr =
                    	        	        	  						new BracketedExpression(
                    	        	        	  							s);
                    	        	        	  					expr.Spaced = true;
                    	        	        	  					value =  new PredicateExpression(
                    	        	        	  						l, o,
                    	        	        	  						q, expr);
                    	        	        	  				
                    	        	        	}
                    	        	        
                    	        	        }
                    	        	        break;
                    	        	
                    	        	}

                    	        
                    	        }
                    	        break;
                    	    case 2 :
                    	        // MacroScope\\MacroScope.g:258:5: IS ( NOT )? NULL
                    	        {
                    	        	Match(input,IS,FOLLOW_IS_in_predicate1188); if (failed) return value;
                    	        	if ( backtracking == 0 ) 
                    	        	{
                    	        	  
                    	        	  			value =  new Expression();
                    	        	  			((Expression)value).Left = l;
                    	        	  			((Expression)value).Operator =
                    	        	  				ExpressionOperator.IsNull;
                    	        	  		
                    	        	}
                    	        	// MacroScope\\MacroScope.g:264:4: ( NOT )?
                    	        	int alt28 = 2;
                    	        	int LA28_0 = input.LA(1);
                    	        	
                    	        	if ( (LA28_0 == NOT) )
                    	        	{
                    	        	    alt28 = 1;
                    	        	}
                    	        	switch (alt28) 
                    	        	{
                    	        	    case 1 :
                    	        	        // MacroScope\\MacroScope.g:264:6: NOT
                    	        	        {
                    	        	        	Match(input,NOT,FOLLOW_NOT_in_predicate1198); if (failed) return value;
                    	        	        	if ( backtracking == 0 ) 
                    	        	        	{
                    	        	        	  
                    	        	        	  				((Expression)value).Operator =
                    	        	        	  					ExpressionOperator.IsNotNull;
                    	        	        	  			
                    	        	        	}
                    	        	        
                    	        	        }
                    	        	        break;
                    	        	
                    	        	}

                    	        	Match(input,NULL,FOLLOW_NULL_in_predicate1208); if (failed) return value;
                    	        
                    	        }
                    	        break;
                    	    case 3 :
                    	        // MacroScope\\MacroScope.g:269:5: ( NOT )? ( LIKE e= expression ( ESCAPE f= expression )? | BETWEEN e= expression AND f= expression | IN LPAREN ( ( selectStatement )=>s= selectStatement | e= expression ( COMMA e= expression )* ) RPAREN )
                    	        {
                    	        	// MacroScope\\MacroScope.g:269:5: ( NOT )?
                    	        	int alt29 = 2;
                    	        	int LA29_0 = input.LA(1);
                    	        	
                    	        	if ( (LA29_0 == NOT) )
                    	        	{
                    	        	    alt29 = 1;
                    	        	}
                    	        	switch (alt29) 
                    	        	{
                    	        	    case 1 :
                    	        	        // MacroScope\\MacroScope.g:269:7: NOT
                    	        	        {
                    	        	        	Match(input,NOT,FOLLOW_NOT_in_predicate1216); if (failed) return value;
                    	        	        	if ( backtracking == 0 ) 
                    	        	        	{
                    	        	        	   negated = true; 
                    	        	        	}
                    	        	        
                    	        	        }
                    	        	        break;
                    	        	
                    	        	}

                    	        	// MacroScope\\MacroScope.g:269:34: ( LIKE e= expression ( ESCAPE f= expression )? | BETWEEN e= expression AND f= expression | IN LPAREN ( ( selectStatement )=>s= selectStatement | e= expression ( COMMA e= expression )* ) RPAREN )
                    	        	int alt33 = 3;
                    	        	switch ( input.LA(1) ) 
                    	        	{
                    	        	case LIKE:
                    	        		{
                    	        	    alt33 = 1;
                    	        	    }
                    	        	    break;
                    	        	case BETWEEN:
                    	        		{
                    	        	    alt33 = 2;
                    	        	    }
                    	        	    break;
                    	        	case IN:
                    	        		{
                    	        	    alt33 = 3;
                    	        	    }
                    	        	    break;
                    	        		default:
                    	        		    if ( backtracking > 0 ) {failed = true; return value;}
                    	        		    NoViableAltException nvae_d33s0 =
                    	        		        new NoViableAltException("269:34: ( LIKE e= expression ( ESCAPE f= expression )? | BETWEEN e= expression AND f= expression | IN LPAREN ( ( selectStatement )=>s= selectStatement | e= expression ( COMMA e= expression )* ) RPAREN )", 33, 0, input);
                    	        	
                    	        		    throw nvae_d33s0;
                    	        	}
                    	        	
                    	        	switch (alt33) 
                    	        	{
                    	        	    case 1 :
                    	        	        // MacroScope\\MacroScope.g:270:4: LIKE e= expression ( ESCAPE f= expression )?
                    	        	        {
                    	        	        	Match(input,LIKE,FOLLOW_LIKE_in_predicate1228); if (failed) return value;
                    	        	        	PushFollow(FOLLOW_expression_in_predicate1234);
                    	        	        	e = expression();
                    	        	        	followingStackPointer_--;
                    	        	        	if (failed) return value;
                    	        	        	if ( backtracking == 0 ) 
                    	        	        	{
                    	        	        	  
                    	        	        	  				value =  new PatternExpression(
                    	        	        	  					e);
                    	        	        	  			
                    	        	        	}
                    	        	        	// MacroScope\\MacroScope.g:275:5: ( ESCAPE f= expression )?
                    	        	        	int alt30 = 2;
                    	        	        	int LA30_0 = input.LA(1);
                    	        	        	
                    	        	        	if ( (LA30_0 == ESCAPE) )
                    	        	        	{
                    	        	        	    alt30 = 1;
                    	        	        	}
                    	        	        	switch (alt30) 
                    	        	        	{
                    	        	        	    case 1 :
                    	        	        	        // MacroScope\\MacroScope.g:275:7: ESCAPE f= expression
                    	        	        	        {
                    	        	        	        	Match(input,ESCAPE,FOLLOW_ESCAPE_in_predicate1249); if (failed) return value;
                    	        	        	        	PushFollow(FOLLOW_expression_in_predicate1255);
                    	        	        	        	f = expression();
                    	        	        	        	followingStackPointer_--;
                    	        	        	        	if (failed) return value;
                    	        	        	        	if ( backtracking == 0 ) 
                    	        	        	        	{
                    	        	        	        	  
                    	        	        	        	  					((PatternExpression)value).Escape =
                    	        	        	        	  						f;
                    	        	        	        	  				
                    	        	        	        	}
                    	        	        	        
                    	        	        	        }
                    	        	        	        break;
                    	        	        	
                    	        	        	}

                    	        	        	if ( backtracking == 0 ) 
                    	        	        	{
                    	        	        	  
                    	        	        	  					if (!negated)
                    	        	        	  					{
                    	        	        	  						value =  new Expression(l, ExpressionOperator.Like, value);
                    	        	        	  					}
                    	        	        	  					else
                    	        	        	  					{
                    	        	        	  						value =  new Expression(l, ExpressionOperator.NotLike, value);
                    	        	        	  					}
                    	        	        	  				
                    	        	        	}
                    	        	        
                    	        	        }
                    	        	        break;
                    	        	    case 2 :
                    	        	        // MacroScope\\MacroScope.g:289:6: BETWEEN e= expression AND f= expression
                    	        	        {
                    	        	        	Match(input,BETWEEN,FOLLOW_BETWEEN_in_predicate1273); if (failed) return value;
                    	        	        	PushFollow(FOLLOW_expression_in_predicate1279);
                    	        	        	e = expression();
                    	        	        	followingStackPointer_--;
                    	        	        	if (failed) return value;
                    	        	        	Match(input,AND,FOLLOW_AND_in_predicate1281); if (failed) return value;
                    	        	        	PushFollow(FOLLOW_expression_in_predicate1287);
                    	        	        	f = expression();
                    	        	        	followingStackPointer_--;
                    	        	        	if (failed) return value;
                    	        	        	if ( backtracking == 0 ) 
                    	        	        	{
                    	        	        	  
                    	        	        	  				Expression inner = new Expression(l,
                    	        	        	  					ExpressionOperator.Between,
                    	        	        	  					new Range(e, f));
                    	        	        	  				if (!negated)
                    	        	        	  				{
                    	        	        	  					value =  inner;
                    	        	        	  				}
                    	        	        	  				else
                    	        	        	  				{
                    	        	        	  					value =  new Expression();
                    	        	        	  					((Expression)value).Operator =
                    	        	        	  						ExpressionOperator.Not;
                    	        	        	  					((Expression)value).Right = inner;
                    	        	        	  				}
                    	        	        	  			
                    	        	        	}
                    	        	        
                    	        	        }
                    	        	        break;
                    	        	    case 3 :
                    	        	        // MacroScope\\MacroScope.g:305:6: IN LPAREN ( ( selectStatement )=>s= selectStatement | e= expression ( COMMA e= expression )* ) RPAREN
                    	        	        {
                    	        	        	Match(input,IN,FOLLOW_IN_in_predicate1296); if (failed) return value;
                    	        	        	Match(input,LPAREN,FOLLOW_LPAREN_in_predicate1298); if (failed) return value;
                    	        	        	// MacroScope\\MacroScope.g:305:16: ( ( selectStatement )=>s= selectStatement | e= expression ( COMMA e= expression )* )
                    	        	        	int alt32 = 2;
                    	        	        	int LA32_0 = input.LA(1);
                    	        	        	
                    	        	        	if ( (LA32_0 == SELECT) && (synpred2()) )
                    	        	        	{
                    	        	        	    alt32 = 1;
                    	        	        	}
                    	        	        	else if ( (LA32_0 == LPAREN) )
                    	        	        	{
                    	        	        	    int LA32_2 = input.LA(2);
                    	        	        	    
                    	        	        	    if ( (synpred2()) )
                    	        	        	    {
                    	        	        	        alt32 = 1;
                    	        	        	    }
                    	        	        	    else if ( (true) )
                    	        	        	    {
                    	        	        	        alt32 = 2;
                    	        	        	    }
                    	        	        	    else 
                    	        	        	    {
                    	        	        	        if ( backtracking > 0 ) {failed = true; return value;}
                    	        	        	        NoViableAltException nvae_d32s2 =
                    	        	        	            new NoViableAltException("305:16: ( ( selectStatement )=>s= selectStatement | e= expression ( COMMA e= expression )* )", 32, 2, input);
                    	        	        	    
                    	        	        	        throw nvae_d32s2;
                    	        	        	    }
                    	        	        	}
                    	        	        	else if ( (LA32_0 == Integer || LA32_0 == NULL || (LA32_0 >= LEFT && LA32_0 <= RIGHT) || (LA32_0 >= PLACEHOLDER && LA32_0 <= SUBSTRING) || (LA32_0 >= EXTRACT && LA32_0 <= CASE) || LA32_0 == CAST || (LA32_0 >= UnicodeStringLiteral && LA32_0 <= MINUS)) )
                    	        	        	{
                    	        	        	    alt32 = 2;
                    	        	        	}
                    	        	        	else 
                    	        	        	{
                    	        	        	    if ( backtracking > 0 ) {failed = true; return value;}
                    	        	        	    NoViableAltException nvae_d32s0 =
                    	        	        	        new NoViableAltException("305:16: ( ( selectStatement )=>s= selectStatement | e= expression ( COMMA e= expression )* )", 32, 0, input);
                    	        	        	
                    	        	        	    throw nvae_d32s0;
                    	        	        	}
                    	        	        	switch (alt32) 
                    	        	        	{
                    	        	        	    case 1 :
                    	        	        	        // MacroScope\\MacroScope.g:306:5: ( selectStatement )=>s= selectStatement
                    	        	        	        {
                    	        	        	        	PushFollow(FOLLOW_selectStatement_in_predicate1323);
                    	        	        	        	s = selectStatement();
                    	        	        	        	followingStackPointer_--;
                    	        	        	        	if (failed) return value;
                    	        	        	        	if ( backtracking == 0 ) 
                    	        	        	        	{
                    	        	        	        	  
                    	        	        	        	  						value =  new Expression(l, negated ? ExpressionOperator.NotIn : ExpressionOperator.In, s);
                    	        	        	        	  					
                    	        	        	        	}
                    	        	        	        
                    	        	        	        }
                    	        	        	        break;
                    	        	        	    case 2 :
                    	        	        	        // MacroScope\\MacroScope.g:310:7: e= expression ( COMMA e= expression )*
                    	        	        	        {
                    	        	        	        	PushFollow(FOLLOW_expression_in_predicate1337);
                    	        	        	        	e = expression();
                    	        	        	        	followingStackPointer_--;
                    	        	        	        	if (failed) return value;
                    	        	        	        	if ( backtracking == 0 ) 
                    	        	        	        	{
                    	        	        	        	  
                    	        	        	        	  					inSet = new ExpressionItem(e);
                    	        	        	        	  				
                    	        	        	        	}
                    	        	        	        	// MacroScope\\MacroScope.g:313:6: ( COMMA e= expression )*
                    	        	        	        	do 
                    	        	        	        	{
                    	        	        	        	    int alt31 = 2;
                    	        	        	        	    int LA31_0 = input.LA(1);
                    	        	        	        	    
                    	        	        	        	    if ( (LA31_0 == COMMA) )
                    	        	        	        	    {
                    	        	        	        	        alt31 = 1;
                    	        	        	        	    }
                    	        	        	        	    
                    	        	        	        	
                    	        	        	        	    switch (alt31) 
                    	        	        	        		{
                    	        	        	        			case 1 :
                    	        	        	        			    // MacroScope\\MacroScope.g:313:8: COMMA e= expression
                    	        	        	        			    {
                    	        	        	        			    	Match(input,COMMA,FOLLOW_COMMA_in_predicate1348); if (failed) return value;
                    	        	        	        			    	PushFollow(FOLLOW_expression_in_predicate1354);
                    	        	        	        			    	e = expression();
                    	        	        	        			    	followingStackPointer_--;
                    	        	        	        			    	if (failed) return value;
                    	        	        	        			    	if ( backtracking == 0 ) 
                    	        	        	        			    	{
                    	        	        	        			    	  
                    	        	        	        			    	  						inSet.Add(new ExpressionItem(
                    	        	        	        			    	  							e));
                    	        	        	        			    	  					
                    	        	        	        			    	}
                    	        	        	        			    
                    	        	        	        			    }
                    	        	        	        			    break;
                    	        	        	        	
                    	        	        	        			default:
                    	        	        	        			    goto loop31;
                    	        	        	        	    }
                    	        	        	        	} while (true);
                    	        	        	        	
                    	        	        	        	loop31:
                    	        	        	        		;	// Stops C# compiler whinging that label 'loop31' has no statements

                    	        	        	        
                    	        	        	        }
                    	        	        	        break;
                    	        	        	
                    	        	        	}

                    	        	        	Match(input,RPAREN,FOLLOW_RPAREN_in_predicate1367); if (failed) return value;
                    	        	        	if ( backtracking == 0 ) 
                    	        	        	{
                    	        	        	  
                    	        	        	  					if (value == null)
                    	        	        	  					{
                    	        	        	  						value =  new Expression(l, negated ? ExpressionOperator.NotIn : ExpressionOperator.In, inSet);
                    	        	        	  					}
                    	        	        	  				
                    	        	        	}
                    	        	        
                    	        	        }
                    	        	        break;
                    	        	
                    	        	}

                    	        
                    	        }
                    	        break;
                    	
                    	}

                    
                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:325:4: EXISTS LPAREN s= selectStatement RPAREN
                    {
                    	Match(input,EXISTS,FOLLOW_EXISTS_in_predicate1382); if (failed) return value;
                    	Match(input,LPAREN,FOLLOW_LPAREN_in_predicate1384); if (failed) return value;
                    	PushFollow(FOLLOW_selectStatement_in_predicate1390);
                    	s = selectStatement();
                    	followingStackPointer_--;
                    	if (failed) return value;
                    	Match(input,RPAREN,FOLLOW_RPAREN_in_predicate1392); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	  
                    	  		value =  new Expression();
                    	  		((Expression)value).Operator = ExpressionOperator.Exists;
                    	  		((Expression)value).Right = s;
                    	  	
                    	}
                    
                    }
                    break;
            
            }
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end predicate

    
    // $ANTLR start quantifierSpec
    // MacroScope\\MacroScope.g:332:1: quantifierSpec returns [ PredicateQuantifier value ] : ( ALL | SOME | ANY );
    public PredicateQuantifier quantifierSpec() // throws RecognitionException [1]
    {   

        PredicateQuantifier value = null;
    
        try 
    	{
            // MacroScope\\MacroScope.g:332:54: ( ALL | SOME | ANY )
            int alt36 = 3;
            switch ( input.LA(1) ) 
            {
            case ALL:
            	{
                alt36 = 1;
                }
                break;
            case SOME:
            	{
                alt36 = 2;
                }
                break;
            case ANY:
            	{
                alt36 = 3;
                }
                break;
            	default:
            	    if ( backtracking > 0 ) {failed = true; return value;}
            	    NoViableAltException nvae_d36s0 =
            	        new NoViableAltException("332:1: quantifierSpec returns [ PredicateQuantifier value ] : ( ALL | SOME | ANY );", 36, 0, input);
            
            	    throw nvae_d36s0;
            }
            
            switch (alt36) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:333:2: ALL
                    {
                    	Match(input,ALL,FOLLOW_ALL_in_quantifierSpec1409); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  PredicateQuantifier.All; 
                    	}
                    
                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:334:4: SOME
                    {
                    	Match(input,SOME,FOLLOW_SOME_in_quantifierSpec1416); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  PredicateQuantifier.Any; 
                    	}
                    
                    }
                    break;
                case 3 :
                    // MacroScope\\MacroScope.g:335:4: ANY
                    {
                    	Match(input,ANY,FOLLOW_ANY_in_quantifierSpec1423); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  PredicateQuantifier.Any; 
                    	}
                    
                    }
                    break;
            
            }
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end quantifierSpec

    
    // $ANTLR start selectList
    // MacroScope\\MacroScope.g:338:1: selectList returns [ AliasedItem value ] : s= selectItem ( COMMA t= selectItem )* ;
    public AliasedItem selectList() // throws RecognitionException [1]
    {   

        AliasedItem value = null;
    
        AliasedItem s = null;

        AliasedItem t = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:338:42: (s= selectItem ( COMMA t= selectItem )* )
            // MacroScope\\MacroScope.g:339:2: s= selectItem ( COMMA t= selectItem )*
            {
            	PushFollow(FOLLOW_selectItem_in_selectList1444);
            	s = selectItem();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  s; 
            	}
            	// MacroScope\\MacroScope.g:340:3: ( COMMA t= selectItem )*
            	do 
            	{
            	    int alt37 = 2;
            	    int LA37_0 = input.LA(1);
            	    
            	    if ( (LA37_0 == COMMA) )
            	    {
            	        alt37 = 1;
            	    }
            	    
            	
            	    switch (alt37) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:340:5: COMMA t= selectItem
            			    {
            			    	Match(input,COMMA,FOLLOW_COMMA_in_selectList1452); if (failed) return value;
            			    	PushFollow(FOLLOW_selectItem_in_selectList1458);
            			    	t = selectItem();
            			    	followingStackPointer_--;
            			    	if (failed) return value;
            			    	if ( backtracking == 0 ) 
            			    	{
            			    	   value.Add(t); 
            			    	}
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop37;
            	    }
            	} while (true);
            	
            	loop37:
            		;	// Stops C# compiler whinging that label 'loop37' has no statements

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end selectList

    
    // $ANTLR start selectItem
    // MacroScope\\MacroScope.g:343:1: selectItem returns [ AliasedItem value ] : ( STAR | ( ( alias2 )=> (a= alias2 e= expression ) | ( tableColumns )=>t= tableColumns | e= expression (a= alias1 )? ) );
    public AliasedItem selectItem() // throws RecognitionException [1]
    {   

        AliasedItem value = null;
    
        Identifier a = null;

        IExpression e = null;

        TableWildcard t = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:343:42: ( STAR | ( ( alias2 )=> (a= alias2 e= expression ) | ( tableColumns )=>t= tableColumns | e= expression (a= alias1 )? ) )
            int alt40 = 2;
            int LA40_0 = input.LA(1);
            
            if ( (LA40_0 == STAR) )
            {
                alt40 = 1;
            }
            else if ( (LA40_0 == LPAREN || LA40_0 == Integer || LA40_0 == NULL || (LA40_0 >= LEFT && LA40_0 <= RIGHT) || (LA40_0 >= PLACEHOLDER && LA40_0 <= SUBSTRING) || (LA40_0 >= EXTRACT && LA40_0 <= CASE) || LA40_0 == CAST || (LA40_0 >= UnicodeStringLiteral && LA40_0 <= MINUS)) )
            {
                alt40 = 2;
            }
            else 
            {
                if ( backtracking > 0 ) {failed = true; return value;}
                NoViableAltException nvae_d40s0 =
                    new NoViableAltException("343:1: selectItem returns [ AliasedItem value ] : ( STAR | ( ( alias2 )=> (a= alias2 e= expression ) | ( tableColumns )=>t= tableColumns | e= expression (a= alias1 )? ) );", 40, 0, input);
            
                throw nvae_d40s0;
            }
            switch (alt40) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:344:2: STAR
                    {
                    	Match(input,STAR,FOLLOW_STAR_in_selectItem1478); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	  
                    	  		value =  new AliasedItem(Wildcard.Value);
                    	  	
                    	}
                    
                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:347:4: ( ( alias2 )=> (a= alias2 e= expression ) | ( tableColumns )=>t= tableColumns | e= expression (a= alias1 )? )
                    {
                    	// MacroScope\\MacroScope.g:347:4: ( ( alias2 )=> (a= alias2 e= expression ) | ( tableColumns )=>t= tableColumns | e= expression (a= alias1 )? )
                    	int alt39 = 3;
                    	alt39 = dfa39.Predict(input);
                    	switch (alt39) 
                    	{
                    	    case 1 :
                    	        // MacroScope\\MacroScope.g:349:3: ( alias2 )=> (a= alias2 e= expression )
                    	        {
                    	        	// MacroScope\\MacroScope.g:349:15: (a= alias2 e= expression )
                    	        	// MacroScope\\MacroScope.g:350:4: a= alias2 e= expression
                    	        	{
                    	        		PushFollow(FOLLOW_alias2_in_selectItem1508);
                    	        		a = alias2();
                    	        		followingStackPointer_--;
                    	        		if (failed) return value;
                    	        		PushFollow(FOLLOW_expression_in_selectItem1514);
                    	        		e = expression();
                    	        		followingStackPointer_--;
                    	        		if (failed) return value;
                    	        		if ( backtracking == 0 ) 
                    	        		{
                    	        		  
                    	        		  				value =  new AliasedItem(e);
                    	        		  				value.Alias = a;
                    	        		  			
                    	        		}
                    	        	
                    	        	}

                    	        
                    	        }
                    	        break;
                    	    case 2 :
                    	        // MacroScope\\MacroScope.g:357:5: ( tableColumns )=>t= tableColumns
                    	        {
                    	        	PushFollow(FOLLOW_tableColumns_in_selectItem1540);
                    	        	t = tableColumns();
                    	        	followingStackPointer_--;
                    	        	if (failed) return value;
                    	        	if ( backtracking == 0 ) 
                    	        	{
                    	        	  
                    	        	  			value =  new AliasedItem(t);
                    	        	  		
                    	        	}
                    	        
                    	        }
                    	        break;
                    	    case 3 :
                    	        // MacroScope\\MacroScope.g:361:5: e= expression (a= alias1 )?
                    	        {
                    	        	PushFollow(FOLLOW_expression_in_selectItem1553);
                    	        	e = expression();
                    	        	followingStackPointer_--;
                    	        	if (failed) return value;
                    	        	if ( backtracking == 0 ) 
                    	        	{
                    	        	  
                    	        	  			value =  new AliasedItem(e);
                    	        	  		
                    	        	}
                    	        	// MacroScope\\MacroScope.g:364:4: (a= alias1 )?
                    	        	int alt38 = 2;
                    	        	int LA38_0 = input.LA(1);
                    	        	
                    	        	if ( (LA38_0 == AS || LA38_0 == NonQuotedIdentifier || LA38_0 == QuotedIdentifier) )
                    	        	{
                    	        	    alt38 = 1;
                    	        	}
                    	        	switch (alt38) 
                    	        	{
                    	        	    case 1 :
                    	        	        // MacroScope\\MacroScope.g:364:6: a= alias1
                    	        	        {
                    	        	        	PushFollow(FOLLOW_alias1_in_selectItem1566);
                    	        	        	a = alias1();
                    	        	        	followingStackPointer_--;
                    	        	        	if (failed) return value;
                    	        	        	if ( backtracking == 0 ) 
                    	        	        	{
                    	        	        	   value.Alias = a; 
                    	        	        	}
                    	        	        
                    	        	        }
                    	        	        break;
                    	        	
                    	        	}

                    	        
                    	        }
                    	        break;
                    	
                    	}

                    
                    }
                    break;
            
            }
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end selectItem

    
    // $ANTLR start fromClause
    // MacroScope\\MacroScope.g:368:1: fromClause returns [ AliasedItem value ] : FROM t= tableSource ( COMMA t= tableSource )* ;
    public AliasedItem fromClause() // throws RecognitionException [1]
    {   

        AliasedItem value = null;
    
        Table t = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:368:42: ( FROM t= tableSource ( COMMA t= tableSource )* )
            // MacroScope\\MacroScope.g:369:2: FROM t= tableSource ( COMMA t= tableSource )*
            {
            	Match(input,FROM,FOLLOW_FROM_in_fromClause1589); if (failed) return value;
            	PushFollow(FOLLOW_tableSource_in_fromClause1595);
            	t = tableSource();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  new AliasedItem(t); 
            	}
            	// MacroScope\\MacroScope.g:370:2: ( COMMA t= tableSource )*
            	do 
            	{
            	    int alt41 = 2;
            	    int LA41_0 = input.LA(1);
            	    
            	    if ( (LA41_0 == COMMA) )
            	    {
            	        alt41 = 1;
            	    }
            	    
            	
            	    switch (alt41) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:370:4: COMMA t= tableSource
            			    {
            			    	Match(input,COMMA,FOLLOW_COMMA_in_fromClause1602); if (failed) return value;
            			    	PushFollow(FOLLOW_tableSource_in_fromClause1608);
            			    	t = tableSource();
            			    	followingStackPointer_--;
            			    	if (failed) return value;
            			    	if ( backtracking == 0 ) 
            			    	{
            			    	  
            			    	  		value.Add(new AliasedItem(t));
            			    	  	
            			    	}
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop41;
            	    }
            	} while (true);
            	
            	loop41:
            		;	// Stops C# compiler whinging that label 'loop41' has no statements

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end fromClause

    
    // $ANTLR start tableSource
    // MacroScope\\MacroScope.g:375:1: tableSource returns [ Table value ] : t= subTableSource (t= joinedTable )* ;
    public Table tableSource() // throws RecognitionException [1]
    {   

        Table value = null;
    
        Table t = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:375:37: (t= subTableSource (t= joinedTable )* )
            // MacroScope\\MacroScope.g:376:2: t= subTableSource (t= joinedTable )*
            {
            	PushFollow(FOLLOW_subTableSource_in_tableSource1632);
            	t = subTableSource();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  t; 
            	}
            	// MacroScope\\MacroScope.g:377:2: (t= joinedTable )*
            	do 
            	{
            	    int alt42 = 2;
            	    int LA42_0 = input.LA(1);
            	    
            	    if ( ((LA42_0 >= INNER && LA42_0 <= FULL) || (LA42_0 >= JOIN && LA42_0 <= CROSS)) )
            	    {
            	        alt42 = 1;
            	    }
            	    
            	
            	    switch (alt42) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:377:4: t= joinedTable
            			    {
            			    	PushFollow(FOLLOW_joinedTable_in_tableSource1643);
            			    	t = joinedTable();
            			    	followingStackPointer_--;
            			    	if (failed) return value;
            			    	if ( backtracking == 0 ) 
            			    	{
            			    	   value.Add(t); 
            			    	}
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop42;
            	    }
            	} while (true);
            	
            	loop42:
            		;	// Stops C# compiler whinging that label 'loop42' has no statements

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end tableSource

    
    // $ANTLR start subTableSource
    // MacroScope\\MacroScope.g:380:1: subTableSource returns [ Table value ] : ( LPAREN ( ( joinedTables )=>t= joinedTables RPAREN | ( queryExpression )=>q= queryExpression RPAREN a= alias1 ) | ( function )=>f= function (a= alias1 )? | o= dbObject (a= alias1 )? );
    public Table subTableSource() // throws RecognitionException [1]
    {   

        Table value = null;
    
        Table t = null;

        QueryExpression q = null;

        Identifier a = null;

        IExpression f = null;

        DbObject o = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:380:40: ( LPAREN ( ( joinedTables )=>t= joinedTables RPAREN | ( queryExpression )=>q= queryExpression RPAREN a= alias1 ) | ( function )=>f= function (a= alias1 )? | o= dbObject (a= alias1 )? )
            int alt46 = 3;
            int LA46_0 = input.LA(1);
            
            if ( (LA46_0 == LPAREN) )
            {
                alt46 = 1;
            }
            else if ( (LA46_0 == SUBSTRING) && (synpred7()) )
            {
                alt46 = 2;
            }
            else if ( (LA46_0 == EXTRACT) && (synpred7()) )
            {
                alt46 = 2;
            }
            else if ( (LA46_0 == NonQuotedIdentifier) )
            {
                int LA46_4 = input.LA(2);
                
                if ( (LA46_4 == LPAREN) && (synpred7()) )
                {
                    alt46 = 2;
                }
                else if ( (LA46_4 == EOF || LA46_4 == RPAREN || LA46_4 == COMMA || (LA46_4 >= WHERE && LA46_4 <= ORDER) || LA46_4 == GROUP || (LA46_4 >= INNER && LA46_4 <= FULL) || (LA46_4 >= JOIN && LA46_4 <= AS) || LA46_4 == NonQuotedIdentifier || LA46_4 == DOT || LA46_4 == QuotedIdentifier || LA46_4 == UNION) )
                {
                    alt46 = 3;
                }
                else 
                {
                    if ( backtracking > 0 ) {failed = true; return value;}
                    NoViableAltException nvae_d46s4 =
                        new NoViableAltException("380:1: subTableSource returns [ Table value ] : ( LPAREN ( ( joinedTables )=>t= joinedTables RPAREN | ( queryExpression )=>q= queryExpression RPAREN a= alias1 ) | ( function )=>f= function (a= alias1 )? | o= dbObject (a= alias1 )? );", 46, 4, input);
                
                    throw nvae_d46s4;
                }
            }
            else if ( (LA46_0 == LEFT) && (synpred7()) )
            {
                alt46 = 2;
            }
            else if ( (LA46_0 == RIGHT) && (synpred7()) )
            {
                alt46 = 2;
            }
            else if ( (LA46_0 == QuotedIdentifier) )
            {
                alt46 = 3;
            }
            else 
            {
                if ( backtracking > 0 ) {failed = true; return value;}
                NoViableAltException nvae_d46s0 =
                    new NoViableAltException("380:1: subTableSource returns [ Table value ] : ( LPAREN ( ( joinedTables )=>t= joinedTables RPAREN | ( queryExpression )=>q= queryExpression RPAREN a= alias1 ) | ( function )=>f= function (a= alias1 )? | o= dbObject (a= alias1 )? );", 46, 0, input);
            
                throw nvae_d46s0;
            }
            switch (alt46) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:381:2: LPAREN ( ( joinedTables )=>t= joinedTables RPAREN | ( queryExpression )=>q= queryExpression RPAREN a= alias1 )
                    {
                    	Match(input,LPAREN,FOLLOW_LPAREN_in_subTableSource1663); if (failed) return value;
                    	// MacroScope\\MacroScope.g:381:9: ( ( joinedTables )=>t= joinedTables RPAREN | ( queryExpression )=>q= queryExpression RPAREN a= alias1 )
                    	int alt43 = 2;
                    	int LA43_0 = input.LA(1);
                    	
                    	if ( (LA43_0 == LPAREN) )
                    	{
                    	    int LA43_1 = input.LA(2);
                    	    
                    	    if ( (synpred5()) )
                    	    {
                    	        alt43 = 1;
                    	    }
                    	    else if ( (synpred6()) )
                    	    {
                    	        alt43 = 2;
                    	    }
                    	    else 
                    	    {
                    	        if ( backtracking > 0 ) {failed = true; return value;}
                    	        NoViableAltException nvae_d43s1 =
                    	            new NoViableAltException("381:9: ( ( joinedTables )=>t= joinedTables RPAREN | ( queryExpression )=>q= queryExpression RPAREN a= alias1 )", 43, 1, input);
                    	    
                    	        throw nvae_d43s1;
                    	    }
                    	}
                    	else if ( (LA43_0 == SUBSTRING) && (synpred5()) )
                    	{
                    	    alt43 = 1;
                    	}
                    	else if ( (LA43_0 == EXTRACT) && (synpred5()) )
                    	{
                    	    alt43 = 1;
                    	}
                    	else if ( (LA43_0 == NonQuotedIdentifier) && (synpred5()) )
                    	{
                    	    alt43 = 1;
                    	}
                    	else if ( (LA43_0 == LEFT) && (synpred5()) )
                    	{
                    	    alt43 = 1;
                    	}
                    	else if ( (LA43_0 == RIGHT) && (synpred5()) )
                    	{
                    	    alt43 = 1;
                    	}
                    	else if ( (LA43_0 == QuotedIdentifier) && (synpred5()) )
                    	{
                    	    alt43 = 1;
                    	}
                    	else if ( (LA43_0 == SELECT) && (synpred6()) )
                    	{
                    	    alt43 = 2;
                    	}
                    	else 
                    	{
                    	    if ( backtracking > 0 ) {failed = true; return value;}
                    	    NoViableAltException nvae_d43s0 =
                    	        new NoViableAltException("381:9: ( ( joinedTables )=>t= joinedTables RPAREN | ( queryExpression )=>q= queryExpression RPAREN a= alias1 )", 43, 0, input);
                    	
                    	    throw nvae_d43s0;
                    	}
                    	switch (alt43) 
                    	{
                    	    case 1 :
                    	        // MacroScope\\MacroScope.g:382:3: ( joinedTables )=>t= joinedTables RPAREN
                    	        {
                    	        	PushFollow(FOLLOW_joinedTables_in_subTableSource1682);
                    	        	t = joinedTables();
                    	        	followingStackPointer_--;
                    	        	if (failed) return value;
                    	        	Match(input,RPAREN,FOLLOW_RPAREN_in_subTableSource1684); if (failed) return value;
                    	        	if ( backtracking == 0 ) 
                    	        	{
                    	        	  
                    	        	  				value =  new Table(
                    	        	  					new BracketedExpression(t));
                    	        	  			
                    	        	}
                    	        
                    	        }
                    	        break;
                    	    case 2 :
                    	        // MacroScope\\MacroScope.g:387:5: ( queryExpression )=>q= queryExpression RPAREN a= alias1
                    	        {
                    	        	PushFollow(FOLLOW_queryExpression_in_subTableSource1709);
                    	        	q = queryExpression();
                    	        	followingStackPointer_--;
                    	        	if (failed) return value;
                    	        	Match(input,RPAREN,FOLLOW_RPAREN_in_subTableSource1711); if (failed) return value;
                    	        	PushFollow(FOLLOW_alias1_in_subTableSource1717);
                    	        	a = alias1();
                    	        	followingStackPointer_--;
                    	        	if (failed) return value;
                    	        	if ( backtracking == 0 ) 
                    	        	{
                    	        	  
                    	        	  				BracketedExpression expr =
                    	        	  					new BracketedExpression(q);
                    	        	  				expr.Spaced = true;
                    	        	  				value =  new Table(expr);
                    	        	  				value.Alias = a;
                    	        	  			
                    	        	}
                    	        
                    	        }
                    	        break;
                    	
                    	}

                    
                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:400:4: ( function )=>f= function (a= alias1 )?
                    {
                    	PushFollow(FOLLOW_function_in_subTableSource1752);
                    	f = function();
                    	followingStackPointer_--;
                    	if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	  
                    	  			value =  new Table(f);
                    	  		
                    	}
                    	// MacroScope\\MacroScope.g:404:4: (a= alias1 )?
                    	int alt44 = 2;
                    	int LA44_0 = input.LA(1);
                    	
                    	if ( (LA44_0 == AS || LA44_0 == NonQuotedIdentifier || LA44_0 == QuotedIdentifier) )
                    	{
                    	    alt44 = 1;
                    	}
                    	switch (alt44) 
                    	{
                    	    case 1 :
                    	        // MacroScope\\MacroScope.g:404:6: a= alias1
                    	        {
                    	        	PushFollow(FOLLOW_alias1_in_subTableSource1765);
                    	        	a = alias1();
                    	        	followingStackPointer_--;
                    	        	if (failed) return value;
                    	        	if ( backtracking == 0 ) 
                    	        	{
                    	        	   value.Alias = a; 
                    	        	}
                    	        
                    	        }
                    	        break;
                    	
                    	}

                    
                    }
                    break;
                case 3 :
                    // MacroScope\\MacroScope.g:405:4: o= dbObject (a= alias1 )?
                    {
                    	PushFollow(FOLLOW_dbObject_in_subTableSource1779);
                    	o = dbObject();
                    	followingStackPointer_--;
                    	if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  new Table(o); 
                    	}
                    	// MacroScope\\MacroScope.g:406:3: (a= alias1 )?
                    	int alt45 = 2;
                    	int LA45_0 = input.LA(1);
                    	
                    	if ( (LA45_0 == AS || LA45_0 == NonQuotedIdentifier || LA45_0 == QuotedIdentifier) )
                    	{
                    	    alt45 = 1;
                    	}
                    	switch (alt45) 
                    	{
                    	    case 1 :
                    	        // MacroScope\\MacroScope.g:406:5: a= alias1
                    	        {
                    	        	PushFollow(FOLLOW_alias1_in_subTableSource1791);
                    	        	a = alias1();
                    	        	followingStackPointer_--;
                    	        	if (failed) return value;
                    	        	if ( backtracking == 0 ) 
                    	        	{
                    	        	   value.Alias = a; 
                    	        	}
                    	        
                    	        }
                    	        break;
                    	
                    	}

                    
                    }
                    break;
            
            }
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end subTableSource

    
    // $ANTLR start joinOn
    // MacroScope\\MacroScope.g:409:1: joinOn returns [ Join value ] : ( INNER | ( LEFT | RIGHT | FULL ) ( OUTER )? )? JOIN ;
    public Join joinOn() // throws RecognitionException [1]
    {   

        Join value = null;
    
        try 
    	{
            // MacroScope\\MacroScope.g:409:31: ( ( INNER | ( LEFT | RIGHT | FULL ) ( OUTER )? )? JOIN )
            // MacroScope\\MacroScope.g:410:2: ( INNER | ( LEFT | RIGHT | FULL ) ( OUTER )? )? JOIN
            {
            	// MacroScope\\MacroScope.g:410:2: ( INNER | ( LEFT | RIGHT | FULL ) ( OUTER )? )?
            	int alt49 = 3;
            	int LA49_0 = input.LA(1);
            	
            	if ( (LA49_0 == INNER) )
            	{
            	    alt49 = 1;
            	}
            	else if ( ((LA49_0 >= LEFT && LA49_0 <= FULL)) )
            	{
            	    alt49 = 2;
            	}
            	switch (alt49) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:410:4: INNER
            	        {
            	        	Match(input,INNER,FOLLOW_INNER_in_joinOn1813); if (failed) return value;
            	        
            	        }
            	        break;
            	    case 2 :
            	        // MacroScope\\MacroScope.g:411:4: ( LEFT | RIGHT | FULL ) ( OUTER )?
            	        {
            	        	// MacroScope\\MacroScope.g:411:4: ( LEFT | RIGHT | FULL )
            	        	int alt47 = 3;
            	        	switch ( input.LA(1) ) 
            	        	{
            	        	case LEFT:
            	        		{
            	        	    alt47 = 1;
            	        	    }
            	        	    break;
            	        	case RIGHT:
            	        		{
            	        	    alt47 = 2;
            	        	    }
            	        	    break;
            	        	case FULL:
            	        		{
            	        	    alt47 = 3;
            	        	    }
            	        	    break;
            	        		default:
            	        		    if ( backtracking > 0 ) {failed = true; return value;}
            	        		    NoViableAltException nvae_d47s0 =
            	        		        new NoViableAltException("411:4: ( LEFT | RIGHT | FULL )", 47, 0, input);
            	        	
            	        		    throw nvae_d47s0;
            	        	}
            	        	
            	        	switch (alt47) 
            	        	{
            	        	    case 1 :
            	        	        // MacroScope\\MacroScope.g:411:6: LEFT
            	        	        {
            	        	        	Match(input,LEFT,FOLLOW_LEFT_in_joinOn1820); if (failed) return value;
            	        	        	if ( backtracking == 0 ) 
            	        	        	{
            	        	        	   value =  Join.Left; 
            	        	        	}
            	        	        
            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // MacroScope\\MacroScope.g:412:5: RIGHT
            	        	        {
            	        	        	Match(input,RIGHT,FOLLOW_RIGHT_in_joinOn1828); if (failed) return value;
            	        	        	if ( backtracking == 0 ) 
            	        	        	{
            	        	        	   value =  Join.Right; 
            	        	        	}
            	        	        
            	        	        }
            	        	        break;
            	        	    case 3 :
            	        	        // MacroScope\\MacroScope.g:413:5: FULL
            	        	        {
            	        	        	Match(input,FULL,FOLLOW_FULL_in_joinOn1836); if (failed) return value;
            	        	        	if ( backtracking == 0 ) 
            	        	        	{
            	        	        	   value =  Join.Full; 
            	        	        	}
            	        	        
            	        	        }
            	        	        break;
            	        	
            	        	}

            	        	// MacroScope\\MacroScope.g:414:3: ( OUTER )?
            	        	int alt48 = 2;
            	        	int LA48_0 = input.LA(1);
            	        	
            	        	if ( (LA48_0 == OUTER) )
            	        	{
            	        	    alt48 = 1;
            	        	}
            	        	switch (alt48) 
            	        	{
            	        	    case 1 :
            	        	        // MacroScope\\MacroScope.g:414:5: OUTER
            	        	        {
            	        	        	Match(input,OUTER,FOLLOW_OUTER_in_joinOn1846); if (failed) return value;
            	        	        
            	        	        }
            	        	        break;
            	        	
            	        	}

            	        
            	        }
            	        break;
            	
            	}

            	Match(input,JOIN,FOLLOW_JOIN_in_joinOn1856); if (failed) return value;
            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end joinOn

    
    // $ANTLR start joinedTable
    // MacroScope\\MacroScope.g:418:1: joinedTable returns [ Table value ] : ( CROSS JOIN t= subTableSource | (j= joinOn t= tableSource ON c= searchCondition ) );
    public Table joinedTable() // throws RecognitionException [1]
    {   

        Table value = null;
    
        Table t = null;

        Join j = null;

        IExpression c = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:418:37: ( CROSS JOIN t= subTableSource | (j= joinOn t= tableSource ON c= searchCondition ) )
            int alt50 = 2;
            int LA50_0 = input.LA(1);
            
            if ( (LA50_0 == CROSS) )
            {
                alt50 = 1;
            }
            else if ( ((LA50_0 >= INNER && LA50_0 <= FULL) || LA50_0 == JOIN) )
            {
                alt50 = 2;
            }
            else 
            {
                if ( backtracking > 0 ) {failed = true; return value;}
                NoViableAltException nvae_d50s0 =
                    new NoViableAltException("418:1: joinedTable returns [ Table value ] : ( CROSS JOIN t= subTableSource | (j= joinOn t= tableSource ON c= searchCondition ) );", 50, 0, input);
            
                throw nvae_d50s0;
            }
            switch (alt50) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:419:2: CROSS JOIN t= subTableSource
                    {
                    	Match(input,CROSS,FOLLOW_CROSS_in_joinedTable1871); if (failed) return value;
                    	Match(input,JOIN,FOLLOW_JOIN_in_joinedTable1873); if (failed) return value;
                    	PushFollow(FOLLOW_subTableSource_in_joinedTable1879);
                    	t = subTableSource();
                    	followingStackPointer_--;
                    	if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	  
                    	  		value =  t;
                    	  		value.JoinType = Join.Cross;
                    	  	
                    	}
                    
                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:423:4: (j= joinOn t= tableSource ON c= searchCondition )
                    {
                    	// MacroScope\\MacroScope.g:423:4: (j= joinOn t= tableSource ON c= searchCondition )
                    	// MacroScope\\MacroScope.g:424:3: j= joinOn t= tableSource ON c= searchCondition
                    	{
                    		PushFollow(FOLLOW_joinOn_in_joinedTable1894);
                    		j = joinOn();
                    		followingStackPointer_--;
                    		if (failed) return value;
                    		PushFollow(FOLLOW_tableSource_in_joinedTable1903);
                    		t = tableSource();
                    		followingStackPointer_--;
                    		if (failed) return value;
                    		if ( backtracking == 0 ) 
                    		{
                    		  
                    		  				value =  t;
                    		  				value.JoinType = (j == null) ?
                    		  					Join.Inner :
                    		  					j;
                    		  			
                    		}
                    		Match(input,ON,FOLLOW_ON_in_joinedTable1910); if (failed) return value;
                    		PushFollow(FOLLOW_searchCondition_in_joinedTable1916);
                    		c = searchCondition();
                    		followingStackPointer_--;
                    		if (failed) return value;
                    		if ( backtracking == 0 ) 
                    		{
                    		  
                    		  				value.JoinCondition = c;
                    		  			
                    		}
                    	
                    	}

                    
                    }
                    break;
            
            }
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end joinedTable

    
    // $ANTLR start joinedTables
    // MacroScope\\MacroScope.g:437:1: joinedTables returns [ Table value ] : t= subTableSource (t= joinedTable )+ ;
    public Table joinedTables() // throws RecognitionException [1]
    {   

        Table value = null;
    
        Table t = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:437:38: (t= subTableSource (t= joinedTable )+ )
            // MacroScope\\MacroScope.g:438:2: t= subTableSource (t= joinedTable )+
            {
            	PushFollow(FOLLOW_subTableSource_in_joinedTables1941);
            	t = subTableSource();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  t; 
            	}
            	// MacroScope\\MacroScope.g:439:3: (t= joinedTable )+
            	int cnt51 = 0;
            	do 
            	{
            	    int alt51 = 2;
            	    int LA51_0 = input.LA(1);
            	    
            	    if ( ((LA51_0 >= INNER && LA51_0 <= FULL) || (LA51_0 >= JOIN && LA51_0 <= CROSS)) )
            	    {
            	        alt51 = 1;
            	    }
            	    
            	
            	    switch (alt51) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:439:5: t= joinedTable
            			    {
            			    	PushFollow(FOLLOW_joinedTable_in_joinedTables1953);
            			    	t = joinedTable();
            			    	followingStackPointer_--;
            			    	if (failed) return value;
            			    	if ( backtracking == 0 ) 
            			    	{
            			    	   value.Add(t); 
            			    	}
            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt51 >= 1 ) goto loop51;
            			    if ( backtracking > 0 ) {failed = true; return value;}
            		            EarlyExitException eee =
            		                new EarlyExitException(51, input);
            		            throw eee;
            	    }
            	    cnt51++;
            	} while (true);
            	
            	loop51:
            		;	// Stops C# compiler whinging that label 'loop51' has no statements

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end joinedTables

    
    // $ANTLR start alias1
    // MacroScope\\MacroScope.g:444:1: alias1 returns [ Identifier value ] : ( AS )? i= identifier ;
    public Identifier alias1() // throws RecognitionException [1]
    {   

        Identifier value = null;
    
        Identifier i = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:444:37: ( ( AS )? i= identifier )
            // MacroScope\\MacroScope.g:445:2: ( AS )? i= identifier
            {
            	// MacroScope\\MacroScope.g:445:2: ( AS )?
            	int alt52 = 2;
            	int LA52_0 = input.LA(1);
            	
            	if ( (LA52_0 == AS) )
            	{
            	    alt52 = 1;
            	}
            	switch (alt52) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:445:3: AS
            	        {
            	        	Match(input,AS,FOLLOW_AS_in_alias11976); if (failed) return value;
            	        
            	        }
            	        break;
            	
            	}

            	PushFollow(FOLLOW_identifier_in_alias11984);
            	i = identifier();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  i; 
            	}
            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end alias1

    
    // $ANTLR start alias2
    // MacroScope\\MacroScope.g:448:1: alias2 returns [ Identifier value ] : i= identifier ASSIGNEQUAL ;
    public Identifier alias2() // throws RecognitionException [1]
    {   

        Identifier value = null;
    
        Identifier i = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:448:37: (i= identifier ASSIGNEQUAL )
            // MacroScope\\MacroScope.g:449:2: i= identifier ASSIGNEQUAL
            {
            	PushFollow(FOLLOW_identifier_in_alias22005);
            	i = identifier();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  i; 
            	}
            	Match(input,ASSIGNEQUAL,FOLLOW_ASSIGNEQUAL_in_alias22011); if (failed) return value;
            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end alias2

    
    // $ANTLR start tableColumns
    // MacroScope\\MacroScope.g:453:1: tableColumns returns [ TableWildcard value ] : o= dbObject DOT_STAR ;
    public TableWildcard tableColumns() // throws RecognitionException [1]
    {   

        TableWildcard value = null;
    
        DbObject o = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:453:46: (o= dbObject DOT_STAR )
            // MacroScope\\MacroScope.g:454:2: o= dbObject DOT_STAR
            {
            	PushFollow(FOLLOW_dbObject_in_tableColumns2030);
            	o = dbObject();
            	followingStackPointer_--;
            	if (failed) return value;
            	Match(input,DOT_STAR,FOLLOW_DOT_STAR_in_tableColumns2032); if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  new TableWildcard(o); 
            	}
            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end tableColumns

    
    // $ANTLR start column
    // MacroScope\\MacroScope.g:458:1: column returns [ DbObject value ] : (o= dbObject | LPAREN o= column RPAREN );
    public DbObject column() // throws RecognitionException [1]
    {   

        DbObject value = null;
    
        DbObject o = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:458:35: (o= dbObject | LPAREN o= column RPAREN )
            int alt53 = 2;
            int LA53_0 = input.LA(1);
            
            if ( (LA53_0 == NonQuotedIdentifier || LA53_0 == QuotedIdentifier) )
            {
                alt53 = 1;
            }
            else if ( (LA53_0 == LPAREN) )
            {
                alt53 = 2;
            }
            else 
            {
                if ( backtracking > 0 ) {failed = true; return value;}
                NoViableAltException nvae_d53s0 =
                    new NoViableAltException("458:1: column returns [ DbObject value ] : (o= dbObject | LPAREN o= column RPAREN );", 53, 0, input);
            
                throw nvae_d53s0;
            }
            switch (alt53) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:459:2: o= dbObject
                    {
                    	PushFollow(FOLLOW_dbObject_in_column2054);
                    	o = dbObject();
                    	followingStackPointer_--;
                    	if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  o; 
                    	}
                    
                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:461:4: LPAREN o= column RPAREN
                    {
                    	Match(input,LPAREN,FOLLOW_LPAREN_in_column2063); if (failed) return value;
                    	PushFollow(FOLLOW_column_in_column2069);
                    	o = column();
                    	followingStackPointer_--;
                    	if (failed) return value;
                    	Match(input,RPAREN,FOLLOW_RPAREN_in_column2071); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  o; 
                    	}
                    
                    }
                    break;
            
            }
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end column

    
    // $ANTLR start expression
    // MacroScope\\MacroScope.g:464:1: expression returns [ IExpression value ] : e= additiveSubExpression (o= additiveOperator r= additiveSubExpression )* ;
    public IExpression expression() // throws RecognitionException [1]
    {   

        IExpression value = null;
    
        IExpression e = null;

        ExpressionOperator o = null;

        IExpression r = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:464:42: (e= additiveSubExpression (o= additiveOperator r= additiveSubExpression )* )
            // MacroScope\\MacroScope.g:465:2: e= additiveSubExpression (o= additiveOperator r= additiveSubExpression )*
            {
            	PushFollow(FOLLOW_additiveSubExpression_in_expression2092);
            	e = additiveSubExpression();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  e; 
            	}
            	// MacroScope\\MacroScope.g:466:2: (o= additiveOperator r= additiveSubExpression )*
            	do 
            	{
            	    int alt54 = 2;
            	    int LA54_0 = input.LA(1);
            	    
            	    if ( ((LA54_0 >= PLUS && LA54_0 <= STRCONCAT)) )
            	    {
            	        alt54 = 1;
            	    }
            	    
            	
            	    switch (alt54) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:466:4: o= additiveOperator r= additiveSubExpression
            			    {
            			    	PushFollow(FOLLOW_additiveOperator_in_expression2103);
            			    	o = additiveOperator();
            			    	followingStackPointer_--;
            			    	if (failed) return value;
            			    	PushFollow(FOLLOW_additiveSubExpression_in_expression2109);
            			    	r = additiveSubExpression();
            			    	followingStackPointer_--;
            			    	if (failed) return value;
            			    	if ( backtracking == 0 ) 
            			    	{
            			    	  
            			    	  		value =  new Expression(value, o,
            			    	  			r);
            			    	  	
            			    	}
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop54;
            	    }
            	} while (true);
            	
            	loop54:
            		;	// Stops C# compiler whinging that label 'loop54' has no statements

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end expression

    
    // $ANTLR start additiveSubExpression
    // MacroScope\\MacroScope.g:472:1: additiveSubExpression returns [ IExpression value ] : e= subExpression (o= multiplicativeArithmeticOperator r= subExpression )* ;
    public IExpression additiveSubExpression() // throws RecognitionException [1]
    {   

        IExpression value = null;
    
        IExpression e = null;

        ExpressionOperator o = null;

        IExpression r = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:472:53: (e= subExpression (o= multiplicativeArithmeticOperator r= subExpression )* )
            // MacroScope\\MacroScope.g:473:2: e= subExpression (o= multiplicativeArithmeticOperator r= subExpression )*
            {
            	PushFollow(FOLLOW_subExpression_in_additiveSubExpression2134);
            	e = subExpression();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  e; 
            	}
            	// MacroScope\\MacroScope.g:474:2: (o= multiplicativeArithmeticOperator r= subExpression )*
            	do 
            	{
            	    int alt55 = 2;
            	    int LA55_0 = input.LA(1);
            	    
            	    if ( (LA55_0 == STAR || (LA55_0 >= DIVIDE && LA55_0 <= MOD)) )
            	    {
            	        alt55 = 1;
            	    }
            	    
            	
            	    switch (alt55) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:474:4: o= multiplicativeArithmeticOperator r= subExpression
            			    {
            			    	PushFollow(FOLLOW_multiplicativeArithmeticOperator_in_additiveSubExpression2145);
            			    	o = multiplicativeArithmeticOperator();
            			    	followingStackPointer_--;
            			    	if (failed) return value;
            			    	PushFollow(FOLLOW_subExpression_in_additiveSubExpression2151);
            			    	r = subExpression();
            			    	followingStackPointer_--;
            			    	if (failed) return value;
            			    	if ( backtracking == 0 ) 
            			    	{
            			    	  
            			    	  		value =  new Expression(value, o,
            			    	  			r);
            			    	  	
            			    	}
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop55;
            	    }
            	} while (true);
            	
            	loop55:
            		;	// Stops C# compiler whinging that label 'loop55' has no statements

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end additiveSubExpression

    
    // $ANTLR start bracketedTerm
    // MacroScope\\MacroScope.g:480:1: bracketedTerm returns [ IExpression value ] : LPAREN ( ( selectStatement )=>s= selectStatement RPAREN | e= expression RPAREN ) ;
    public IExpression bracketedTerm() // throws RecognitionException [1]
    {   

        IExpression value = null;
    
        SelectStatement s = null;

        IExpression e = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:480:45: ( LPAREN ( ( selectStatement )=>s= selectStatement RPAREN | e= expression RPAREN ) )
            // MacroScope\\MacroScope.g:481:2: LPAREN ( ( selectStatement )=>s= selectStatement RPAREN | e= expression RPAREN )
            {
            	Match(input,LPAREN,FOLLOW_LPAREN_in_bracketedTerm2171); if (failed) return value;
            	// MacroScope\\MacroScope.g:481:9: ( ( selectStatement )=>s= selectStatement RPAREN | e= expression RPAREN )
            	int alt56 = 2;
            	int LA56_0 = input.LA(1);
            	
            	if ( (LA56_0 == SELECT) && (synpred8()) )
            	{
            	    alt56 = 1;
            	}
            	else if ( (LA56_0 == LPAREN) )
            	{
            	    int LA56_2 = input.LA(2);
            	    
            	    if ( (synpred8()) )
            	    {
            	        alt56 = 1;
            	    }
            	    else if ( (true) )
            	    {
            	        alt56 = 2;
            	    }
            	    else 
            	    {
            	        if ( backtracking > 0 ) {failed = true; return value;}
            	        NoViableAltException nvae_d56s2 =
            	            new NoViableAltException("481:9: ( ( selectStatement )=>s= selectStatement RPAREN | e= expression RPAREN )", 56, 2, input);
            	    
            	        throw nvae_d56s2;
            	    }
            	}
            	else if ( (LA56_0 == Integer || LA56_0 == NULL || (LA56_0 >= LEFT && LA56_0 <= RIGHT) || (LA56_0 >= PLACEHOLDER && LA56_0 <= SUBSTRING) || (LA56_0 >= EXTRACT && LA56_0 <= CASE) || LA56_0 == CAST || (LA56_0 >= UnicodeStringLiteral && LA56_0 <= MINUS)) )
            	{
            	    alt56 = 2;
            	}
            	else 
            	{
            	    if ( backtracking > 0 ) {failed = true; return value;}
            	    NoViableAltException nvae_d56s0 =
            	        new NoViableAltException("481:9: ( ( selectStatement )=>s= selectStatement RPAREN | e= expression RPAREN )", 56, 0, input);
            	
            	    throw nvae_d56s0;
            	}
            	switch (alt56) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:481:11: ( selectStatement )=>s= selectStatement RPAREN
            	        {
            	        	PushFollow(FOLLOW_selectStatement_in_bracketedTerm2189);
            	        	s = selectStatement();
            	        	followingStackPointer_--;
            	        	if (failed) return value;
            	        	Match(input,RPAREN,FOLLOW_RPAREN_in_bracketedTerm2191); if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	  
            	        	  				value =  new BracketedExpression(s);
            	        	  				((BracketedExpression)value).Spaced = true;
            	        	  			
            	        	}
            	        
            	        }
            	        break;
            	    case 2 :
            	        // MacroScope\\MacroScope.g:486:5: e= expression RPAREN
            	        {
            	        	PushFollow(FOLLOW_expression_in_bracketedTerm2203);
            	        	e = expression();
            	        	followingStackPointer_--;
            	        	if (failed) return value;
            	        	Match(input,RPAREN,FOLLOW_RPAREN_in_bracketedTerm2205); if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	  
            	        	  			value =  e;
            	        	  		
            	        	}
            	        
            	        }
            	        break;
            	
            	}

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end bracketedTerm

    
    // $ANTLR start subExpression
    // MacroScope\\MacroScope.g:491:1: subExpression returns [ IExpression value ] : (o= unaryOperator )? (c= constant | v= variableReference | PLACEHOLDER | ( function )=>f= function | e= bracketedTerm | d= dbObject | p= caseFunction | q= castFunction ) ;
    public IExpression subExpression() // throws RecognitionException [1]
    {   

        IExpression value = null;
    
        ExpressionOperator o = null;

        INode c = null;

        Variable v = null;

        IExpression f = null;

        IExpression e = null;

        DbObject d = null;

        CaseExpression p = null;

        TypeCast q = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:491:45: ( (o= unaryOperator )? (c= constant | v= variableReference | PLACEHOLDER | ( function )=>f= function | e= bracketedTerm | d= dbObject | p= caseFunction | q= castFunction ) )
            // MacroScope\\MacroScope.g:492:2: (o= unaryOperator )? (c= constant | v= variableReference | PLACEHOLDER | ( function )=>f= function | e= bracketedTerm | d= dbObject | p= caseFunction | q= castFunction )
            {
            	// MacroScope\\MacroScope.g:492:2: (o= unaryOperator )?
            	int alt57 = 2;
            	int LA57_0 = input.LA(1);
            	
            	if ( ((LA57_0 >= PLUS && LA57_0 <= MINUS)) )
            	{
            	    alt57 = 1;
            	}
            	switch (alt57) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:492:4: o= unaryOperator
            	        {
            	        	PushFollow(FOLLOW_unaryOperator_in_subExpression2230);
            	        	o = unaryOperator();
            	        	followingStackPointer_--;
            	        	if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	  
            	        	  		value =  new Expression();
            	        	  		((Expression)value).Operator = o;
            	        	  	
            	        	}
            	        
            	        }
            	        break;
            	
            	}

            	// MacroScope\\MacroScope.g:495:7: (c= constant | v= variableReference | PLACEHOLDER | ( function )=>f= function | e= bracketedTerm | d= dbObject | p= caseFunction | q= castFunction )
            	int alt58 = 8;
            	int LA58_0 = input.LA(1);
            	
            	if ( (LA58_0 == Integer || LA58_0 == NULL || (LA58_0 >= UnicodeStringLiteral && LA58_0 <= AsciiStringLiteral) || (LA58_0 >= Real && LA58_0 <= INTERVAL)) )
            	{
            	    alt58 = 1;
            	}
            	else if ( (LA58_0 == Variable) )
            	{
            	    alt58 = 2;
            	}
            	else if ( (LA58_0 == PLACEHOLDER) )
            	{
            	    alt58 = 3;
            	}
            	else if ( (LA58_0 == SUBSTRING) && (synpred9()) )
            	{
            	    alt58 = 4;
            	}
            	else if ( (LA58_0 == EXTRACT) && (synpred9()) )
            	{
            	    alt58 = 4;
            	}
            	else if ( (LA58_0 == NonQuotedIdentifier) )
            	{
            	    int LA58_6 = input.LA(2);
            	    
            	    if ( (LA58_6 == LPAREN) && (synpred9()) )
            	    {
            	        alt58 = 4;
            	    }
            	    else if ( (LA58_6 == EOF || LA58_6 == RPAREN || (LA58_6 >= FROM && LA58_6 <= ASSIGNEQUAL) || (LA58_6 >= WHERE && LA58_6 <= ORDER) || (LA58_6 >= ASC && LA58_6 <= IS) || (LA58_6 >= LIKE && LA58_6 <= IN) || (LA58_6 >= STAR && LA58_6 <= FULL) || (LA58_6 >= JOIN && LA58_6 <= AS) || LA58_6 == FOR || LA58_6 == NonQuotedIdentifier || (LA58_6 >= WHEN && LA58_6 <= END) || LA58_6 == DOT || LA58_6 == QuotedIdentifier || (LA58_6 >= PLUS && LA58_6 <= UNION)) )
            	    {
            	        alt58 = 6;
            	    }
            	    else 
            	    {
            	        if ( backtracking > 0 ) {failed = true; return value;}
            	        NoViableAltException nvae_d58s6 =
            	            new NoViableAltException("495:7: (c= constant | v= variableReference | PLACEHOLDER | ( function )=>f= function | e= bracketedTerm | d= dbObject | p= caseFunction | q= castFunction )", 58, 6, input);
            	    
            	        throw nvae_d58s6;
            	    }
            	}
            	else if ( (LA58_0 == LEFT) && (synpred9()) )
            	{
            	    alt58 = 4;
            	}
            	else if ( (LA58_0 == RIGHT) && (synpred9()) )
            	{
            	    alt58 = 4;
            	}
            	else if ( (LA58_0 == LPAREN) )
            	{
            	    alt58 = 5;
            	}
            	else if ( (LA58_0 == QuotedIdentifier) )
            	{
            	    alt58 = 6;
            	}
            	else if ( (LA58_0 == CASE) )
            	{
            	    alt58 = 7;
            	}
            	else if ( (LA58_0 == CAST) )
            	{
            	    alt58 = 8;
            	}
            	else 
            	{
            	    if ( backtracking > 0 ) {failed = true; return value;}
            	    NoViableAltException nvae_d58s0 =
            	        new NoViableAltException("495:7: (c= constant | v= variableReference | PLACEHOLDER | ( function )=>f= function | e= bracketedTerm | d= dbObject | p= caseFunction | q= castFunction )", 58, 0, input);
            	
            	    throw nvae_d58s0;
            	}
            	switch (alt58) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:496:3: c= constant
            	        {
            	        	PushFollow(FOLLOW_constant_in_subExpression2245);
            	        	c = constant();
            	        	followingStackPointer_--;
            	        	if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	  
            	        	  			if (value == null)
            	        	  			{
            	        	  				value =  new Expression();
            	        	  			}
            	        	  
            	        	  			((Expression)value).Right = c;
            	        	  		
            	        	}
            	        
            	        }
            	        break;
            	    case 2 :
            	        // MacroScope\\MacroScope.g:504:5: v= variableReference
            	        {
            	        	PushFollow(FOLLOW_variableReference_in_subExpression2257);
            	        	v = variableReference();
            	        	followingStackPointer_--;
            	        	if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	  
            	        	  			if (value == null)
            	        	  			{
            	        	  				value =  new Expression();
            	        	  			}
            	        	  
            	        	  			((Expression)value).Right = v;
            	        	  		
            	        	}
            	        
            	        }
            	        break;
            	    case 3 :
            	        // MacroScope\\MacroScope.g:512:5: PLACEHOLDER
            	        {
            	        	Match(input,PLACEHOLDER,FOLLOW_PLACEHOLDER_in_subExpression2265); if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	  
            	        	  			if (value == null)
            	        	  			{
            	        	  				value =  new Expression();
            	        	  			}
            	        	  
            	        	  			((Expression)value).Right = Placeholder.Value;
            	        	  		
            	        	}
            	        
            	        }
            	        break;
            	    case 4 :
            	        // MacroScope\\MacroScope.g:520:5: ( function )=>f= function
            	        {
            	        	PushFollow(FOLLOW_function_in_subExpression2286);
            	        	f = function();
            	        	followingStackPointer_--;
            	        	if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	  
            	        	  				if (value == null)
            	        	  				{
            	        	  					// Oracle tailor wanting to replace
            	        	  					// a datetime function will
            	        	  					// appreciate an Expression parent
            	        	  					value =  new Expression();
            	        	  				}
            	        	  
            	        	  				((Expression)value).Right = f;
            	        	  			
            	        	}
            	        
            	        }
            	        break;
            	    case 5 :
            	        // MacroScope\\MacroScope.g:532:5: e= bracketedTerm
            	        {
            	        	PushFollow(FOLLOW_bracketedTerm_in_subExpression2298);
            	        	e = bracketedTerm();
            	        	followingStackPointer_--;
            	        	if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	  
            	        	  			if (value == null)
            	        	  			{
            	        	  				value =  e;
            	        	  			}
            	        	  			else
            	        	  			{
            	        	  				((Expression)value).Right = e;
            	        	  			}
            	        	  		
            	        	}
            	        
            	        }
            	        break;
            	    case 6 :
            	        // MacroScope\\MacroScope.g:542:5: d= dbObject
            	        {
            	        	PushFollow(FOLLOW_dbObject_in_subExpression2310);
            	        	d = dbObject();
            	        	followingStackPointer_--;
            	        	if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	  
            	        	  			if (value == null)
            	        	  			{
            	        	  				value =  new Expression();
            	        	  			}
            	        	  
            	        	  			((Expression)value).Right = d;
            	        	  		
            	        	}
            	        
            	        }
            	        break;
            	    case 7 :
            	        // MacroScope\\MacroScope.g:552:5: p= caseFunction
            	        {
            	        	PushFollow(FOLLOW_caseFunction_in_subExpression2356);
            	        	p = caseFunction();
            	        	followingStackPointer_--;
            	        	if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	  
            	        	  				if (value == null)
            	        	  				{
            	        	  					// tailors wanting to replace this
            	        	  					// object will appreciate
            	        	  					// an Expression parent
            	        	  					value =  new Expression();
            	        	  				}
            	        	  
            	        	  				((Expression)value).Right = p;
            	        	  			
            	        	}
            	        
            	        }
            	        break;
            	    case 8 :
            	        // MacroScope\\MacroScope.g:563:5: q= castFunction
            	        {
            	        	PushFollow(FOLLOW_castFunction_in_subExpression2368);
            	        	q = castFunction();
            	        	followingStackPointer_--;
            	        	if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	  
            	        	  				if (value == null)
            	        	  				{
            	        	  					value =  q;
            	        	  				}
            	        	  				else
            	        	  				{
            	        	  					((Expression)value).Right = q;
            	        	  				}
            	        	  			
            	        	}
            	        
            	        }
            	        break;
            	
            	}

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end subExpression

    
    // $ANTLR start variableReference
    // MacroScope\\MacroScope.g:576:1: variableReference returns [ Variable value ] : Variable ;
    public Variable variableReference() // throws RecognitionException [1]
    {   

        Variable value = null;
    
        IToken Variable2 = null;
    
        try 
    	{
            // MacroScope\\MacroScope.g:576:46: ( Variable )
            // MacroScope\\MacroScope.g:577:2: Variable
            {
            	Variable2 = (IToken)input.LT(1);
            	Match(input,Variable,FOLLOW_Variable_in_variableReference2387); if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  new Variable(Variable2.Text); 
            	}
            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end variableReference

    
    // $ANTLR start function
    // MacroScope\\MacroScope.g:581:1: function returns [ IExpression value ] : ( SUBSTRING LPAREN v= expression FROM s= expression ( FOR l= expression )? RPAREN | EXTRACT LPAREN d= datetimeField FROM s= expression RPAREN | f= genericFunction );
    public IExpression function() // throws RecognitionException [1]
    {   

        IExpression value = null;
    
        IExpression v = null;

        IExpression s = null;

        IExpression l = null;

        DateTimeUnit d = null;

        FunctionCall f = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:581:40: ( SUBSTRING LPAREN v= expression FROM s= expression ( FOR l= expression )? RPAREN | EXTRACT LPAREN d= datetimeField FROM s= expression RPAREN | f= genericFunction )
            int alt60 = 3;
            switch ( input.LA(1) ) 
            {
            case SUBSTRING:
            	{
                alt60 = 1;
                }
                break;
            case EXTRACT:
            	{
                alt60 = 2;
                }
                break;
            case LEFT:
            case RIGHT:
            case NonQuotedIdentifier:
            	{
                alt60 = 3;
                }
                break;
            	default:
            	    if ( backtracking > 0 ) {failed = true; return value;}
            	    NoViableAltException nvae_d60s0 =
            	        new NoViableAltException("581:1: function returns [ IExpression value ] : ( SUBSTRING LPAREN v= expression FROM s= expression ( FOR l= expression )? RPAREN | EXTRACT LPAREN d= datetimeField FROM s= expression RPAREN | f= genericFunction );", 60, 0, input);
            
            	    throw nvae_d60s0;
            }
            
            switch (alt60) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:582:2: SUBSTRING LPAREN v= expression FROM s= expression ( FOR l= expression )? RPAREN
                    {
                    	Match(input,SUBSTRING,FOLLOW_SUBSTRING_in_function2405); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	  
                    	  		value =  new FunctionCall(TailorUtil.SUBSTRING);
                    	  	
                    	}
                    	Match(input,LPAREN,FOLLOW_LPAREN_in_function2409); if (failed) return value;
                    	PushFollow(FOLLOW_expression_in_function2415);
                    	v = expression();
                    	followingStackPointer_--;
                    	if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	  
                    	   			((FunctionCall)value).ExpressionArguments =
                    	  				new ExpressionItem(v);
                    	  		
                    	}
                    	Match(input,FROM,FOLLOW_FROM_in_function2419); if (failed) return value;
                    	PushFollow(FOLLOW_expression_in_function2425);
                    	s = expression();
                    	followingStackPointer_--;
                    	if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	  
                    	  			((FunctionCall)value).ExpressionArguments.Add(
                    	  				new ExpressionItem(s));
                    	  		
                    	}
                    	// MacroScope\\MacroScope.g:590:5: ( FOR l= expression )?
                    	int alt59 = 2;
                    	int LA59_0 = input.LA(1);
                    	
                    	if ( (LA59_0 == FOR) )
                    	{
                    	    alt59 = 1;
                    	}
                    	switch (alt59) 
                    	{
                    	    case 1 :
                    	        // MacroScope\\MacroScope.g:590:7: FOR l= expression
                    	        {
                    	        	Match(input,FOR,FOLLOW_FOR_in_function2431); if (failed) return value;
                    	        	PushFollow(FOLLOW_expression_in_function2437);
                    	        	l = expression();
                    	        	followingStackPointer_--;
                    	        	if (failed) return value;
                    	        	if ( backtracking == 0 ) 
                    	        	{
                    	        	  
                    	        	  				((FunctionCall)value).ExpressionArguments.Add(new ExpressionItem(l));
                    	        	  			
                    	        	}
                    	        
                    	        }
                    	        break;
                    	
                    	}

                    	Match(input,RPAREN,FOLLOW_RPAREN_in_function2444); if (failed) return value;
                    
                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:593:4: EXTRACT LPAREN d= datetimeField FROM s= expression RPAREN
                    {
                    	Match(input,EXTRACT,FOLLOW_EXTRACT_in_function2449); if (failed) return value;
                    	Match(input,LPAREN,FOLLOW_LPAREN_in_function2451); if (failed) return value;
                    	PushFollow(FOLLOW_datetimeField_in_function2457);
                    	d = datetimeField();
                    	followingStackPointer_--;
                    	if (failed) return value;
                    	Match(input,FROM,FOLLOW_FROM_in_function2459); if (failed) return value;
                    	PushFollow(FOLLOW_expression_in_function2465);
                    	s = expression();
                    	followingStackPointer_--;
                    	if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	  
                    	  			value =  new ExtractFunction(d, s);
                    	  		
                    	}
                    	Match(input,RPAREN,FOLLOW_RPAREN_in_function2469); if (failed) return value;
                    
                    }
                    break;
                case 3 :
                    // MacroScope\\MacroScope.g:596:4: f= genericFunction
                    {
                    	PushFollow(FOLLOW_genericFunction_in_function2478);
                    	f = genericFunction();
                    	followingStackPointer_--;
                    	if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	  
                    	  		value =  f;
                    	  	
                    	}
                    
                    }
                    break;
            
            }
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end function

    
    // $ANTLR start genericFunction
    // MacroScope\\MacroScope.g:601:1: genericFunction returns [ FunctionCall value ] : ( NonQuotedIdentifier | LEFT | RIGHT ) LPAREN (e= functionArgument ( COMMA e= functionArgument )* | STAR | ( ALL | DISTINCT ) ( STAR | e= expression ) )? RPAREN ;
    public FunctionCall genericFunction() // throws RecognitionException [1]
    {   

        FunctionCall value = null;
    
        IToken NonQuotedIdentifier3 = null;
        IExpression e = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:601:48: ( ( NonQuotedIdentifier | LEFT | RIGHT ) LPAREN (e= functionArgument ( COMMA e= functionArgument )* | STAR | ( ALL | DISTINCT ) ( STAR | e= expression ) )? RPAREN )
            // MacroScope\\MacroScope.g:603:2: ( NonQuotedIdentifier | LEFT | RIGHT ) LPAREN (e= functionArgument ( COMMA e= functionArgument )* | STAR | ( ALL | DISTINCT ) ( STAR | e= expression ) )? RPAREN
            {
            	// MacroScope\\MacroScope.g:603:2: ( NonQuotedIdentifier | LEFT | RIGHT )
            	int alt61 = 3;
            	switch ( input.LA(1) ) 
            	{
            	case NonQuotedIdentifier:
            		{
            	    alt61 = 1;
            	    }
            	    break;
            	case LEFT:
            		{
            	    alt61 = 2;
            	    }
            	    break;
            	case RIGHT:
            		{
            	    alt61 = 3;
            	    }
            	    break;
            		default:
            		    if ( backtracking > 0 ) {failed = true; return value;}
            		    NoViableAltException nvae_d61s0 =
            		        new NoViableAltException("603:2: ( NonQuotedIdentifier | LEFT | RIGHT )", 61, 0, input);
            	
            		    throw nvae_d61s0;
            	}
            	
            	switch (alt61) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:606:3: NonQuotedIdentifier
            	        {
            	        	NonQuotedIdentifier3 = (IToken)input.LT(1);
            	        	Match(input,NonQuotedIdentifier,FOLLOW_NonQuotedIdentifier_in_genericFunction2507); if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	  
            	        	  			value =  new FunctionCall(NonQuotedIdentifier3.Text);
            	        	  		
            	        	}
            	        
            	        }
            	        break;
            	    case 2 :
            	        // MacroScope\\MacroScope.g:609:5: LEFT
            	        {
            	        	Match(input,LEFT,FOLLOW_LEFT_in_genericFunction2515); if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	  
            	        	  			value =  new FunctionCall(
            	        	  				TailorUtil.LEFT.ToUpper());
            	        	  		
            	        	}
            	        
            	        }
            	        break;
            	    case 3 :
            	        // MacroScope\\MacroScope.g:613:5: RIGHT
            	        {
            	        	Match(input,RIGHT,FOLLOW_RIGHT_in_genericFunction2523); if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	  
            	        	  			value =  new FunctionCall(
            	        	  				TailorUtil.RIGHT.ToUpper());
            	        	  		
            	        	}
            	        
            	        }
            	        break;
            	
            	}

            	Match(input,LPAREN,FOLLOW_LPAREN_in_genericFunction2530); if (failed) return value;
            	// MacroScope\\MacroScope.g:617:11: (e= functionArgument ( COMMA e= functionArgument )* | STAR | ( ALL | DISTINCT ) ( STAR | e= expression ) )?
            	int alt65 = 4;
            	switch ( input.LA(1) ) 
            	{
            	    case LPAREN:
            	    case Integer:
            	    case NULL:
            	    case LEFT:
            	    case RIGHT:
            	    case PLACEHOLDER:
            	    case Variable:
            	    case SUBSTRING:
            	    case EXTRACT:
            	    case NonQuotedIdentifier:
            	    case CASE:
            	    case CAST:
            	    case UnicodeStringLiteral:
            	    case AsciiStringLiteral:
            	    case QuotedIdentifier:
            	    case Real:
            	    case HexLiteral:
            	    case MAccessDateTime:
            	    case Iso8601DateTime:
            	    case INTERVAL:
            	    case PLUS:
            	    case MINUS:
            	    case YEAR:
            	    case MONTH:
            	    case DAY:
            	    case HOUR:
            	    case MINUTE:
            	    case SECOND:
            	    	{
            	        alt65 = 1;
            	        }
            	        break;
            	    case STAR:
            	    	{
            	        alt65 = 2;
            	        }
            	        break;
            	    case ALL:
            	    case DISTINCT:
            	    	{
            	        alt65 = 3;
            	        }
            	        break;
            	}
            	
            	switch (alt65) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:618:3: e= functionArgument ( COMMA e= functionArgument )*
            	        {
            	        	PushFollow(FOLLOW_functionArgument_in_genericFunction2540);
            	        	e = functionArgument();
            	        	followingStackPointer_--;
            	        	if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	  
            	        	   			value.ExpressionArguments =
            	        	  				new ExpressionItem(e);
            	        	  		
            	        	}
            	        	// MacroScope\\MacroScope.g:622:4: ( COMMA e= functionArgument )*
            	        	do 
            	        	{
            	        	    int alt62 = 2;
            	        	    int LA62_0 = input.LA(1);
            	        	    
            	        	    if ( (LA62_0 == COMMA) )
            	        	    {
            	        	        alt62 = 1;
            	        	    }
            	        	    
            	        	
            	        	    switch (alt62) 
            	        		{
            	        			case 1 :
            	        			    // MacroScope\\MacroScope.g:622:6: COMMA e= functionArgument
            	        			    {
            	        			    	Match(input,COMMA,FOLLOW_COMMA_in_genericFunction2549); if (failed) return value;
            	        			    	PushFollow(FOLLOW_functionArgument_in_genericFunction2555);
            	        			    	e = functionArgument();
            	        			    	followingStackPointer_--;
            	        			    	if (failed) return value;
            	        			    	if ( backtracking == 0 ) 
            	        			    	{
            	        			    	  
            	        			    	  				value.ExpressionArguments.Add(
            	        			    	  					new ExpressionItem(e));
            	        			    	  			
            	        			    	}
            	        			    
            	        			    }
            	        			    break;
            	        	
            	        			default:
            	        			    goto loop62;
            	        	    }
            	        	} while (true);
            	        	
            	        	loop62:
            	        		;	// Stops C# compiler whinging that label 'loop62' has no statements

            	        
            	        }
            	        break;
            	    case 2 :
            	        // MacroScope\\MacroScope.g:628:5: STAR
            	        {
            	        	Match(input,STAR,FOLLOW_STAR_in_genericFunction2572); if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	   value.Star = Wildcard.Value; 
            	        	}
            	        
            	        }
            	        break;
            	    case 3 :
            	        // MacroScope\\MacroScope.g:629:12: ( ALL | DISTINCT ) ( STAR | e= expression )
            	        {
            	        	// MacroScope\\MacroScope.g:629:12: ( ALL | DISTINCT )
            	        	int alt63 = 2;
            	        	int LA63_0 = input.LA(1);
            	        	
            	        	if ( (LA63_0 == ALL) )
            	        	{
            	        	    alt63 = 1;
            	        	}
            	        	else if ( (LA63_0 == DISTINCT) )
            	        	{
            	        	    alt63 = 2;
            	        	}
            	        	else 
            	        	{
            	        	    if ( backtracking > 0 ) {failed = true; return value;}
            	        	    NoViableAltException nvae_d63s0 =
            	        	        new NoViableAltException("629:12: ( ALL | DISTINCT )", 63, 0, input);
            	        	
            	        	    throw nvae_d63s0;
            	        	}
            	        	switch (alt63) 
            	        	{
            	        	    case 1 :
            	        	        // MacroScope\\MacroScope.g:629:13: ALL
            	        	        {
            	        	        	Match(input,ALL,FOLLOW_ALL_in_genericFunction2588); if (failed) return value;
            	        	        
            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // MacroScope\\MacroScope.g:629:19: DISTINCT
            	        	        {
            	        	        	Match(input,DISTINCT,FOLLOW_DISTINCT_in_genericFunction2592); if (failed) return value;
            	        	        	if ( backtracking == 0 ) 
            	        	        	{
            	        	        	   value.Distinct = true; 
            	        	        	}
            	        	        
            	        	        }
            	        	        break;
            	        	
            	        	}

            	        	// MacroScope\\MacroScope.g:629:58: ( STAR | e= expression )
            	        	int alt64 = 2;
            	        	int LA64_0 = input.LA(1);
            	        	
            	        	if ( (LA64_0 == STAR) )
            	        	{
            	        	    alt64 = 1;
            	        	}
            	        	else if ( (LA64_0 == LPAREN || LA64_0 == Integer || LA64_0 == NULL || (LA64_0 >= LEFT && LA64_0 <= RIGHT) || (LA64_0 >= PLACEHOLDER && LA64_0 <= SUBSTRING) || (LA64_0 >= EXTRACT && LA64_0 <= CASE) || LA64_0 == CAST || (LA64_0 >= UnicodeStringLiteral && LA64_0 <= MINUS)) )
            	        	{
            	        	    alt64 = 2;
            	        	}
            	        	else 
            	        	{
            	        	    if ( backtracking > 0 ) {failed = true; return value;}
            	        	    NoViableAltException nvae_d64s0 =
            	        	        new NoViableAltException("629:58: ( STAR | e= expression )", 64, 0, input);
            	        	
            	        	    throw nvae_d64s0;
            	        	}
            	        	switch (alt64) 
            	        	{
            	        	    case 1 :
            	        	        // MacroScope\\MacroScope.g:630:4: STAR
            	        	        {
            	        	        	Match(input,STAR,FOLLOW_STAR_in_genericFunction2603); if (failed) return value;
            	        	        	if ( backtracking == 0 ) 
            	        	        	{
            	        	        	   value.Star = Wildcard.Value;
            	        	        	  			
            	        	        	}
            	        	        
            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // MacroScope\\MacroScope.g:633:6: e= expression
            	        	        {
            	        	        	PushFollow(FOLLOW_expression_in_genericFunction2620);
            	        	        	e = expression();
            	        	        	followingStackPointer_--;
            	        	        	if (failed) return value;
            	        	        	if ( backtracking == 0 ) 
            	        	        	{
            	        	        	  
            	        	        	  	 			value.ExpressionArguments =
            	        	        	  					new ExpressionItem(e);
            	        	        	  			
            	        	        	}
            	        	        
            	        	        }
            	        	        break;
            	        	
            	        	}

            	        
            	        }
            	        break;
            	
            	}

            	Match(input,RPAREN,FOLLOW_RPAREN_in_genericFunction2642); if (failed) return value;
            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end genericFunction

    
    // $ANTLR start functionArgument
    // MacroScope\\MacroScope.g:642:1: functionArgument returns [ IExpression value ] : (e= expression | d= datetimeField );
    public IExpression functionArgument() // throws RecognitionException [1]
    {   

        IExpression value = null;
    
        IExpression e = null;

        DateTimeUnit d = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:642:48: (e= expression | d= datetimeField )
            int alt66 = 2;
            int LA66_0 = input.LA(1);
            
            if ( (LA66_0 == LPAREN || LA66_0 == Integer || LA66_0 == NULL || (LA66_0 >= LEFT && LA66_0 <= RIGHT) || (LA66_0 >= PLACEHOLDER && LA66_0 <= SUBSTRING) || (LA66_0 >= EXTRACT && LA66_0 <= CASE) || LA66_0 == CAST || (LA66_0 >= UnicodeStringLiteral && LA66_0 <= MINUS)) )
            {
                alt66 = 1;
            }
            else if ( ((LA66_0 >= YEAR && LA66_0 <= SECOND)) )
            {
                alt66 = 2;
            }
            else 
            {
                if ( backtracking > 0 ) {failed = true; return value;}
                NoViableAltException nvae_d66s0 =
                    new NoViableAltException("642:1: functionArgument returns [ IExpression value ] : (e= expression | d= datetimeField );", 66, 0, input);
            
                throw nvae_d66s0;
            }
            switch (alt66) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:643:2: e= expression
                    {
                    	PushFollow(FOLLOW_expression_in_functionArgument2661);
                    	e = expression();
                    	followingStackPointer_--;
                    	if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	  
                    	  		value =  e;
                    	  	
                    	}
                    
                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:646:4: d= datetimeField
                    {
                    	PushFollow(FOLLOW_datetimeField_in_functionArgument2672);
                    	d = datetimeField();
                    	followingStackPointer_--;
                    	if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	  
                    	  		value =  new Expression();
                    	  		((Expression)value).Left = d;
                    	  	
                    	}
                    
                    }
                    break;
            
            }
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end functionArgument

    
    // $ANTLR start caseFunction
    // MacroScope\\MacroScope.g:652:1: caseFunction returns [ CaseExpression value ] : CASE (e= expression ( WHEN e= expression THEN f= expression )+ | ( WHEN e= searchCondition THEN f= expression )+ ) ( ELSE e= expression )? END ( CASE )? ;
    public CaseExpression caseFunction() // throws RecognitionException [1]
    {   

        CaseExpression value = null;
    
        IExpression e = null;

        IExpression f = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:652:47: ( CASE (e= expression ( WHEN e= expression THEN f= expression )+ | ( WHEN e= searchCondition THEN f= expression )+ ) ( ELSE e= expression )? END ( CASE )? )
            // MacroScope\\MacroScope.g:653:2: CASE (e= expression ( WHEN e= expression THEN f= expression )+ | ( WHEN e= searchCondition THEN f= expression )+ ) ( ELSE e= expression )? END ( CASE )?
            {
            	Match(input,CASE,FOLLOW_CASE_in_caseFunction2689); if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  new CaseExpression(); 
            	}
            	// MacroScope\\MacroScope.g:653:42: (e= expression ( WHEN e= expression THEN f= expression )+ | ( WHEN e= searchCondition THEN f= expression )+ )
            	int alt69 = 2;
            	int LA69_0 = input.LA(1);
            	
            	if ( (LA69_0 == LPAREN || LA69_0 == Integer || LA69_0 == NULL || (LA69_0 >= LEFT && LA69_0 <= RIGHT) || (LA69_0 >= PLACEHOLDER && LA69_0 <= SUBSTRING) || (LA69_0 >= EXTRACT && LA69_0 <= CASE) || LA69_0 == CAST || (LA69_0 >= UnicodeStringLiteral && LA69_0 <= MINUS)) )
            	{
            	    alt69 = 1;
            	}
            	else if ( (LA69_0 == WHEN) )
            	{
            	    alt69 = 2;
            	}
            	else 
            	{
            	    if ( backtracking > 0 ) {failed = true; return value;}
            	    NoViableAltException nvae_d69s0 =
            	        new NoViableAltException("653:42: (e= expression ( WHEN e= expression THEN f= expression )+ | ( WHEN e= searchCondition THEN f= expression )+ )", 69, 0, input);
            	
            	    throw nvae_d69s0;
            	}
            	switch (alt69) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:654:3: e= expression ( WHEN e= expression THEN f= expression )+
            	        {
            	        	PushFollow(FOLLOW_expression_in_caseFunction2701);
            	        	e = expression();
            	        	followingStackPointer_--;
            	        	if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	   value.Case = e; 
            	        	}
            	        	// MacroScope\\MacroScope.g:655:4: ( WHEN e= expression THEN f= expression )+
            	        	int cnt67 = 0;
            	        	do 
            	        	{
            	        	    int alt67 = 2;
            	        	    int LA67_0 = input.LA(1);
            	        	    
            	        	    if ( (LA67_0 == WHEN) )
            	        	    {
            	        	        alt67 = 1;
            	        	    }
            	        	    
            	        	
            	        	    switch (alt67) 
            	        		{
            	        			case 1 :
            	        			    // MacroScope\\MacroScope.g:655:6: WHEN e= expression THEN f= expression
            	        			    {
            	        			    	Match(input,WHEN,FOLLOW_WHEN_in_caseFunction2710); if (failed) return value;
            	        			    	PushFollow(FOLLOW_expression_in_caseFunction2716);
            	        			    	e = expression();
            	        			    	followingStackPointer_--;
            	        			    	if (failed) return value;
            	        			    	Match(input,THEN,FOLLOW_THEN_in_caseFunction2718); if (failed) return value;
            	        			    	PushFollow(FOLLOW_expression_in_caseFunction2724);
            	        			    	f = expression();
            	        			    	followingStackPointer_--;
            	        			    	if (failed) return value;
            	        			    	if ( backtracking == 0 ) 
            	        			    	{
            	        			    	  
            	        			    	  				value.Add(new CaseAlternative(e,
            	        			    	  					f));
            	        			    	  			
            	        			    	}
            	        			    
            	        			    }
            	        			    break;
            	        	
            	        			default:
            	        			    if ( cnt67 >= 1 ) goto loop67;
            	        			    if ( backtracking > 0 ) {failed = true; return value;}
            	        		            EarlyExitException eee =
            	        		                new EarlyExitException(67, input);
            	        		            throw eee;
            	        	    }
            	        	    cnt67++;
            	        	} while (true);
            	        	
            	        	loop67:
            	        		;	// Stops C# compiler whinging that label 'loop67' has no statements

            	        
            	        }
            	        break;
            	    case 2 :
            	        // MacroScope\\MacroScope.g:660:11: ( WHEN e= searchCondition THEN f= expression )+
            	        {
            	        	// MacroScope\\MacroScope.g:660:11: ( WHEN e= searchCondition THEN f= expression )+
            	        	int cnt68 = 0;
            	        	do 
            	        	{
            	        	    int alt68 = 2;
            	        	    int LA68_0 = input.LA(1);
            	        	    
            	        	    if ( (LA68_0 == WHEN) )
            	        	    {
            	        	        alt68 = 1;
            	        	    }
            	        	    
            	        	
            	        	    switch (alt68) 
            	        		{
            	        			case 1 :
            	        			    // MacroScope\\MacroScope.g:660:13: WHEN e= searchCondition THEN f= expression
            	        			    {
            	        			    	Match(input,WHEN,FOLLOW_WHEN_in_caseFunction2745); if (failed) return value;
            	        			    	PushFollow(FOLLOW_searchCondition_in_caseFunction2751);
            	        			    	e = searchCondition();
            	        			    	followingStackPointer_--;
            	        			    	if (failed) return value;
            	        			    	Match(input,THEN,FOLLOW_THEN_in_caseFunction2753); if (failed) return value;
            	        			    	PushFollow(FOLLOW_expression_in_caseFunction2759);
            	        			    	f = expression();
            	        			    	followingStackPointer_--;
            	        			    	if (failed) return value;
            	        			    	if ( backtracking == 0 ) 
            	        			    	{
            	        			    	  
            	        			    	  			value.Add(new CaseAlternative(e,
            	        			    	  				f));
            	        			    	  		
            	        			    	}
            	        			    
            	        			    }
            	        			    break;
            	        	
            	        			default:
            	        			    if ( cnt68 >= 1 ) goto loop68;
            	        			    if ( backtracking > 0 ) {failed = true; return value;}
            	        		            EarlyExitException eee =
            	        		                new EarlyExitException(68, input);
            	        		            throw eee;
            	        	    }
            	        	    cnt68++;
            	        	} while (true);
            	        	
            	        	loop68:
            	        		;	// Stops C# compiler whinging that label 'loop68' has no statements

            	        
            	        }
            	        break;
            	
            	}

            	// MacroScope\\MacroScope.g:665:3: ( ELSE e= expression )?
            	int alt70 = 2;
            	int LA70_0 = input.LA(1);
            	
            	if ( (LA70_0 == ELSE) )
            	{
            	    alt70 = 1;
            	}
            	switch (alt70) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:665:5: ELSE e= expression
            	        {
            	        	Match(input,ELSE,FOLLOW_ELSE_in_caseFunction2780); if (failed) return value;
            	        	PushFollow(FOLLOW_expression_in_caseFunction2786);
            	        	e = expression();
            	        	followingStackPointer_--;
            	        	if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	  
            	        	  			value.Else = e;
            	        	  		
            	        	}
            	        
            	        }
            	        break;
            	
            	}

            	Match(input,END,FOLLOW_END_in_caseFunction2793); if (failed) return value;
            	// MacroScope\\MacroScope.g:667:12: ( CASE )?
            	int alt71 = 2;
            	int LA71_0 = input.LA(1);
            	
            	if ( (LA71_0 == CASE) )
            	{
            	    alt71 = 1;
            	}
            	switch (alt71) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:667:14: CASE
            	        {
            	        	Match(input,CASE,FOLLOW_CASE_in_caseFunction2797); if (failed) return value;
            	        
            	        }
            	        break;
            	
            	}

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end caseFunction

    
    // $ANTLR start castFunction
    // MacroScope\\MacroScope.g:670:1: castFunction returns [ TypeCast value ] : CAST LPAREN e= expression AS t= typeIdentifier ( LPAREN p= nonNegativeInteger ( COMMA p= nonNegativeInteger )? RPAREN )? RPAREN ;
    public TypeCast castFunction() // throws RecognitionException [1]
    {   

        TypeCast value = null;
    
        IExpression e = null;

        string t = null;

        int p = 0;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:670:41: ( CAST LPAREN e= expression AS t= typeIdentifier ( LPAREN p= nonNegativeInteger ( COMMA p= nonNegativeInteger )? RPAREN )? RPAREN )
            // MacroScope\\MacroScope.g:671:2: CAST LPAREN e= expression AS t= typeIdentifier ( LPAREN p= nonNegativeInteger ( COMMA p= nonNegativeInteger )? RPAREN )? RPAREN
            {
            	Match(input,CAST,FOLLOW_CAST_in_castFunction2816); if (failed) return value;
            	Match(input,LPAREN,FOLLOW_LPAREN_in_castFunction2818); if (failed) return value;
            	PushFollow(FOLLOW_expression_in_castFunction2824);
            	e = expression();
            	followingStackPointer_--;
            	if (failed) return value;
            	Match(input,AS,FOLLOW_AS_in_castFunction2826); if (failed) return value;
            	PushFollow(FOLLOW_typeIdentifier_in_castFunction2832);
            	t = typeIdentifier();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	  
            	  		value =  new TypeCast(e, t);
            	  	
            	}
            	// MacroScope\\MacroScope.g:674:3: ( LPAREN p= nonNegativeInteger ( COMMA p= nonNegativeInteger )? RPAREN )?
            	int alt73 = 2;
            	int LA73_0 = input.LA(1);
            	
            	if ( (LA73_0 == LPAREN) )
            	{
            	    alt73 = 1;
            	}
            	switch (alt73) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:674:5: LPAREN p= nonNegativeInteger ( COMMA p= nonNegativeInteger )? RPAREN
            	        {
            	        	Match(input,LPAREN,FOLLOW_LPAREN_in_castFunction2840); if (failed) return value;
            	        	PushFollow(FOLLOW_nonNegativeInteger_in_castFunction2846);
            	        	p = nonNegativeInteger();
            	        	followingStackPointer_--;
            	        	if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	  
            	        	  			value.Precision = p;
            	        	  		
            	        	}
            	        	// MacroScope\\MacroScope.g:676:5: ( COMMA p= nonNegativeInteger )?
            	        	int alt72 = 2;
            	        	int LA72_0 = input.LA(1);
            	        	
            	        	if ( (LA72_0 == COMMA) )
            	        	{
            	        	    alt72 = 1;
            	        	}
            	        	switch (alt72) 
            	        	{
            	        	    case 1 :
            	        	        // MacroScope\\MacroScope.g:676:7: COMMA p= nonNegativeInteger
            	        	        {
            	        	        	Match(input,COMMA,FOLLOW_COMMA_in_castFunction2852); if (failed) return value;
            	        	        	PushFollow(FOLLOW_nonNegativeInteger_in_castFunction2858);
            	        	        	p = nonNegativeInteger();
            	        	        	followingStackPointer_--;
            	        	        	if (failed) return value;
            	        	        	if ( backtracking == 0 ) 
            	        	        	{
            	        	        	  
            	        	        	  				value.SecondPrecision = p;
            	        	        	  			
            	        	        	}
            	        	        
            	        	        }
            	        	        break;
            	        	
            	        	}

            	        	Match(input,RPAREN,FOLLOW_RPAREN_in_castFunction2865); if (failed) return value;
            	        
            	        }
            	        break;
            	
            	}

            	Match(input,RPAREN,FOLLOW_RPAREN_in_castFunction2870); if (failed) return value;
            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end castFunction

    
    // $ANTLR start dbObject
    // MacroScope\\MacroScope.g:681:1: dbObject returns [ DbObject value ] : i= identifier ( DOT i= identifier )* ;
    public DbObject dbObject() // throws RecognitionException [1]
    {   

        DbObject value = null;
    
        Identifier i = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:681:37: (i= identifier ( DOT i= identifier )* )
            // MacroScope\\MacroScope.g:682:2: i= identifier ( DOT i= identifier )*
            {
            	PushFollow(FOLLOW_identifier_in_dbObject2889);
            	i = identifier();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  new DbObject(i); 
            	}
            	// MacroScope\\MacroScope.g:683:2: ( DOT i= identifier )*
            	do 
            	{
            	    int alt74 = 2;
            	    int LA74_0 = input.LA(1);
            	    
            	    if ( (LA74_0 == DOT) )
            	    {
            	        alt74 = 1;
            	    }
            	    
            	
            	    switch (alt74) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:683:4: DOT i= identifier
            			    {
            			    	Match(input,DOT,FOLLOW_DOT_in_dbObject2896); if (failed) return value;
            			    	PushFollow(FOLLOW_identifier_in_dbObject2902);
            			    	i = identifier();
            			    	followingStackPointer_--;
            			    	if (failed) return value;
            			    	if ( backtracking == 0 ) 
            			    	{
            			    	   value.Add(new DbObject(i)); 
            			    	}
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop74;
            	    }
            	} while (true);
            	
            	loop74:
            		;	// Stops C# compiler whinging that label 'loop74' has no statements

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end dbObject

    
    // $ANTLR start stringLiteral
    // MacroScope\\MacroScope.g:689:1: stringLiteral returns [ StringValue value ] : s= singleStringLiteral (s= singleStringLiteral )* ;
    public StringValue stringLiteral() // throws RecognitionException [1]
    {   

        StringValue value = null;
    
        StringValue s = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:689:45: (s= singleStringLiteral (s= singleStringLiteral )* )
            // MacroScope\\MacroScope.g:690:2: s= singleStringLiteral (s= singleStringLiteral )*
            {
            	PushFollow(FOLLOW_singleStringLiteral_in_stringLiteral2930);
            	s = singleStringLiteral();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	  
            	  		value =  s;
            	  	
            	}
            	// MacroScope\\MacroScope.g:692:4: (s= singleStringLiteral )*
            	do 
            	{
            	    int alt75 = 2;
            	    int LA75_0 = input.LA(1);
            	    
            	    if ( ((LA75_0 >= UnicodeStringLiteral && LA75_0 <= AsciiStringLiteral)) )
            	    {
            	        alt75 = 1;
            	    }
            	    
            	
            	    switch (alt75) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:692:6: s= singleStringLiteral
            			    {
            			    	PushFollow(FOLLOW_singleStringLiteral_in_stringLiteral2940);
            			    	s = singleStringLiteral();
            			    	followingStackPointer_--;
            			    	if (failed) return value;
            			    	if ( backtracking == 0 ) 
            			    	{
            			    	  
            			    	  		value.Append(s);
            			    	  		
            			    	}
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop75;
            	    }
            	} while (true);
            	
            	loop75:
            		;	// Stops C# compiler whinging that label 'loop75' has no statements

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end stringLiteral

    
    // $ANTLR start singleStringLiteral
    // MacroScope\\MacroScope.g:697:1: singleStringLiteral returns [ StringValue value ] : ( UnicodeStringLiteral | AsciiStringLiteral );
    public StringValue singleStringLiteral() // throws RecognitionException [1]
    {   

        StringValue value = null;
    
        IToken UnicodeStringLiteral4 = null;
        IToken AsciiStringLiteral5 = null;
    
        try 
    	{
            // MacroScope\\MacroScope.g:697:51: ( UnicodeStringLiteral | AsciiStringLiteral )
            int alt76 = 2;
            int LA76_0 = input.LA(1);
            
            if ( (LA76_0 == UnicodeStringLiteral) )
            {
                alt76 = 1;
            }
            else if ( (LA76_0 == AsciiStringLiteral) )
            {
                alt76 = 2;
            }
            else 
            {
                if ( backtracking > 0 ) {failed = true; return value;}
                NoViableAltException nvae_d76s0 =
                    new NoViableAltException("697:1: singleStringLiteral returns [ StringValue value ] : ( UnicodeStringLiteral | AsciiStringLiteral );", 76, 0, input);
            
                throw nvae_d76s0;
            }
            switch (alt76) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:698:2: UnicodeStringLiteral
                    {
                    	UnicodeStringLiteral4 = (IToken)input.LT(1);
                    	Match(input,UnicodeStringLiteral,FOLLOW_UnicodeStringLiteral_in_singleStringLiteral2960); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	  
                    	  		value =  new StringValue(UnicodeStringLiteral4.Text);
                    	  		value.QuoteType = 'n';
                    	  	
                    	}
                    
                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:702:4: AsciiStringLiteral
                    {
                    	AsciiStringLiteral5 = (IToken)input.LT(1);
                    	Match(input,AsciiStringLiteral,FOLLOW_AsciiStringLiteral_in_singleStringLiteral2967); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	  
                    	  		value =  new StringValue(AsciiStringLiteral5.Text);
                    	  	
                    	}
                    
                    }
                    break;
            
            }
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end singleStringLiteral

    
    // $ANTLR start identifier
    // MacroScope\\MacroScope.g:707:1: identifier returns [ Identifier value ] : ( NonQuotedIdentifier | QuotedIdentifier );
    public Identifier identifier() // throws RecognitionException [1]
    {   

        Identifier value = null;
    
        IToken NonQuotedIdentifier6 = null;
        IToken QuotedIdentifier7 = null;
    
        try 
    	{
            // MacroScope\\MacroScope.g:707:41: ( NonQuotedIdentifier | QuotedIdentifier )
            int alt77 = 2;
            int LA77_0 = input.LA(1);
            
            if ( (LA77_0 == NonQuotedIdentifier) )
            {
                alt77 = 1;
            }
            else if ( (LA77_0 == QuotedIdentifier) )
            {
                alt77 = 2;
            }
            else 
            {
                if ( backtracking > 0 ) {failed = true; return value;}
                NoViableAltException nvae_d77s0 =
                    new NoViableAltException("707:1: identifier returns [ Identifier value ] : ( NonQuotedIdentifier | QuotedIdentifier );", 77, 0, input);
            
                throw nvae_d77s0;
            }
            switch (alt77) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:708:2: NonQuotedIdentifier
                    {
                    	NonQuotedIdentifier6 = (IToken)input.LT(1);
                    	Match(input,NonQuotedIdentifier,FOLLOW_NonQuotedIdentifier_in_identifier2984); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	  
                    	  		value =  new Identifier(NonQuotedIdentifier6.Text);
                    	  	
                    	}
                    
                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:711:4: QuotedIdentifier
                    {
                    	QuotedIdentifier7 = (IToken)input.LT(1);
                    	Match(input,QuotedIdentifier,FOLLOW_QuotedIdentifier_in_identifier2991); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	  
                    	  		value =  new Identifier(QuotedIdentifier7.Text);
                    	  	
                    	}
                    
                    }
                    break;
            
            }
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end identifier

    
    // $ANTLR start typeIdentifier
    // MacroScope\\MacroScope.g:716:1: typeIdentifier returns [ string value ] : NonQuotedIdentifier ;
    public string typeIdentifier() // throws RecognitionException [1]
    {   

        string value = null;
    
        IToken NonQuotedIdentifier8 = null;
    
        try 
    	{
            // MacroScope\\MacroScope.g:716:41: ( NonQuotedIdentifier )
            // MacroScope\\MacroScope.g:717:2: NonQuotedIdentifier
            {
            	NonQuotedIdentifier8 = (IToken)input.LT(1);
            	Match(input,NonQuotedIdentifier,FOLLOW_NonQuotedIdentifier_in_typeIdentifier3008); if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  NonQuotedIdentifier8.Text; 
            	}
            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end typeIdentifier

    
    // $ANTLR start constant
    // MacroScope\\MacroScope.g:720:1: constant returns [ INode value ] : (i= nonNegativeInteger | Real | NULL | s= stringLiteral | j= intervalLiteral | HexLiteral | MAccessDateTime | Iso8601DateTime );
    public INode constant() // throws RecognitionException [1]
    {   

        INode value = null;
    
        IToken Real9 = null;
        IToken HexLiteral10 = null;
        IToken MAccessDateTime11 = null;
        IToken Iso8601DateTime12 = null;
        int i = 0;

        StringValue s = null;

        Interval j = null;
        
    
        try 
    	{
            // MacroScope\\MacroScope.g:720:34: (i= nonNegativeInteger | Real | NULL | s= stringLiteral | j= intervalLiteral | HexLiteral | MAccessDateTime | Iso8601DateTime )
            int alt78 = 8;
            switch ( input.LA(1) ) 
            {
            case Integer:
            	{
                alt78 = 1;
                }
                break;
            case Real:
            	{
                alt78 = 2;
                }
                break;
            case NULL:
            	{
                alt78 = 3;
                }
                break;
            case UnicodeStringLiteral:
            case AsciiStringLiteral:
            	{
                alt78 = 4;
                }
                break;
            case INTERVAL:
            	{
                alt78 = 5;
                }
                break;
            case HexLiteral:
            	{
                alt78 = 6;
                }
                break;
            case MAccessDateTime:
            	{
                alt78 = 7;
                }
                break;
            case Iso8601DateTime:
            	{
                alt78 = 8;
                }
                break;
            	default:
            	    if ( backtracking > 0 ) {failed = true; return value;}
            	    NoViableAltException nvae_d78s0 =
            	        new NoViableAltException("720:1: constant returns [ INode value ] : (i= nonNegativeInteger | Real | NULL | s= stringLiteral | j= intervalLiteral | HexLiteral | MAccessDateTime | Iso8601DateTime );", 78, 0, input);
            
            	    throw nvae_d78s0;
            }
            
            switch (alt78) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:721:2: i= nonNegativeInteger
                    {
                    	PushFollow(FOLLOW_nonNegativeInteger_in_constant3029);
                    	i = nonNegativeInteger();
                    	followingStackPointer_--;
                    	if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  new IntegerValue(i); 
                    	}
                    
                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:722:4: Real
                    {
                    	Real9 = (IToken)input.LT(1);
                    	Match(input,Real,FOLLOW_Real_in_constant3036); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  new DoubleValue(DoubleValue.Parse(Real9.Text)); 
                    	}
                    
                    }
                    break;
                case 3 :
                    // MacroScope\\MacroScope.g:723:4: NULL
                    {
                    	Match(input,NULL,FOLLOW_NULL_in_constant3043); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  NullValue.Value; 
                    	}
                    
                    }
                    break;
                case 4 :
                    // MacroScope\\MacroScope.g:724:4: s= stringLiteral
                    {
                    	PushFollow(FOLLOW_stringLiteral_in_constant3054);
                    	s = stringLiteral();
                    	followingStackPointer_--;
                    	if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  s; 
                    	}
                    
                    }
                    break;
                case 5 :
                    // MacroScope\\MacroScope.g:725:4: j= intervalLiteral
                    {
                    	PushFollow(FOLLOW_intervalLiteral_in_constant3065);
                    	j = intervalLiteral();
                    	followingStackPointer_--;
                    	if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  j; 
                    	}
                    
                    }
                    break;
                case 6 :
                    // MacroScope\\MacroScope.g:726:4: HexLiteral
                    {
                    	HexLiteral10 = (IToken)input.LT(1);
                    	Match(input,HexLiteral,FOLLOW_HexLiteral_in_constant3072); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	  
                    	  		value =  new IntegerValue(
                    	  			IntegerValue.ParseHex(HexLiteral10.Text));
                    	  	
                    	}
                    
                    }
                    break;
                case 7 :
                    // MacroScope\\MacroScope.g:731:4: MAccessDateTime
                    {
                    	MAccessDateTime11 = (IToken)input.LT(1);
                    	Match(input,MAccessDateTime,FOLLOW_MAccessDateTime_in_constant3081); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	  
                    	  		value =  new LiteralDateTime(MAccessDateTime11.Text);
                    	  	
                    	}
                    
                    }
                    break;
                case 8 :
                    // MacroScope\\MacroScope.g:735:4: Iso8601DateTime
                    {
                    	Iso8601DateTime12 = (IToken)input.LT(1);
                    	Match(input,Iso8601DateTime,FOLLOW_Iso8601DateTime_in_constant3090); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	  
                    	  		value =  new LiteralDateTime(Iso8601DateTime12.Text);
                    	  	
                    	}
                    
                    }
                    break;
            
            }
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end constant

    
    // $ANTLR start intervalLiteral
    // MacroScope\\MacroScope.g:741:1: intervalLiteral returns [ Interval value ] : INTERVAL (u= unaryOperator )? AsciiStringLiteral d= datetimeField ( LPAREN Integer RPAREN )? ;
    public Interval intervalLiteral() // throws RecognitionException [1]
    {   

        Interval value = null;
    
        IToken AsciiStringLiteral13 = null;
        IToken Integer14 = null;
        ExpressionOperator u = null;

        DateTimeUnit d = null;
        
    
         bool positive = true; int intervalNumber = 0; 
        try 
    	{
            // MacroScope\\MacroScope.g:742:57: ( INTERVAL (u= unaryOperator )? AsciiStringLiteral d= datetimeField ( LPAREN Integer RPAREN )? )
            // MacroScope\\MacroScope.g:743:2: INTERVAL (u= unaryOperator )? AsciiStringLiteral d= datetimeField ( LPAREN Integer RPAREN )?
            {
            	Match(input,INTERVAL,FOLLOW_INTERVAL_in_intervalLiteral3114); if (failed) return value;
            	// MacroScope\\MacroScope.g:743:11: (u= unaryOperator )?
            	int alt79 = 2;
            	int LA79_0 = input.LA(1);
            	
            	if ( ((LA79_0 >= PLUS && LA79_0 <= MINUS)) )
            	{
            	    alt79 = 1;
            	}
            	switch (alt79) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:743:13: u= unaryOperator
            	        {
            	        	PushFollow(FOLLOW_unaryOperator_in_intervalLiteral3122);
            	        	u = unaryOperator();
            	        	followingStackPointer_--;
            	        	if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	   
            	        	  			positive = (u == ExpressionOperator.Plus);
            	        	  		
            	        	}
            	        
            	        }
            	        break;
            	
            	}

            	AsciiStringLiteral13 = (IToken)input.LT(1);
            	Match(input,AsciiStringLiteral,FOLLOW_AsciiStringLiteral_in_intervalLiteral3129); if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	  
            	  			intervalNumber = Interval.Parse(
            	  				AsciiStringLiteral13.Text);
            	  		
            	}
            	PushFollow(FOLLOW_datetimeField_in_intervalLiteral3137);
            	d = datetimeField();
            	followingStackPointer_--;
            	if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	  
            	  			value =  new Interval(positive, intervalNumber,
            	  				d);
            	  		
            	}
            	// MacroScope\\MacroScope.g:751:5: ( LPAREN Integer RPAREN )?
            	int alt80 = 2;
            	int LA80_0 = input.LA(1);
            	
            	if ( (LA80_0 == LPAREN) )
            	{
            	    alt80 = 1;
            	}
            	switch (alt80) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:751:7: LPAREN Integer RPAREN
            	        {
            	        	Match(input,LPAREN,FOLLOW_LPAREN_in_intervalLiteral3143); if (failed) return value;
            	        	Integer14 = (IToken)input.LT(1);
            	        	Match(input,Integer,FOLLOW_Integer_in_intervalLiteral3145); if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	  
            	        	  			value.Precision = int.Parse(Integer14.Text);
            	        	  		
            	        	}
            	        	Match(input,RPAREN,FOLLOW_RPAREN_in_intervalLiteral3149); if (failed) return value;
            	        
            	        }
            	        break;
            	
            	}

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end intervalLiteral

    
    // $ANTLR start nonNegativeInteger
    // MacroScope\\MacroScope.g:756:1: nonNegativeInteger returns [ int value ] : Integer ;
    public int nonNegativeInteger() // throws RecognitionException [1]
    {   

        int value = 0;
    
        IToken Integer15 = null;
    
        try 
    	{
            // MacroScope\\MacroScope.g:756:42: ( Integer )
            // MacroScope\\MacroScope.g:757:2: Integer
            {
            	Integer15 = (IToken)input.LT(1);
            	Match(input,Integer,FOLLOW_Integer_in_nonNegativeInteger3167); if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  int.Parse(Integer15.Text); 
            	}
            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end nonNegativeInteger

    
    // $ANTLR start unaryOperator
    // MacroScope\\MacroScope.g:760:1: unaryOperator returns [ ExpressionOperator value ] : ( PLUS | MINUS );
    public ExpressionOperator unaryOperator() // throws RecognitionException [1]
    {   

        ExpressionOperator value = null;
    
        try 
    	{
            // MacroScope\\MacroScope.g:760:52: ( PLUS | MINUS )
            int alt81 = 2;
            int LA81_0 = input.LA(1);
            
            if ( (LA81_0 == PLUS) )
            {
                alt81 = 1;
            }
            else if ( (LA81_0 == MINUS) )
            {
                alt81 = 2;
            }
            else 
            {
                if ( backtracking > 0 ) {failed = true; return value;}
                NoViableAltException nvae_d81s0 =
                    new NoViableAltException("760:1: unaryOperator returns [ ExpressionOperator value ] : ( PLUS | MINUS );", 81, 0, input);
            
                throw nvae_d81s0;
            }
            switch (alt81) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:761:2: PLUS
                    {
                    	Match(input,PLUS,FOLLOW_PLUS_in_unaryOperator3184); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  ExpressionOperator.Plus; 
                    	}
                    
                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:762:4: MINUS
                    {
                    	Match(input,MINUS,FOLLOW_MINUS_in_unaryOperator3191); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  ExpressionOperator.Minus; 
                    	}
                    
                    }
                    break;
            
            }
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end unaryOperator

    
    // $ANTLR start additiveOperator
    // MacroScope\\MacroScope.g:765:1: additiveOperator returns [ ExpressionOperator value ] : ( PLUS | MINUS | STRCONCAT );
    public ExpressionOperator additiveOperator() // throws RecognitionException [1]
    {   

        ExpressionOperator value = null;
    
        try 
    	{
            // MacroScope\\MacroScope.g:765:55: ( PLUS | MINUS | STRCONCAT )
            int alt82 = 3;
            switch ( input.LA(1) ) 
            {
            case PLUS:
            	{
                alt82 = 1;
                }
                break;
            case MINUS:
            	{
                alt82 = 2;
                }
                break;
            case STRCONCAT:
            	{
                alt82 = 3;
                }
                break;
            	default:
            	    if ( backtracking > 0 ) {failed = true; return value;}
            	    NoViableAltException nvae_d82s0 =
            	        new NoViableAltException("765:1: additiveOperator returns [ ExpressionOperator value ] : ( PLUS | MINUS | STRCONCAT );", 82, 0, input);
            
            	    throw nvae_d82s0;
            }
            
            switch (alt82) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:766:2: PLUS
                    {
                    	Match(input,PLUS,FOLLOW_PLUS_in_additiveOperator3208); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  ExpressionOperator.Plus; 
                    	}
                    
                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:767:4: MINUS
                    {
                    	Match(input,MINUS,FOLLOW_MINUS_in_additiveOperator3215); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  ExpressionOperator.Minus; 
                    	}
                    
                    }
                    break;
                case 3 :
                    // MacroScope\\MacroScope.g:768:4: STRCONCAT
                    {
                    	Match(input,STRCONCAT,FOLLOW_STRCONCAT_in_additiveOperator3222); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  ExpressionOperator.StrConcat; 
                    	}
                    
                    }
                    break;
            
            }
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end additiveOperator

    
    // $ANTLR start multiplicativeArithmeticOperator
    // MacroScope\\MacroScope.g:771:1: multiplicativeArithmeticOperator returns [ ExpressionOperator value ] : ( STAR | DIVIDE | MOD );
    public ExpressionOperator multiplicativeArithmeticOperator() // throws RecognitionException [1]
    {   

        ExpressionOperator value = null;
    
        try 
    	{
            // MacroScope\\MacroScope.g:771:71: ( STAR | DIVIDE | MOD )
            int alt83 = 3;
            switch ( input.LA(1) ) 
            {
            case STAR:
            	{
                alt83 = 1;
                }
                break;
            case DIVIDE:
            	{
                alt83 = 2;
                }
                break;
            case MOD:
            	{
                alt83 = 3;
                }
                break;
            	default:
            	    if ( backtracking > 0 ) {failed = true; return value;}
            	    NoViableAltException nvae_d83s0 =
            	        new NoViableAltException("771:1: multiplicativeArithmeticOperator returns [ ExpressionOperator value ] : ( STAR | DIVIDE | MOD );", 83, 0, input);
            
            	    throw nvae_d83s0;
            }
            
            switch (alt83) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:772:2: STAR
                    {
                    	Match(input,STAR,FOLLOW_STAR_in_multiplicativeArithmeticOperator3243); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  ExpressionOperator.Mult; 
                    	}
                    
                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:773:4: DIVIDE
                    {
                    	Match(input,DIVIDE,FOLLOW_DIVIDE_in_multiplicativeArithmeticOperator3250); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  ExpressionOperator.Div; 
                    	}
                    
                    }
                    break;
                case 3 :
                    // MacroScope\\MacroScope.g:774:4: MOD
                    {
                    	Match(input,MOD,FOLLOW_MOD_in_multiplicativeArithmeticOperator3257); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  ExpressionOperator.Mod; 
                    	}
                    
                    }
                    break;
            
            }
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end multiplicativeArithmeticOperator

    
    // $ANTLR start comparisonOperator
    // MacroScope\\MacroScope.g:777:1: comparisonOperator returns [ ExpressionOperator value ] : ( ASSIGNEQUAL | NOTEQUAL1 | NOTEQUAL2 | LESSTHANOREQUALTO1 | LESSTHAN | GREATERTHANOREQUALTO1 | GREATERTHAN );
    public ExpressionOperator comparisonOperator() // throws RecognitionException [1]
    {   

        ExpressionOperator value = null;
    
        try 
    	{
            // MacroScope\\MacroScope.g:777:57: ( ASSIGNEQUAL | NOTEQUAL1 | NOTEQUAL2 | LESSTHANOREQUALTO1 | LESSTHAN | GREATERTHANOREQUALTO1 | GREATERTHAN )
            int alt84 = 7;
            switch ( input.LA(1) ) 
            {
            case ASSIGNEQUAL:
            	{
                alt84 = 1;
                }
                break;
            case NOTEQUAL1:
            	{
                alt84 = 2;
                }
                break;
            case NOTEQUAL2:
            	{
                alt84 = 3;
                }
                break;
            case LESSTHANOREQUALTO1:
            	{
                alt84 = 4;
                }
                break;
            case LESSTHAN:
            	{
                alt84 = 5;
                }
                break;
            case GREATERTHANOREQUALTO1:
            	{
                alt84 = 6;
                }
                break;
            case GREATERTHAN:
            	{
                alt84 = 7;
                }
                break;
            	default:
            	    if ( backtracking > 0 ) {failed = true; return value;}
            	    NoViableAltException nvae_d84s0 =
            	        new NoViableAltException("777:1: comparisonOperator returns [ ExpressionOperator value ] : ( ASSIGNEQUAL | NOTEQUAL1 | NOTEQUAL2 | LESSTHANOREQUALTO1 | LESSTHAN | GREATERTHANOREQUALTO1 | GREATERTHAN );", 84, 0, input);
            
            	    throw nvae_d84s0;
            }
            
            switch (alt84) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:778:2: ASSIGNEQUAL
                    {
                    	Match(input,ASSIGNEQUAL,FOLLOW_ASSIGNEQUAL_in_comparisonOperator3278); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  ExpressionOperator.Equal; 
                    	}
                    
                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:779:4: NOTEQUAL1
                    {
                    	Match(input,NOTEQUAL1,FOLLOW_NOTEQUAL1_in_comparisonOperator3285); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  ExpressionOperator.NotEqual; 
                    	}
                    
                    }
                    break;
                case 3 :
                    // MacroScope\\MacroScope.g:780:4: NOTEQUAL2
                    {
                    	Match(input,NOTEQUAL2,FOLLOW_NOTEQUAL2_in_comparisonOperator3292); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  ExpressionOperator.NotEqual; 
                    	}
                    
                    }
                    break;
                case 4 :
                    // MacroScope\\MacroScope.g:781:4: LESSTHANOREQUALTO1
                    {
                    	Match(input,LESSTHANOREQUALTO1,FOLLOW_LESSTHANOREQUALTO1_in_comparisonOperator3299); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  ExpressionOperator.LessOrEqual; 
                    	}
                    
                    }
                    break;
                case 5 :
                    // MacroScope\\MacroScope.g:782:4: LESSTHAN
                    {
                    	Match(input,LESSTHAN,FOLLOW_LESSTHAN_in_comparisonOperator3306); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  ExpressionOperator.Less; 
                    	}
                    
                    }
                    break;
                case 6 :
                    // MacroScope\\MacroScope.g:783:4: GREATERTHANOREQUALTO1
                    {
                    	Match(input,GREATERTHANOREQUALTO1,FOLLOW_GREATERTHANOREQUALTO1_in_comparisonOperator3313); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  ExpressionOperator.GreaterOrEqual; 
                    	}
                    
                    }
                    break;
                case 7 :
                    // MacroScope\\MacroScope.g:784:4: GREATERTHAN
                    {
                    	Match(input,GREATERTHAN,FOLLOW_GREATERTHAN_in_comparisonOperator3320); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  ExpressionOperator.Greater; 
                    	}
                    
                    }
                    break;
            
            }
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end comparisonOperator

    
    // $ANTLR start unionOperator
    // MacroScope\\MacroScope.g:787:1: unionOperator returns [ bool value ] : UNION ( ALL )? ;
    public bool unionOperator() // throws RecognitionException [1]
    {   

        bool value = false;
    
        try 
    	{
            // MacroScope\\MacroScope.g:787:38: ( UNION ( ALL )? )
            // MacroScope\\MacroScope.g:788:2: UNION ( ALL )?
            {
            	Match(input,UNION,FOLLOW_UNION_in_unionOperator3337); if (failed) return value;
            	if ( backtracking == 0 ) 
            	{
            	   value =  false; 
            	}
            	// MacroScope\\MacroScope.g:789:2: ( ALL )?
            	int alt85 = 2;
            	int LA85_0 = input.LA(1);
            	
            	if ( (LA85_0 == ALL) )
            	{
            	    alt85 = 1;
            	}
            	switch (alt85) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:789:4: ALL
            	        {
            	        	Match(input,ALL,FOLLOW_ALL_in_unionOperator3344); if (failed) return value;
            	        	if ( backtracking == 0 ) 
            	        	{
            	        	   value =  true; 
            	        	}
            	        
            	        }
            	        break;
            	
            	}

            
            }
    
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end unionOperator

    
    // $ANTLR start datetimeField
    // MacroScope\\MacroScope.g:792:1: datetimeField returns [ DateTimeUnit value ] : ( YEAR | MONTH | DAY | HOUR | MINUTE | SECOND );
    public DateTimeUnit datetimeField() // throws RecognitionException [1]
    {   

        DateTimeUnit value = null;
    
        try 
    	{
            // MacroScope\\MacroScope.g:792:46: ( YEAR | MONTH | DAY | HOUR | MINUTE | SECOND )
            int alt86 = 6;
            switch ( input.LA(1) ) 
            {
            case YEAR:
            	{
                alt86 = 1;
                }
                break;
            case MONTH:
            	{
                alt86 = 2;
                }
                break;
            case DAY:
            	{
                alt86 = 3;
                }
                break;
            case HOUR:
            	{
                alt86 = 4;
                }
                break;
            case MINUTE:
            	{
                alt86 = 5;
                }
                break;
            case SECOND:
            	{
                alt86 = 6;
                }
                break;
            	default:
            	    if ( backtracking > 0 ) {failed = true; return value;}
            	    NoViableAltException nvae_d86s0 =
            	        new NoViableAltException("792:1: datetimeField returns [ DateTimeUnit value ] : ( YEAR | MONTH | DAY | HOUR | MINUTE | SECOND );", 86, 0, input);
            
            	    throw nvae_d86s0;
            }
            
            switch (alt86) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:793:2: YEAR
                    {
                    	Match(input,YEAR,FOLLOW_YEAR_in_datetimeField3364); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  DateTimeUnit.Year; 
                    	}
                    
                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:794:4: MONTH
                    {
                    	Match(input,MONTH,FOLLOW_MONTH_in_datetimeField3371); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  DateTimeUnit.Month; 
                    	}
                    
                    }
                    break;
                case 3 :
                    // MacroScope\\MacroScope.g:795:4: DAY
                    {
                    	Match(input,DAY,FOLLOW_DAY_in_datetimeField3378); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  DateTimeUnit.Day; 
                    	}
                    
                    }
                    break;
                case 4 :
                    // MacroScope\\MacroScope.g:796:4: HOUR
                    {
                    	Match(input,HOUR,FOLLOW_HOUR_in_datetimeField3385); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  DateTimeUnit.Hour; 
                    	}
                    
                    }
                    break;
                case 5 :
                    // MacroScope\\MacroScope.g:797:4: MINUTE
                    {
                    	Match(input,MINUTE,FOLLOW_MINUTE_in_datetimeField3392); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  DateTimeUnit.Minute; 
                    	}
                    
                    }
                    break;
                case 6 :
                    // MacroScope\\MacroScope.g:798:4: SECOND
                    {
                    	Match(input,SECOND,FOLLOW_SECOND_in_datetimeField3399); if (failed) return value;
                    	if ( backtracking == 0 ) 
                    	{
                    	   value =  DateTimeUnit.Second; 
                    	}
                    
                    }
                    break;
            
            }
        }
        
        finally 
    	{
        }
        return value;
    }
    // $ANTLR end datetimeField

    // $ANTLR start synpred1
    public void synpred1_fragment() //throws RecognitionException
    {   
        // MacroScope\\MacroScope.g:205:3: ( bracketedSearchCondition )
        // MacroScope\\MacroScope.g:205:4: bracketedSearchCondition
        {
        	PushFollow(FOLLOW_bracketedSearchCondition_in_synpred11047);
        	bracketedSearchCondition();
        	followingStackPointer_--;
        	if (failed) return ;
        
        }
    }
    // $ANTLR end synpred1

    // $ANTLR start synpred2
    public void synpred2_fragment() //throws RecognitionException
    {   
        // MacroScope\\MacroScope.g:306:5: ( selectStatement )
        // MacroScope\\MacroScope.g:306:7: selectStatement
        {
        	PushFollow(FOLLOW_selectStatement_in_synpred21308);
        	selectStatement();
        	followingStackPointer_--;
        	if (failed) return ;
        
        }
    }
    // $ANTLR end synpred2

    // $ANTLR start synpred3
    public void synpred3_fragment() //throws RecognitionException
    {   
        // MacroScope\\MacroScope.g:349:3: ( alias2 )
        // MacroScope\\MacroScope.g:349:4: alias2
        {
        	PushFollow(FOLLOW_alias2_in_synpred31494);
        	alias2();
        	followingStackPointer_--;
        	if (failed) return ;
        
        }
    }
    // $ANTLR end synpred3

    // $ANTLR start synpred4
    public void synpred4_fragment() //throws RecognitionException
    {   
        // MacroScope\\MacroScope.g:357:5: ( tableColumns )
        // MacroScope\\MacroScope.g:357:6: tableColumns
        {
        	PushFollow(FOLLOW_tableColumns_in_synpred41531);
        	tableColumns();
        	followingStackPointer_--;
        	if (failed) return ;
        
        }
    }
    // $ANTLR end synpred4

    // $ANTLR start synpred5
    public void synpred5_fragment() //throws RecognitionException
    {   
        // MacroScope\\MacroScope.g:382:3: ( joinedTables )
        // MacroScope\\MacroScope.g:382:4: joinedTables
        {
        	PushFollow(FOLLOW_joinedTables_in_synpred51670);
        	joinedTables();
        	followingStackPointer_--;
        	if (failed) return ;
        
        }
    }
    // $ANTLR end synpred5

    // $ANTLR start synpred6
    public void synpred6_fragment() //throws RecognitionException
    {   
        // MacroScope\\MacroScope.g:387:5: ( queryExpression )
        // MacroScope\\MacroScope.g:387:6: queryExpression
        {
        	PushFollow(FOLLOW_queryExpression_in_synpred61693);
        	queryExpression();
        	followingStackPointer_--;
        	if (failed) return ;
        
        }
    }
    // $ANTLR end synpred6

    // $ANTLR start synpred7
    public void synpred7_fragment() //throws RecognitionException
    {   
        // MacroScope\\MacroScope.g:400:4: ( function )
        // MacroScope\\MacroScope.g:400:5: function
        {
        	PushFollow(FOLLOW_function_in_synpred71741);
        	function();
        	followingStackPointer_--;
        	if (failed) return ;
        
        }
    }
    // $ANTLR end synpred7

    // $ANTLR start synpred8
    public void synpred8_fragment() //throws RecognitionException
    {   
        // MacroScope\\MacroScope.g:481:11: ( selectStatement )
        // MacroScope\\MacroScope.g:481:12: selectStatement
        {
        	PushFollow(FOLLOW_selectStatement_in_synpred82176);
        	selectStatement();
        	followingStackPointer_--;
        	if (failed) return ;
        
        }
    }
    // $ANTLR end synpred8

    // $ANTLR start synpred9
    public void synpred9_fragment() //throws RecognitionException
    {   
        // MacroScope\\MacroScope.g:520:5: ( function )
        // MacroScope\\MacroScope.g:520:6: function
        {
        	PushFollow(FOLLOW_function_in_synpred92274);
        	function();
        	followingStackPointer_--;
        	if (failed) return ;
        
        }
    }
    // $ANTLR end synpred9

   	public bool synpred9() 
   	{
   	    backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred9_fragment(); // can never throw exception
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
   	public bool synpred5() 
   	{
   	    backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred5_fragment(); // can never throw exception
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
   	public bool synpred6() 
   	{
   	    backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred6_fragment(); // can never throw exception
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
   	public bool synpred7() 
   	{
   	    backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred7_fragment(); // can never throw exception
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
   	public bool synpred8() 
   	{
   	    backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred8_fragment(); // can never throw exception
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
   	public bool synpred2() 
   	{
   	    backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred2_fragment(); // can never throw exception
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
   	public bool synpred3() 
   	{
   	    backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred3_fragment(); // can never throw exception
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
   	public bool synpred4() 
   	{
   	    backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred4_fragment(); // can never throw exception
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


   	protected DFA39 dfa39;
	private void InitializeCyclicDFAs()
	{
    	this.dfa39 = new DFA39(this);
	    this.dfa39.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA39_SpecialStateTransition);
	}

    static readonly short[] DFA39_eot = {
        -1, -1, -1, -1, -1, -1, -1, -1, -1
        };
    static readonly short[] DFA39_eof = {
        -1, 3, 3, -1, -1, -1, -1, 3, 3
        };
    static readonly int[] DFA39_min = {
        6, 6, 7, 0, 56, 0, 0, 7, 7
        };
    static readonly int[] DFA39_max = {
        73, 83, 83, 0, 66, 0, 0, 83, 83
        };
    static readonly short[] DFA39_accept = {
        -1, -1, -1, 3, -1, 2, 1, -1, -1
        };
    static readonly short[] DFA39_special = {
        -1, 2, 0, -1, -1, -1, -1, 1, 3
        };
    
    static readonly short[] dfa39_transition_null = null;

    static readonly short[] dfa39_transition0 = {
    	3, -1, -1, -1, -1, 3, 3, 6, -1, -1, -1, -1, -1, -1, 3, 3, -1, -1, -1, 
    	    3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 3, -1, -1, 
    	    -1, -1, -1, -1, -1, -1, 3, 5, -1, -1, -1, -1, -1, 3, -1, -1, -1, 
    	    -1, -1, -1, 4, -1, -1, 3, -1, -1, -1, -1, -1, 3, 3, 3, 3, 3, -1, 
    	    -1, -1, -1, -1, -1, 3
    	};
    static readonly short[] dfa39_transition1 = {
    	3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 3, -1, -1, -1, 
    	    -1, -1, -1, -1, -1, -1, -1, -1, 3, -1, -1, -1, -1, -1, -1, -1, 
    	    -1, -1, 3, 3, -1, -1, -1, -1, -1, -1, -1, 3, 3, 3, -1, 3, 1, 3, 
    	    -1, -1, -1, -1, 3, -1, 3, 3, 2, 3, 3, 3, 3, 3, 3, 3
    	};
    static readonly short[] dfa39_transition2 = {
    	7, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8
    	};
    static readonly short[] dfa39_transition3 = {
    	3, -1, -1, -1, -1, 3, 3, -1, -1, -1, -1, -1, -1, -1, 3, 3, -1, -1, 
    	    -1, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 3, -1, 
    	    -1, -1, -1, -1, -1, -1, -1, 3, 5, -1, -1, -1, -1, -1, 3, -1, -1, 
    	    -1, -1, -1, -1, 4, -1, -1, 3, -1, -1, -1, -1, -1, 3, 3, 3, 3, 3, 
    	    -1, -1, -1, -1, -1, -1, 3
    	};
    static readonly short[] dfa39_transition4 = {
    	3, 3, -1, -1, -1, -1, 3, 3, 6, -1, -1, -1, -1, -1, -1, 3, 3, -1, -1, 
    	    -1, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 3, -1, 
    	    -1, -1, -1, -1, -1, -1, -1, 3, 5, -1, -1, -1, -1, -1, 3, -1, -1, 
    	    -1, -1, -1, -1, 4, -1, -1, 3, -1, -1, -1, -1, -1, 3, 3, 3, 3, 3, 
    	    -1, -1, -1, -1, -1, -1, 3
    	};
    
    static readonly short[][] DFA39_transition = {
    	dfa39_transition1,
    	dfa39_transition4,
    	dfa39_transition0,
    	dfa39_transition_null,
    	dfa39_transition2,
    	dfa39_transition_null,
    	dfa39_transition_null,
    	dfa39_transition3,
    	dfa39_transition3
        };
    
    protected class DFA39 : DFA
    {
        public DFA39(BaseRecognizer recognizer) 
        {
            this.recognizer = recognizer;
            this.decisionNumber = 39;
            this.eot = DFA39_eot;
            this.eof = DFA39_eof;
            this.min = DFA39_min;
            this.max = DFA39_max;
            this.accept     = DFA39_accept;
            this.special    = DFA39_special;
            this.transition = DFA39_transition;
        }
    
        override public string Description
        {
            get { return "347:4: ( ( alias2 )=> (a= alias2 e= expression ) | ( tableColumns )=>t= tableColumns | e= expression (a= alias1 )? )"; }
        }
    
    }
    
    
    protected internal int DFA39_SpecialStateTransition(DFA dfa, int s, IIntStream input) //throws NoViableAltException
    {
    	int _s = s;
        switch ( s )
        {

               	case 0 : 
                   	int LA39_2 = input.LA(1);
                   	
                   	 
                   	int index39_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA39_2 == ASSIGNEQUAL) && (synpred3()) ) { s = 6; }

                   	else if ( (LA39_2 == DOT) ) { s = 4; }

                   	else if ( (LA39_2 == EOF || LA39_2 == RPAREN || (LA39_2 >= FROM && LA39_2 <= COMMA) || (LA39_2 >= WHERE && LA39_2 <= ORDER) || LA39_2 == GROUP || LA39_2 == STAR || LA39_2 == AS || LA39_2 == NonQuotedIdentifier || LA39_2 == QuotedIdentifier || (LA39_2 >= PLUS && LA39_2 <= MOD) || LA39_2 == UNION) ) { s = 3; }

                   	else if ( (LA39_2 == DOT_STAR) && (synpred4()) ) { s = 5; }
                   	
                   	 
                   	input.Seek(index39_2);
                   	if ( s >= 0 ) return s;
                   	break;

               	case 1 : 
                   	int LA39_7 = input.LA(1);
                   	
                   	 
                   	int index39_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA39_7 == EOF || LA39_7 == RPAREN || (LA39_7 >= FROM && LA39_7 <= COMMA) || (LA39_7 >= WHERE && LA39_7 <= ORDER) || LA39_7 == GROUP || LA39_7 == STAR || LA39_7 == AS || LA39_7 == NonQuotedIdentifier || LA39_7 == QuotedIdentifier || (LA39_7 >= PLUS && LA39_7 <= MOD) || LA39_7 == UNION) ) { s = 3; }

                   	else if ( (LA39_7 == DOT) ) { s = 4; }

                   	else if ( (LA39_7 == DOT_STAR) && (synpred4()) ) { s = 5; }
                   	
                   	 
                   	input.Seek(index39_7);
                   	if ( s >= 0 ) return s;
                   	break;

               	case 2 : 
                   	int LA39_1 = input.LA(1);
                   	
                   	 
                   	int index39_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA39_1 == DOT) ) { s = 4; }

                   	else if ( (LA39_1 == DOT_STAR) && (synpred4()) ) { s = 5; }

                   	else if ( (LA39_1 == ASSIGNEQUAL) && (synpred3()) ) { s = 6; }

                   	else if ( (LA39_1 == EOF || (LA39_1 >= LPAREN && LA39_1 <= RPAREN) || (LA39_1 >= FROM && LA39_1 <= COMMA) || (LA39_1 >= WHERE && LA39_1 <= ORDER) || LA39_1 == GROUP || LA39_1 == STAR || LA39_1 == AS || LA39_1 == NonQuotedIdentifier || LA39_1 == QuotedIdentifier || (LA39_1 >= PLUS && LA39_1 <= MOD) || LA39_1 == UNION) ) { s = 3; }
                   	
                   	 
                   	input.Seek(index39_1);
                   	if ( s >= 0 ) return s;
                   	break;

               	case 3 : 
                   	int LA39_8 = input.LA(1);
                   	
                   	 
                   	int index39_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA39_8 == EOF || LA39_8 == RPAREN || (LA39_8 >= FROM && LA39_8 <= COMMA) || (LA39_8 >= WHERE && LA39_8 <= ORDER) || LA39_8 == GROUP || LA39_8 == STAR || LA39_8 == AS || LA39_8 == NonQuotedIdentifier || LA39_8 == QuotedIdentifier || (LA39_8 >= PLUS && LA39_8 <= MOD) || LA39_8 == UNION) ) { s = 3; }

                   	else if ( (LA39_8 == DOT) ) { s = 4; }

                   	else if ( (LA39_8 == DOT_STAR) && (synpred4()) ) { s = 5; }
                   	
                   	 
                   	input.Seek(index39_8);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (backtracking > 0) {failed = true; return -1;}
        NoViableAltException nvae =
            new NoViableAltException(dfa.Description, 39, _s, input);
        dfa.Error(nvae);
        throw nvae;
    }
 

    public static readonly BitSet FOLLOW_insertStatement_in_statement66 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_statement68 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectStatement_in_statement79 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_statement81 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_updateStatement_in_statement92 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_statement94 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_deleteStatement_in_statement105 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_statement107 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INSERT_in_insertStatement126 = new BitSet(new ulong[]{0x0100000000000020UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_INTO_in_insertStatement132 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_dbObject_in_insertStatement143 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_insertStatement155 = new BitSet(new ulong[]{0x0100000000000040UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_columnNameList_in_insertStatement161 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_insertStatement163 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_VALUES_in_insertStatement169 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_insertStatement171 = new BitSet(new ulong[]{0x43B80C0100108040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_columnValueList_in_insertStatement177 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_insertStatement179 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_queryExpression_in_selectStatement206 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPDATE_in_updateStatement225 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_dbObject_in_updateStatement235 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_SET_in_updateStatement241 = new BitSet(new ulong[]{0x0100000000000040UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_assignmentList_in_updateStatement247 = new BitSet(new ulong[]{0x0000000000200002UL});
    public static readonly BitSet FOLLOW_whereClause_in_updateStatement266 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DELETE_in_deleteStatement293 = new BitSet(new ulong[]{0x0100000000001000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_FROM_in_deleteStatement299 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_dbObject_in_deleteStatement310 = new BitSet(new ulong[]{0x0000000000200002UL});
    public static readonly BitSet FOLLOW_whereClause_in_deleteStatement326 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_assignmentList356 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_COMMA_in_assignmentList362 = new BitSet(new ulong[]{0x0100000000000040UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_assignment_in_assignmentList368 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_column_in_assignment392 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_ASSIGNEQUAL_in_assignment394 = new BitSet(new ulong[]{0x43B80C0100108040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_columnValue_in_assignment400 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_column_in_columnNameList421 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_COMMA_in_columnNameList429 = new BitSet(new ulong[]{0x0100000000000040UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_column_in_columnNameList435 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_columnValue_in_columnValueList459 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_COMMA_in_columnValueList465 = new BitSet(new ulong[]{0x43B80C0100108040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_columnValue_in_columnValueList471 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_DEFAULT_in_columnValue491 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_columnValue502 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_subQueryExpression_in_queryExpression523 = new BitSet(new ulong[]{0x0000000000400002UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_unionOperator_in_queryExpression535 = new BitSet(new ulong[]{0x0000000000010040UL});
    public static readonly BitSet FOLLOW_subQueryExpression_in_queryExpression543 = new BitSet(new ulong[]{0x0000000000400002UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_orderByClause_in_queryExpression558 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_querySpecification_in_subQueryExpression582 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_subQueryExpression590 = new BitSet(new ulong[]{0x0000000000010040UL});
    public static readonly BitSet FOLLOW_queryExpression_in_subQueryExpression596 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_subQueryExpression598 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectClause_in_querySpecification619 = new BitSet(new ulong[]{0x0000000004201002UL});
    public static readonly BitSet FOLLOW_fromClause_in_querySpecification630 = new BitSet(new ulong[]{0x0000000004200002UL});
    public static readonly BitSet FOLLOW_whereClause_in_querySpecification644 = new BitSet(new ulong[]{0x0000000004000002UL});
    public static readonly BitSet FOLLOW_groupByClause_in_querySpecification658 = new BitSet(new ulong[]{0x0000000008000002UL});
    public static readonly BitSet FOLLOW_havingClause_in_querySpecification670 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SELECT_in_selectClause694 = new BitSet(new ulong[]{0x43B80D01001E0040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_ALL_in_selectClause701 = new BitSet(new ulong[]{0x43B80D0100180040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_DISTINCT_in_selectClause705 = new BitSet(new ulong[]{0x43B80D0100180040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_TOP_in_selectClause714 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_Integer_in_selectClause716 = new BitSet(new ulong[]{0x43B80D0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_selectList_in_selectClause728 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHERE_in_whereClause745 = new BitSet(new ulong[]{0x43B80C2140100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_searchCondition_in_whereClause751 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ORDER_in_orderByClause768 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_BY_in_orderByClause770 = new BitSet(new ulong[]{0x43B80C0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_orderExpression_in_orderByClause777 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_COMMA_in_orderByClause784 = new BitSet(new ulong[]{0x43B80C0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_orderExpression_in_orderByClause790 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_expression_in_orderExpression814 = new BitSet(new ulong[]{0x0000000003000002UL});
    public static readonly BitSet FOLLOW_ASC_in_orderExpression821 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DESC_in_orderExpression825 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_GROUP_in_groupByClause845 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_BY_in_groupByClause847 = new BitSet(new ulong[]{0x43B80C0100120040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_ALL_in_groupByClause855 = new BitSet(new ulong[]{0x43B80C0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_expression_in_groupByClause868 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_COMMA_in_groupByClause874 = new BitSet(new ulong[]{0x43B80C0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_expression_in_groupByClause880 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_HAVING_in_havingClause900 = new BitSet(new ulong[]{0x43B80C2140100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_searchCondition_in_havingClause906 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additiveSubSearchCondition_in_searchCondition927 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_OR_in_searchCondition935 = new BitSet(new ulong[]{0x43B80C2140100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_additiveSubSearchCondition_in_searchCondition941 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_subSearchCondition_in_additiveSubSearchCondition967 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_AND_in_additiveSubSearchCondition975 = new BitSet(new ulong[]{0x43B80C2140100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_subSearchCondition_in_additiveSubSearchCondition981 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_bracketedSearchCondition1003 = new BitSet(new ulong[]{0x43B80C2140100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_searchCondition_in_bracketedSearchCondition1009 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_bracketedSearchCondition1011 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NOT_in_subSearchCondition1035 = new BitSet(new ulong[]{0x43B80C2100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_bracketedSearchCondition_in_subSearchCondition1059 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_predicate_in_subSearchCondition1071 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_predicate1101 = new BitSet(new ulong[]{0x0000001AC0004000UL,0x000000000007E000UL});
    public static readonly BitSet FOLLOW_comparisonOperator_in_predicate1118 = new BitSet(new ulong[]{0x43B80CC100120040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_expression_in_predicate1140 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_quantifierSpec_in_predicate1153 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_predicate1159 = new BitSet(new ulong[]{0x0000000000010040UL});
    public static readonly BitSet FOLLOW_selectStatement_in_predicate1165 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_predicate1167 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IS_in_predicate1188 = new BitSet(new ulong[]{0x0000000140000000UL});
    public static readonly BitSet FOLLOW_NOT_in_predicate1198 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_NULL_in_predicate1208 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NOT_in_predicate1216 = new BitSet(new ulong[]{0x0000001A00000000UL});
    public static readonly BitSet FOLLOW_LIKE_in_predicate1228 = new BitSet(new ulong[]{0x43B80C0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_expression_in_predicate1234 = new BitSet(new ulong[]{0x0000000400000002UL});
    public static readonly BitSet FOLLOW_ESCAPE_in_predicate1249 = new BitSet(new ulong[]{0x43B80C0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_expression_in_predicate1255 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BETWEEN_in_predicate1273 = new BitSet(new ulong[]{0x43B80C0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_expression_in_predicate1279 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_AND_in_predicate1281 = new BitSet(new ulong[]{0x43B80C0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_expression_in_predicate1287 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IN_in_predicate1296 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_predicate1298 = new BitSet(new ulong[]{0x43B80C0100110040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_selectStatement_in_predicate1323 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_expression_in_predicate1337 = new BitSet(new ulong[]{0x0000000000002080UL});
    public static readonly BitSet FOLLOW_COMMA_in_predicate1348 = new BitSet(new ulong[]{0x43B80C0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_expression_in_predicate1354 = new BitSet(new ulong[]{0x0000000000002080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_predicate1367 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EXISTS_in_predicate1382 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_predicate1384 = new BitSet(new ulong[]{0x0000000000010040UL});
    public static readonly BitSet FOLLOW_selectStatement_in_predicate1390 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_predicate1392 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ALL_in_quantifierSpec1409 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SOME_in_quantifierSpec1416 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ANY_in_quantifierSpec1423 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectItem_in_selectList1444 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_COMMA_in_selectList1452 = new BitSet(new ulong[]{0x43B80D0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_selectItem_in_selectList1458 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_STAR_in_selectItem1478 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_alias2_in_selectItem1508 = new BitSet(new ulong[]{0x43B80C0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_expression_in_selectItem1514 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tableColumns_in_selectItem1540 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_selectItem1553 = new BitSet(new ulong[]{0x0102000000000002UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_alias1_in_selectItem1566 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FROM_in_fromClause1589 = new BitSet(new ulong[]{0x01A00C0000000040UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_tableSource_in_fromClause1595 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_COMMA_in_fromClause1602 = new BitSet(new ulong[]{0x01A00C0000000040UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_tableSource_in_fromClause1608 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_subTableSource_in_tableSource1632 = new BitSet(new ulong[]{0x0000DE0000000002UL});
    public static readonly BitSet FOLLOW_joinedTable_in_tableSource1643 = new BitSet(new ulong[]{0x0000DE0000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_subTableSource1663 = new BitSet(new ulong[]{0x01A00C0000010040UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_joinedTables_in_subTableSource1682 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_subTableSource1684 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_queryExpression_in_subTableSource1709 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_subTableSource1711 = new BitSet(new ulong[]{0x0102000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_alias1_in_subTableSource1717 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_function_in_subTableSource1752 = new BitSet(new ulong[]{0x0102000000000002UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_alias1_in_subTableSource1765 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dbObject_in_subTableSource1779 = new BitSet(new ulong[]{0x0102000000000002UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_alias1_in_subTableSource1791 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INNER_in_joinOn1813 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_LEFT_in_joinOn1820 = new BitSet(new ulong[]{0x0000600000000000UL});
    public static readonly BitSet FOLLOW_RIGHT_in_joinOn1828 = new BitSet(new ulong[]{0x0000600000000000UL});
    public static readonly BitSet FOLLOW_FULL_in_joinOn1836 = new BitSet(new ulong[]{0x0000600000000000UL});
    public static readonly BitSet FOLLOW_OUTER_in_joinOn1846 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_JOIN_in_joinOn1856 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CROSS_in_joinedTable1871 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_JOIN_in_joinedTable1873 = new BitSet(new ulong[]{0x01A00C0000000040UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_subTableSource_in_joinedTable1879 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_joinOn_in_joinedTable1894 = new BitSet(new ulong[]{0x01A00C0000000040UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_tableSource_in_joinedTable1903 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_ON_in_joinedTable1910 = new BitSet(new ulong[]{0x43B80C2140100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_searchCondition_in_joinedTable1916 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_subTableSource_in_joinedTables1941 = new BitSet(new ulong[]{0x0000DE0000000000UL});
    public static readonly BitSet FOLLOW_joinedTable_in_joinedTables1953 = new BitSet(new ulong[]{0x0000DE0000000002UL});
    public static readonly BitSet FOLLOW_AS_in_alias11976 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_identifier_in_alias11984 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_identifier_in_alias22005 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_ASSIGNEQUAL_in_alias22011 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dbObject_in_tableColumns2030 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_DOT_STAR_in_tableColumns2032 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dbObject_in_column2054 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_column2063 = new BitSet(new ulong[]{0x0100000000000040UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_column_in_column2069 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_column2071 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additiveSubExpression_in_expression2092 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000700UL});
    public static readonly BitSet FOLLOW_additiveOperator_in_expression2103 = new BitSet(new ulong[]{0x43B80C0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_additiveSubExpression_in_expression2109 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000700UL});
    public static readonly BitSet FOLLOW_subExpression_in_additiveSubExpression2134 = new BitSet(new ulong[]{0x0000010000000002UL,0x0000000000001800UL});
    public static readonly BitSet FOLLOW_multiplicativeArithmeticOperator_in_additiveSubExpression2145 = new BitSet(new ulong[]{0x43B80C0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_subExpression_in_additiveSubExpression2151 = new BitSet(new ulong[]{0x0000010000000002UL,0x0000000000001800UL});
    public static readonly BitSet FOLLOW_LPAREN_in_bracketedTerm2171 = new BitSet(new ulong[]{0x43B80C0100110040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_selectStatement_in_bracketedTerm2189 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_bracketedTerm2191 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_bracketedTerm2203 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_bracketedTerm2205 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryOperator_in_subExpression2230 = new BitSet(new ulong[]{0x43B80C0100100040UL,0x00000000000000FFUL});
    public static readonly BitSet FOLLOW_constant_in_subExpression2245 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableReference_in_subExpression2257 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLACEHOLDER_in_subExpression2265 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_function_in_subExpression2286 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bracketedTerm_in_subExpression2298 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dbObject_in_subExpression2310 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_caseFunction_in_subExpression2356 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_castFunction_in_subExpression2368 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Variable_in_variableReference2387 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SUBSTRING_in_function2405 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_function2409 = new BitSet(new ulong[]{0x43B80C0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_expression_in_function2415 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_FROM_in_function2419 = new BitSet(new ulong[]{0x43B80C0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_expression_in_function2425 = new BitSet(new ulong[]{0x0040000000000080UL});
    public static readonly BitSet FOLLOW_FOR_in_function2431 = new BitSet(new ulong[]{0x43B80C0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_expression_in_function2437 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_function2444 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EXTRACT_in_function2449 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_function2451 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000003F00000UL});
    public static readonly BitSet FOLLOW_datetimeField_in_function2457 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_FROM_in_function2459 = new BitSet(new ulong[]{0x43B80C0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_expression_in_function2465 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_function2469 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_genericFunction_in_function2478 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NonQuotedIdentifier_in_genericFunction2507 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LEFT_in_genericFunction2515 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_RIGHT_in_genericFunction2523 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_genericFunction2530 = new BitSet(new ulong[]{0x43B80D01001600C0UL,0x0000000003F003FFUL});
    public static readonly BitSet FOLLOW_functionArgument_in_genericFunction2540 = new BitSet(new ulong[]{0x0000000000002080UL});
    public static readonly BitSet FOLLOW_COMMA_in_genericFunction2549 = new BitSet(new ulong[]{0x43B80C0100100040UL,0x0000000003F003FFUL});
    public static readonly BitSet FOLLOW_functionArgument_in_genericFunction2555 = new BitSet(new ulong[]{0x0000000000002080UL});
    public static readonly BitSet FOLLOW_STAR_in_genericFunction2572 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_ALL_in_genericFunction2588 = new BitSet(new ulong[]{0x43B80D0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_DISTINCT_in_genericFunction2592 = new BitSet(new ulong[]{0x43B80D0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_STAR_in_genericFunction2603 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_expression_in_genericFunction2620 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_genericFunction2642 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_functionArgument2661 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_datetimeField_in_functionArgument2672 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CASE_in_caseFunction2689 = new BitSet(new ulong[]{0x47B80C0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_expression_in_caseFunction2701 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_WHEN_in_caseFunction2710 = new BitSet(new ulong[]{0x43B80C0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_expression_in_caseFunction2716 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_THEN_in_caseFunction2718 = new BitSet(new ulong[]{0x43B80C0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_expression_in_caseFunction2724 = new BitSet(new ulong[]{0x3400000000000000UL});
    public static readonly BitSet FOLLOW_WHEN_in_caseFunction2745 = new BitSet(new ulong[]{0x43B80C2140100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_searchCondition_in_caseFunction2751 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_THEN_in_caseFunction2753 = new BitSet(new ulong[]{0x43B80C0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_expression_in_caseFunction2759 = new BitSet(new ulong[]{0x3400000000000000UL});
    public static readonly BitSet FOLLOW_ELSE_in_caseFunction2780 = new BitSet(new ulong[]{0x43B80C0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_expression_in_caseFunction2786 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_END_in_caseFunction2793 = new BitSet(new ulong[]{0x0200000000000002UL});
    public static readonly BitSet FOLLOW_CASE_in_caseFunction2797 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CAST_in_castFunction2816 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_castFunction2818 = new BitSet(new ulong[]{0x43B80C0100100040UL,0x00000000000003FFUL});
    public static readonly BitSet FOLLOW_expression_in_castFunction2824 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_AS_in_castFunction2826 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_typeIdentifier_in_castFunction2832 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_LPAREN_in_castFunction2840 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_nonNegativeInteger_in_castFunction2846 = new BitSet(new ulong[]{0x0000000000002080UL});
    public static readonly BitSet FOLLOW_COMMA_in_castFunction2852 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_nonNegativeInteger_in_castFunction2858 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_castFunction2865 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_castFunction2870 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_identifier_in_dbObject2889 = new BitSet(new ulong[]{0x8000000000000002UL});
    public static readonly BitSet FOLLOW_DOT_in_dbObject2896 = new BitSet(new ulong[]{0x0100000000000000UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_identifier_in_dbObject2902 = new BitSet(new ulong[]{0x8000000000000002UL});
    public static readonly BitSet FOLLOW_singleStringLiteral_in_stringLiteral2930 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_singleStringLiteral_in_stringLiteral2940 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_UnicodeStringLiteral_in_singleStringLiteral2960 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_AsciiStringLiteral_in_singleStringLiteral2967 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NonQuotedIdentifier_in_identifier2984 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_QuotedIdentifier_in_identifier2991 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NonQuotedIdentifier_in_typeIdentifier3008 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nonNegativeInteger_in_constant3029 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Real_in_constant3036 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NULL_in_constant3043 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_stringLiteral_in_constant3054 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_intervalLiteral_in_constant3065 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_HexLiteral_in_constant3072 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MAccessDateTime_in_constant3081 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Iso8601DateTime_in_constant3090 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INTERVAL_in_intervalLiteral3114 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000302UL});
    public static readonly BitSet FOLLOW_unaryOperator_in_intervalLiteral3122 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_AsciiStringLiteral_in_intervalLiteral3129 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000003F00000UL});
    public static readonly BitSet FOLLOW_datetimeField_in_intervalLiteral3137 = new BitSet(new ulong[]{0x0000000000000042UL});
    public static readonly BitSet FOLLOW_LPAREN_in_intervalLiteral3143 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_Integer_in_intervalLiteral3145 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_intervalLiteral3149 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Integer_in_nonNegativeInteger3167 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_in_unaryOperator3184 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_in_unaryOperator3191 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_in_additiveOperator3208 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_in_additiveOperator3215 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRCONCAT_in_additiveOperator3222 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STAR_in_multiplicativeArithmeticOperator3243 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DIVIDE_in_multiplicativeArithmeticOperator3250 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MOD_in_multiplicativeArithmeticOperator3257 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ASSIGNEQUAL_in_comparisonOperator3278 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NOTEQUAL1_in_comparisonOperator3285 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NOTEQUAL2_in_comparisonOperator3292 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LESSTHANOREQUALTO1_in_comparisonOperator3299 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LESSTHAN_in_comparisonOperator3306 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_GREATERTHANOREQUALTO1_in_comparisonOperator3313 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_GREATERTHAN_in_comparisonOperator3320 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UNION_in_unionOperator3337 = new BitSet(new ulong[]{0x0000000000020002UL});
    public static readonly BitSet FOLLOW_ALL_in_unionOperator3344 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_YEAR_in_datetimeField3364 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MONTH_in_datetimeField3371 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DAY_in_datetimeField3378 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_HOUR_in_datetimeField3385 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUTE_in_datetimeField3392 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SECOND_in_datetimeField3399 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bracketedSearchCondition_in_synpred11047 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectStatement_in_synpred21308 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_alias2_in_synpred31494 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tableColumns_in_synpred41531 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_joinedTables_in_synpred51670 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_queryExpression_in_synpred61693 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_function_in_synpred71741 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectStatement_in_synpred82176 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_function_in_synpred92274 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}