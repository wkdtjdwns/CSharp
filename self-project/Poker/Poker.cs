// 카드 뽑기
List<string> deck = GenerateDeck();
List<string> shuffledDeck = ShuffleDeck(deck);
List<string> hand = shuffledDeck.Take(5).ToList();

// 카드 족보 확인
(string handRank, string details) = CheckHand(hand);

// 출력
Console.WriteLine("Hand:");
foreach (string card in hand) { Console.WriteLine(card); }
Console.WriteLine($"Hand Rank: {details} {handRank}");

List<string> GenerateDeck()
{
    string[] kinds = { "Hearts", "Diamonds", "Clubs", "Spades" };
    string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
    List<string> deck = new List<string>();

    foreach (string kind in kinds)
    {
        foreach (string rank in ranks)
        {
            deck.Add($"{rank} of {kind}");
        }
    }

    return deck;
}

// 카드를 랜덤으로 가져오는 메서드
List<string> ShuffleDeck(List<string> deck)
{
    Random random = new Random();
    for (int i = deck.Count - 1; i > 0; i--)
    {
        int j = random.Next(0, i + 1);
        string temp = deck[i];
        deck[i] = deck[j];
        deck[j] = temp;
    }

    return deck;
}

// 사용자에게 입력을 받을 때 사용하는 코드들 (대신 위에 있는 3줄을 지우고 아래의 코드는 맨 위로 올려야 함.)
/*List<string> hand = GetHandFromUser();

List<string> GetHandFromUser()
{
    List<string> hand = new List<string>();
    Console.WriteLine("'Rank of kind'의 형식으로 5개의 카드를 입력해주세요. (ex: '10 of Hearts'):");

    while (hand.Count < 5)
    {
        string str = Console.ReadLine();
        if (checkCard(str))
        {
            hand.Add(str);
        }
        else
        {
            Console.WriteLine("잘못된 형식의 입력입니다. 'Rank of kind'의 형식으로 5개의 카드를 입력해주세요. (ex: '10 of Hearts'):");
        }
    }

    return hand;
}

bool checkCard(string card)
{
    string[] checkRanks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
    string[] checkKinds = { "Hearts", "Diamonds", "Clubs", "Spades" };

    string[] parts = card.Split(new[] { " of " }, StringSplitOptions.None);
    if (parts.Length != 2) return false;

    string rank = parts[0].Trim();
    string kind = parts[1].Trim();

    return checkRanks.Contains(rank) && checkKinds.Contains(kind);
}*/

// 카드의 족보를 확인하는 메서드
(string, string) CheckHand(List<string> hand)
{
    List<string> ranks = hand.Select(card => card.Split(" ")[0]).ToList();
    List<string> kinds = hand.Select(card => card.Split(" ")[2]).ToList();

    bool isFlush = kinds.Distinct().Count() == 1;
    bool isStraight = IsStraight(ranks);
    bool isFourOfAKind = IsFourOfAKind(ranks);
    bool isFullHouse = IsFullHouse(ranks);
    bool isThreeOfAKind = IsThreeOfAKind(ranks);
    bool isTwoPair = IsTwoPair(ranks);
    bool isOnePair = IsOnePair(ranks);

    if (isFlush && isStraight) return ("Straight Flush", GetFlushDetails(hand));
    if (isFourOfAKind) return ("Four of a Kind", GetFourOfAKindDetails(ranks));
    if (isFullHouse) return ("Full House", GetFullHouseDetails(ranks));
    if (isFlush) return ("Flush", GetFlushDetails(hand));
    if (isStraight) return ("Straight", GetStraightDetails(ranks));
    if (isThreeOfAKind) return ("Three of a Kind", GetThreeOfAKindDetails(ranks));
    if (isTwoPair) return ("Two Pair", GetTwoPairDetails(ranks));
    if (isOnePair) return ("One Pair", GetOnePairDetails(ranks));

    return ("High Card", GetHighCardDetails(ranks));
}

// 위에서 뽑은 덱이 각 족보에 해당하는 지 판단하는 메서드들
bool IsStraight(List<string> ranks)
{
    List<string> rankOrder = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
    List<int> cards = ranks.Select(rank => rankOrder.IndexOf(rank)).OrderBy(index => index).ToList();

    for (int i = 0; i < cards.Count - 1; i++)
    {
        if (cards[i] + 1 != cards[i + 1])
        {
            return false;
        }
    }

    return true;
}

