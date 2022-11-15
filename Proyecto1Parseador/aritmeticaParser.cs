//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\Belkis Vasquez\source\repos\Proyecto1Parseador\Proyecto1Parseador\aritmetica.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class aritmeticaParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		NUM=1, RES=2, MUL=3, SUM=4, DIV=5, LPAR=6, RPAR=7, WS=8;
	public const int
		RULE_aritmetica = 0, RULE_expresion = 1, RULE_termino = 2, RULE_factor = 3;
	public static readonly string[] ruleNames = {
		"aritmetica", "expresion", "termino", "factor"
	};

	private static readonly string[] _LiteralNames = {
		null, null, "'-'", "'*'", "'+'", "'/'", "'('", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "NUM", "RES", "MUL", "SUM", "DIV", "LPAR", "RPAR", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "aritmetica.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static aritmeticaParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public aritmeticaParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public aritmeticaParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class AritmeticaContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(aritmeticaParser.Eof, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpresionContext[] expresion() {
			return GetRuleContexts<ExpresionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpresionContext expresion(int i) {
			return GetRuleContext<ExpresionContext>(i);
		}
		public AritmeticaContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_aritmetica; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IaritmeticaVisitor<TResult> typedVisitor = visitor as IaritmeticaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAritmetica(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AritmeticaContext aritmetica() {
		AritmeticaContext _localctx = new AritmeticaContext(Context, State);
		EnterRule(_localctx, 0, RULE_aritmetica);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 9;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 8;
				expresion(0);
				}
				}
				State = 11;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==NUM || _la==LPAR );
			State = 13;
			Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpresionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TerminoContext termino() {
			return GetRuleContext<TerminoContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExpresionContext expresion() {
			return GetRuleContext<ExpresionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode SUM() { return GetToken(aritmeticaParser.SUM, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RES() { return GetToken(aritmeticaParser.RES, 0); }
		public ExpresionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expresion; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IaritmeticaVisitor<TResult> typedVisitor = visitor as IaritmeticaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExpresion(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExpresionContext expresion() {
		return expresion(0);
	}

	private ExpresionContext expresion(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExpresionContext _localctx = new ExpresionContext(Context, _parentState);
		ExpresionContext _prevctx = _localctx;
		int _startState = 2;
		EnterRecursionRule(_localctx, 2, RULE_expresion, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 16;
			termino(0);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 26;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,2,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 24;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
					case 1:
						{
						_localctx = new ExpresionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expresion);
						State = 18;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 19;
						Match(SUM);
						State = 20;
						termino(0);
						}
						break;
					case 2:
						{
						_localctx = new ExpresionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expresion);
						State = 21;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 22;
						Match(RES);
						State = 23;
						termino(0);
						}
						break;
					}
					} 
				}
				State = 28;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,2,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class TerminoContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public FactorContext factor() {
			return GetRuleContext<FactorContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TerminoContext termino() {
			return GetRuleContext<TerminoContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MUL() { return GetToken(aritmeticaParser.MUL, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DIV() { return GetToken(aritmeticaParser.DIV, 0); }
		public TerminoContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_termino; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IaritmeticaVisitor<TResult> typedVisitor = visitor as IaritmeticaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTermino(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TerminoContext termino() {
		return termino(0);
	}

	private TerminoContext termino(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		TerminoContext _localctx = new TerminoContext(Context, _parentState);
		TerminoContext _prevctx = _localctx;
		int _startState = 4;
		EnterRecursionRule(_localctx, 4, RULE_termino, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 30;
			factor();
			}
			Context.Stop = TokenStream.LT(-1);
			State = 40;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 38;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,3,Context) ) {
					case 1:
						{
						_localctx = new TerminoContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_termino);
						State = 32;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 33;
						Match(MUL);
						State = 34;
						factor();
						}
						break;
					case 2:
						{
						_localctx = new TerminoContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_termino);
						State = 35;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 36;
						Match(DIV);
						State = 37;
						factor();
						}
						break;
					}
					} 
				}
				State = 42;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class FactorContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUM() { return GetToken(aritmeticaParser.NUM, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LPAR() { return GetToken(aritmeticaParser.LPAR, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpresionContext expresion() {
			return GetRuleContext<ExpresionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode RPAR() { return GetToken(aritmeticaParser.RPAR, 0); }
		public FactorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_factor; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IaritmeticaVisitor<TResult> typedVisitor = visitor as IaritmeticaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFactor(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FactorContext factor() {
		FactorContext _localctx = new FactorContext(Context, State);
		EnterRule(_localctx, 6, RULE_factor);
		try {
			State = 48;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case NUM:
				EnterOuterAlt(_localctx, 1);
				{
				State = 43;
				Match(NUM);
				}
				break;
			case LPAR:
				EnterOuterAlt(_localctx, 2);
				{
				State = 44;
				Match(LPAR);
				State = 45;
				expresion(0);
				State = 46;
				Match(RPAR);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 1: return expresion_sempred((ExpresionContext)_localctx, predIndex);
		case 2: return termino_sempred((TerminoContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expresion_sempred(ExpresionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 3);
		case 1: return Precpred(Context, 2);
		}
		return true;
	}
	private bool termino_sempred(TerminoContext _localctx, int predIndex) {
		switch (predIndex) {
		case 2: return Precpred(Context, 3);
		case 3: return Precpred(Context, 2);
		}
		return true;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\n', '\x35', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x3', 
		'\x2', '\x6', '\x2', '\f', '\n', '\x2', '\r', '\x2', '\xE', '\x2', '\r', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\a', '\x3', '\x1B', '\n', '\x3', '\f', '\x3', '\xE', '\x3', 
		'\x1E', '\v', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\a', '\x4', ')', '\n', '\x4', '\f', '\x4', '\xE', '\x4', ',', 
		'\v', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x5', '\x5', '\x33', '\n', '\x5', '\x3', '\x5', '\x2', '\x4', 
		'\x4', '\x6', '\x6', '\x2', '\x4', '\x6', '\b', '\x2', '\x2', '\x2', '\x36', 
		'\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x4', '\x11', '\x3', '\x2', 
		'\x2', '\x2', '\x6', '\x1F', '\x3', '\x2', '\x2', '\x2', '\b', '\x32', 
		'\x3', '\x2', '\x2', '\x2', '\n', '\f', '\x5', '\x4', '\x3', '\x2', '\v', 
		'\n', '\x3', '\x2', '\x2', '\x2', '\f', '\r', '\x3', '\x2', '\x2', '\x2', 
		'\r', '\v', '\x3', '\x2', '\x2', '\x2', '\r', '\xE', '\x3', '\x2', '\x2', 
		'\x2', '\xE', '\xF', '\x3', '\x2', '\x2', '\x2', '\xF', '\x10', '\a', 
		'\x2', '\x2', '\x3', '\x10', '\x3', '\x3', '\x2', '\x2', '\x2', '\x11', 
		'\x12', '\b', '\x3', '\x1', '\x2', '\x12', '\x13', '\x5', '\x6', '\x4', 
		'\x2', '\x13', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x14', '\x15', '\f', 
		'\x5', '\x2', '\x2', '\x15', '\x16', '\a', '\x6', '\x2', '\x2', '\x16', 
		'\x1B', '\x5', '\x6', '\x4', '\x2', '\x17', '\x18', '\f', '\x4', '\x2', 
		'\x2', '\x18', '\x19', '\a', '\x4', '\x2', '\x2', '\x19', '\x1B', '\x5', 
		'\x6', '\x4', '\x2', '\x1A', '\x14', '\x3', '\x2', '\x2', '\x2', '\x1A', 
		'\x17', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x1E', '\x3', '\x2', '\x2', 
		'\x2', '\x1C', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x1C', '\x1D', '\x3', 
		'\x2', '\x2', '\x2', '\x1D', '\x5', '\x3', '\x2', '\x2', '\x2', '\x1E', 
		'\x1C', '\x3', '\x2', '\x2', '\x2', '\x1F', ' ', '\b', '\x4', '\x1', '\x2', 
		' ', '!', '\x5', '\b', '\x5', '\x2', '!', '*', '\x3', '\x2', '\x2', '\x2', 
		'\"', '#', '\f', '\x5', '\x2', '\x2', '#', '$', '\a', '\x5', '\x2', '\x2', 
		'$', ')', '\x5', '\b', '\x5', '\x2', '%', '&', '\f', '\x4', '\x2', '\x2', 
		'&', '\'', '\a', '\a', '\x2', '\x2', '\'', ')', '\x5', '\b', '\x5', '\x2', 
		'(', '\"', '\x3', '\x2', '\x2', '\x2', '(', '%', '\x3', '\x2', '\x2', 
		'\x2', ')', ',', '\x3', '\x2', '\x2', '\x2', '*', '(', '\x3', '\x2', '\x2', 
		'\x2', '*', '+', '\x3', '\x2', '\x2', '\x2', '+', '\a', '\x3', '\x2', 
		'\x2', '\x2', ',', '*', '\x3', '\x2', '\x2', '\x2', '-', '\x33', '\a', 
		'\x3', '\x2', '\x2', '.', '/', '\a', '\b', '\x2', '\x2', '/', '\x30', 
		'\x5', '\x4', '\x3', '\x2', '\x30', '\x31', '\a', '\t', '\x2', '\x2', 
		'\x31', '\x33', '\x3', '\x2', '\x2', '\x2', '\x32', '-', '\x3', '\x2', 
		'\x2', '\x2', '\x32', '.', '\x3', '\x2', '\x2', '\x2', '\x33', '\t', '\x3', 
		'\x2', '\x2', '\x2', '\b', '\r', '\x1A', '\x1C', '(', '*', '\x32',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
