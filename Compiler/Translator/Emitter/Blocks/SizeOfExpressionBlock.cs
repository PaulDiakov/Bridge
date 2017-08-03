using Bridge.Contract;
using ICSharpCode.NRefactory.CSharp;
using ICSharpCode.NRefactory.Semantics;

namespace Bridge.Translator
{
    public class SizeOfExpressionBlock : AbstractEmitterBlock
    {
        public SizeOfExpressionBlock(IEmitter emitter, SizeOfExpression sizeOfExpression)
            : base(emitter, sizeOfExpression)
        {
            this.Emitter = emitter;
            this.SizeOfExpression = sizeOfExpression;
        }

        public SizeOfExpression SizeOfExpression
        {
            get;
            set;
        }

        protected override void DoEmit()
        {
            this.VisitSizeOfExpression();
        }

        protected void VisitSizeOfExpression()
        {
            SizeOfExpression sizeOfExpression = SizeOfExpression;
            var rr = this.Emitter.Resolver.ResolveNode(sizeOfExpression, this.Emitter);
            
            if (rr is SizeOfResolveResult sizeOfRr)
            {
                if (sizeOfRr.IsCompileTimeConstant)
                {
                    this.Write(sizeOfRr.ConstantValue);
                }
                else
                {
                    this.Write("Bridge.GetNativeSizeOf");
                    this.WriteOpenParentheses();
                    this.Write(BridgeTypes.ToJsName(sizeOfRr.Type, this.Emitter));
                    this.WriteCloseParentheses();
                }
            }
        }
    }
}