bool IsFourOfAKind(List<string> ranks)
{
    return ranks.GroupBy(rank => rank).Any(group => group.Count() == 4);
}

bool IsFullHouse(List<string> ranks)
{
    List<IGrouping<string, string>> rankGroups = ranks.GroupBy(rank => rank).ToList();
    bool isThreeOfAKind = rankGroups.Any(group => group.Count() == 3);
    bool isPair = rankGroups.Any(group => group.Count() == 2);

    return isThreeOfAKind && isPair;
}

bool IsThreeOfAKind(List<string> ranks)
{
    return ranks.GroupBy(rank => rank).Any(group => group.Count() == 3);
}

bool IsTwoPair(List<string> ranks)
{
    return ranks.GroupBy(rank => rank).Where(group => group.Count() == 2).Count() == 2;
}

bool IsOnePair(List<string> ranks)
{
    return ranks.GroupBy(rank => rank).Any(group => group.Count() == 2);
}
// 위에서 뽑은 덱이 각 족보에 해당하는 지 판단하는 메서드들

// 위에서 뽑은 덱이 각 족보에 해당하면 어떤 카드가 해당했는 지 알려주는 메서드들
string GetFlushDetails(List<string> hand)
{
    List<string> flushRanks = hand.Select(card => card.Split(" ")[2]).OrderBy(rank => rank).ToList();
    return string.Join(" ", flushRanks.Take(1));
}

string GetFourOfAKindDetails(List<string> hand)
{
    string fourOfAKindRank = hand.GroupBy(card => card.Split(" ")[0]).Where(group => group.Count() == 4).First().Key;
    return string.Join(" ", hand.Where(card => card.Split(" ")[0] == fourOfAKindRank).Select(card => card.Split(" ")[0]).Distinct().Take(1));
}

string GetFullHouseDetails(List<string> hand)
{
    string threeOfAKindRank = hand.GroupBy(card => card.Split(" ")[0]).Where(group => group.Count() == 3).First().Key;
    string pairRank = hand.GroupBy(card => card.Split(" ")[0]).Where(group => group.Count() == 2).First().Key;

    return string.Join(" ", hand.Where(card => card.Split(" ")[0] == threeOfAKindRank || card.Split(" ")[0] == pairRank)
                                 .Select(card => card.Split(" ")[0])
                                 .Distinct()
                                 .Take(3));
}

string GetStraightDetails(List<string> hand)
{
    List<string> straightCards = hand.OrderBy(card => card.Split(" ")[0]).Select(card => card.Split(" ")[0]).ToList();
    return string.Join(" ", straightCards.Take(5));
}

string GetThreeOfAKindDetails(List<string> hand)
{
    string threeOfAKindRank = hand.GroupBy(card => card.Split(" ")[0]).Where(group => group.Count() == 3).First().Key;
    return string.Join(" ", hand.Where(card => card.Split(" ")[0] == threeOfAKindRank).Select(card => card.Split(" ")[0]).Distinct().Take(1));
}

string GetTwoPairDetails(List<string> hand)
{
    List<string> pairs = hand.GroupBy(card => card.Split(" ")[0])
                             .Where(group => group.Count() == 2)
                             .Select(group => group.Key)
                             .OrderBy(rank => rank)
                             .Take(2)
                             .ToList();

    List<string> pairCards = hand.Where(card => pairs.Contains(card.Split(" ")[0]))
                                 .Select(card => card.Split(" ")[0])
                                 .Distinct()
                                 .ToList();

    return string.Join(" ", pairCards);
}

string GetOnePairDetails(List<string> hand)
{
    string pairRank = hand.GroupBy(card => card.Split(" ")[0]).Where(group => group.Count() == 2).First().Key;
    string pairCard = hand.First(card => card.Contains(pairRank)).Split(" ")[0];

    return pairCard;
}

string GetHighCardDetails(List<string> hand)
{
    return hand.OrderByDescending(card => card.Split(" ")[0]).First().Split(" ")[0];
}
// 위에서 뽑은 덱이 각 족보에 해당하면 어떤 카드가 해당했는 지 알려주는 메서드들
