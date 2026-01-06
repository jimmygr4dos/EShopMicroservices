
namespace Basket.API.Basket.DeleteBasket;

public record DeleBasketCommand(string UserName) : ICommand<DeleteBasketResult>;

public record DeleteBasketResult(bool IsSuccess);

public class DeleteBasketCommandValidator : AbstractValidator<DeleBasketCommand>
{
    public DeleteBasketCommandValidator()
    {
        RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName is required");
    }
}

public class DeleteBasketCommandHandler
    : ICommandHandler<DeleBasketCommand, DeleteBasketResult>
{
    public async Task<DeleteBasketResult> Handle(DeleBasketCommand command, CancellationToken cancellationToken)
    {
        //TODO: delete basket from database and cache
        //session.Delete<Produc>(command.Id);

        return new DeleteBasketResult(true);
    }
}
