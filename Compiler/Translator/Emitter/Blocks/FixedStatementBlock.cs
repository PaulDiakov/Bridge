using Bridge.Contract;
using ICSharpCode.NRefactory.CSharp;

namespace Bridge.Translator
{
    public class FixedStatementBlock : AbstractEmitterBlock
    {
        public FixedStatementBlock(IEmitter emitter, FixedStatement fixedStatement)
            : base(emitter, fixedStatement)
        {
            this.Emitter = emitter;
            this.FixedStatement = fixedStatement;
        }

        public FixedStatement FixedStatement
        {
            get;
            set;
        }
        
        protected override void DoEmit()
        {
            this.VisitFixedStatementStatement();
        }

        protected void VisitFixedStatementStatement()
        {
            FixedStatement fixedStatement = FixedStatement;

            foreach (VariableInitializer fixedVar in fixedStatement.Variables)
            {
                this.WriteVar();
                this.Write(fixedVar.Name);
                this.Write(" = System.JsPtr.toFixed(");
                fixedVar.Initializer.AcceptVisitor(Emitter);
                this.Write(")");
                this.WriteSemiColon();
                this.WriteNewLine();
            }

            Emitter.NoBraceBlock = fixedStatement.EmbeddedStatement;
            fixedStatement.EmbeddedStatement.AcceptVisitor(Emitter);
            Emitter.NoBraceBlock = null;
        }
    }
}