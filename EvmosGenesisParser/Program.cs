using EvmosGenesisParser.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

Console.WriteLine("Reading the Genesis...");

using var f = File.OpenText("D:\\Projects\\mine\\evmos-genesis-parser\\EvmosGenesisParser\\genesis.json");
using var reader = new JsonTextReader(f);

while (reader.Read())
{
    if (reader.TokenType == JsonToken.StartArray && reader.Path == "app_state.auth.accounts")
    {
        ParseAuthAccounts(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.auth.params")
    {
        ParseAuthParams(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.authz")
    {
        ParseAuthz(reader);
    }

    if (reader.TokenType == JsonToken.StartArray && reader.Path == "app_state.bank.balances")
    {
        ParseBankBalances(reader);
    }

    if (reader.TokenType == JsonToken.StartArray && reader.Path == "app_state.bank.denom_metadata")
    {
        ParseBankDenomMetadata(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.bank.params")
    {
        ParseBankParams(reader);
    }

    if (reader.TokenType == JsonToken.StartArray && reader.Path == "app_state.bank.supply")
    {
        ParseBankSupply(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.capability")
    {
        ParseCapability(reader);
    }

    if (reader.TokenType == JsonToken.StartArray && reader.Path == "app_state.claims.claims_records")
    {
        ParseClaimRecords(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.claims.params")
    {
        ParseClaimParams(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.crisis")
    {
        ParseCrisis(reader);
    }

    if (reader.TokenType == JsonToken.StartArray && reader.Path == "app_state.distribution.delegator_starting_infos")
    {
        ParseDistributionDelegatorStartingInfos(reader);
    }

    if (reader.TokenType == JsonToken.StartArray && reader.Path == "app_state.distribution.delegator_withdraw_infos")
    {
        ParseDistributionDelegatorWithdrawInfos(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.distribution.fee_pool")
    {
        ParseDistributionFeePool(reader);
    }

    if (reader.TokenType == JsonToken.StartArray && reader.Path == "app_state.distribution.outstanding_rewards")
    {
        ParseDistributionOutstandingRewards(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.distribution.params")
    {
        ParseDistributionParams(reader);
    }

    if (reader.Path == "app_state.distribution.previous_proposer")
    {
        ParseDistributionPreviousProposer(reader);
    }

    if (reader.TokenType == JsonToken.StartArray && reader.Path == "app_state.distribution.validator_accumulated_commissions")
    {
        ParseDistributionValidatorAccumulatedCommissions(reader);
    }

    if (reader.TokenType == JsonToken.StartArray && reader.Path == "app_state.distribution.validator_current_rewards")
    {
        ParseDistributionValidatorCurrentRewards(reader);
    }

    if (reader.TokenType == JsonToken.StartArray && reader.Path == "app_state.distribution.validator_historical_rewards")
    {
        ParseDistributionValidatorHistoricalRewards(reader);
    }

    if (reader.TokenType == JsonToken.StartArray && reader.Path == "app_state.distribution.validator_slash_events")
    {
        ParseDistributionValidatorSlashEvents(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.epochs")
    {
        ParseEpochs(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.erc20")
    {
        ParseErc20(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.evidence")
    {
        ParseEvidence(reader);
    }

    if (reader.TokenType == JsonToken.StartArray && reader.Path == "app_state.evm.accounts")
    {
        ParseEvmAccounts(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.evm.params")
    {
        ParseEvmParams(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.feegrant")
    {
        ParseFeeGrant(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.feemarket")
    {
        ParseFeeMarket(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.genutil")
    {
        ParseGenUtil(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.gov")
    {
        ParseGov(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.ibc")
    {
        ParseIbc(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.incentives")
    {
        ParseIncentives(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.inflation")
    {
        ParseInflation(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.params")
    {
        ParseParams(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.slashing")
    {
        ParseSlashing(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.staking")
    {
        ParseStaking(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.transfer")
    {
        ParseTransfer(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.upgrade")
    {
        ParseUpgrade(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.vesting")
    {
        ParseVesting(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "app_state.recovery")
    {
        ParseRecovery(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "chain_id")
    {
        //ParseUpgrade(reader);
        continue;
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "consensus_params")
    {
        ParseConsensusParams(reader);
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "genesis_time")
    {
        //ParseConsensusParams(reader);
        continue;
    }

    if (reader.TokenType == JsonToken.StartObject && reader.Path == "initial_height")
    {
        //ParseConsensusParams(reader);
        continue;
    }

    if (reader.TokenType == JsonToken.StartArray && reader.Path == "validators")
    {
        ParseValidators(reader);
    }

    // Console.WriteLine(reader.Path);
}

Console.WriteLine("Done");

void ParseAuthAccounts(JsonTextReader reader)
{
    Console.WriteLine("Parsing accounts...");
    var count = 0;
    do
    {
        if (reader.TokenType == JsonToken.EndArray && reader.Path == "app_state.auth.accounts") break;
        if (reader.TokenType == JsonToken.StartObject && reader.Path.EndsWith("base_account"))
        {
            if (TryParseBaseAccount(reader))
            {
                count++;
            }
            
        }
    } while (reader.Read());

    Console.WriteLine("Accounts parsed {0}", count);
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

bool TryParseBaseAccount(JsonTextReader reader)
{
    var account = new JsonSerializer().Deserialize<BaseAccount>(reader);
    if (account == null) 
        return false;

    // Console.WriteLine(account.Address);
    return true;
}

void ParseAuthParams(JsonTextReader reader)
{
    Console.WriteLine("Parsing auth params...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.auth.params") break;
    } while (reader.Read());

    Console.WriteLine("Auth params parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseAuthz(JsonTextReader reader)
{
    Console.WriteLine("Parsing authz...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.authz") break;
    } while (reader.Read());

    Console.WriteLine("Authz parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseBankBalances(JsonTextReader reader)
{
    Console.WriteLine("Parsing balances...");
    var count = 0;
    do
    {
        if (reader.TokenType == JsonToken.EndArray && reader.Path == "app_state.bank.balances") break;
        if (reader.TokenType == JsonToken.StartObject)
        {
            if (TryParseBankBalance(reader))
            {
                count++;
            }

        }
    } while (reader.Read());

    Console.WriteLine("Balances parsed {0}", count);
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

bool TryParseBankBalance(JsonTextReader reader)
{
    var balance = new JsonSerializer().Deserialize<BankBalance>(reader);
    if (balance == null)
        return false;

    // Console.WriteLine(account.Address);
    return true;
}

void ParseBankDenomMetadata(JsonTextReader reader)
{
    Console.WriteLine("Parsing bank denom metadata...");
    do
    {
        if (reader.TokenType == JsonToken.EndArray && reader.Path == "app_state.bank.denom_metadata") break;
    } while (reader.Read());

    Console.WriteLine("Bank denom metadata parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseBankParams(JsonTextReader reader)
{
    Console.WriteLine("Parsing bank params...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.bank.params") break;
    } while (reader.Read());

    Console.WriteLine("Bank params parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseBankSupply(JsonTextReader reader)
{
    Console.WriteLine("Parsing bank supply...");
    var count = 0;
    do
    {
        if (reader.TokenType == JsonToken.EndArray && reader.Path == "app_state.bank.supply") break;
        if (reader.TokenType == JsonToken.StartObject)
        {
            if (TryParseBankSupply(reader))
            {
                count++;
            }

        }
    } while (reader.Read());

    Console.WriteLine("Bank supply parsed {0}", count);
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

bool TryParseBankSupply(JsonTextReader reader)
{
    var coin = new JsonSerializer().Deserialize<Coin>(reader);
    if (coin == null)
        return false;

    // Console.WriteLine(account.Address);
    return true;
}

void ParseCapability(JsonTextReader reader)
{
    Console.WriteLine("Parsing capabilities...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.capability") break;
    } while (reader.Read());

    Console.WriteLine("Capabilities parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseClaimRecords(JsonTextReader reader)
{
    Console.WriteLine("Parsing claim records...");
    var count = 0;
    do
    {
        if (reader.TokenType == JsonToken.EndArray && reader.Path == "app_state.claims.claims_records") break;
        if (reader.TokenType == JsonToken.StartObject)
        {
            if (TryParseClaimRecord(reader))
            {
                count++;
            }

        }
    } while (reader.Read());

    Console.WriteLine("Claim records parsed {0}", count);
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

bool TryParseClaimRecord(JsonTextReader reader)
{
    var claim = new JsonSerializer().Deserialize<ClaimRecord>(reader);
    if (claim == null)
        return false;

    // Console.WriteLine(account.Address);
    return true;
}

void ParseClaimParams(JsonTextReader reader)
{
    Console.WriteLine("Parsing claim params...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.claims.params") break;
    } while (reader.Read());

    Console.WriteLine("Claim params parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseCrisis(JsonTextReader reader)
{
    Console.WriteLine("Parsing crisis...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.crisis") break;
    } while (reader.Read());

    Console.WriteLine("Crisis parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseDistributionDelegatorStartingInfos(JsonTextReader reader)
{
    Console.WriteLine("Parsing distribution delegator starting infos...");
    var count = 0;
    do
    {
        if (reader.TokenType == JsonToken.EndArray && reader.Path == "app_state.distribution.delegator_starting_infos") break;
        if (reader.TokenType == JsonToken.StartObject)
        {
            if (TryParseDistributionDelegatorStartingInfo(reader))
            {
                count++;
            }

        }
    } while (reader.Read());

    Console.WriteLine("Distribution delegator starting infos parsed {0}", count);
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

bool TryParseDistributionDelegatorStartingInfo(JsonTextReader reader)
{
    var delegation = new JsonSerializer().Deserialize<DistributionDelegatorStartingInfo>(reader);
    if (delegation == null)
        return false;

    // Console.WriteLine(account.Address);
    return true;
}

void ParseDistributionDelegatorWithdrawInfos(JsonTextReader reader)
{
    Console.WriteLine("Parsing distribution delegator withdraw infos...");
    do
    {
        if (reader.TokenType == JsonToken.EndArray && reader.Path == "app_state.distribution.delegator_withdraw_infos") break;
    } while (reader.Read());

    Console.WriteLine("Distribution delegator withdraw infos parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseDistributionFeePool(JsonTextReader reader)
{
    Console.WriteLine("Parsing distribution fee pool...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.distribution.fee_pool") break;
    } while (reader.Read());

    Console.WriteLine("Distribution fee pool parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseDistributionOutstandingRewards(JsonTextReader reader)
{
    Console.WriteLine("Parsing distribution outstanding rewards...");
    do
    {
        if (reader.TokenType == JsonToken.EndArray && reader.Path == "app_state.distribution.outstanding_rewards") break;
    } while (reader.Read());

    Console.WriteLine("Distribution outstanding rewards parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseDistributionParams(JsonTextReader reader)
{
    Console.WriteLine("Parsing distribution params...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.distribution.params") break;
    } while (reader.Read());

    Console.WriteLine("Distribution params parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseDistributionPreviousProposer(JsonTextReader reader)
{
    Console.WriteLine("Parsing distribution previous proposer...");

    reader.Read();

    Console.WriteLine("Distribution previous proposer parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseDistributionValidatorAccumulatedCommissions(JsonTextReader reader)
{
    Console.WriteLine("Parsing distribution validator accumulated commissions...");
    do
    {
        if (reader.TokenType == JsonToken.EndArray && reader.Path == "app_state.distribution.validator_accumulated_commissions") break;
    } while (reader.Read());

    Console.WriteLine("Distribution validator accumulated commissions parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseDistributionValidatorCurrentRewards(JsonTextReader reader)
{
    Console.WriteLine("Parsing distribution validator current rewards...");
    do
    {
        if (reader.TokenType == JsonToken.EndArray && reader.Path == "app_state.distribution.validator_current_rewards") break;
    } while (reader.Read());

    Console.WriteLine("Distribution validator current rewards parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseDistributionValidatorHistoricalRewards(JsonTextReader reader)
{
    Console.WriteLine("Parsing validator historical rewards...");
    do
    {
        if (reader.TokenType == JsonToken.EndArray && reader.Path == "app_state.distribution.validator_historical_rewards") break;
    } while (reader.Read());

    Console.WriteLine("Validator historical rewards parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseDistributionValidatorSlashEvents(JsonTextReader reader)
{
    Console.WriteLine("Parsing distribution validator slash events...");
    do
    {
        if (reader.TokenType == JsonToken.EndArray && reader.Path == "app_state.distribution.validator_slash_events") break;
    } while (reader.Read());

    Console.WriteLine("Distribution validator slash events parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseEpochs(JsonTextReader reader)
{
    Console.WriteLine("Parsing epochs...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.epochs") break;
    } while (reader.Read());

    Console.WriteLine("Epochs parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseErc20(JsonTextReader reader)
{
    Console.WriteLine("Parsing ERC20...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.erc20") break;
    } while (reader.Read());

    Console.WriteLine("ERC20 parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseEvidence(JsonTextReader reader)
{
    Console.WriteLine("Parsing evidence...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.evidence") break;
    } while (reader.Read());

    Console.WriteLine("Evidence parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseEvmAccounts(JsonTextReader reader)
{
    Console.WriteLine("Parsing EVM accounts...");
    do
    {
        if (reader.TokenType == JsonToken.EndArray && reader.Path == "app_state.evm.accounts") break;
    } while (reader.Read());

    Console.WriteLine("EVM accounts parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseEvmParams(JsonTextReader reader)
{
    Console.WriteLine("Parsing EVM params...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.evm.params") break;
    } while (reader.Read());

    Console.WriteLine("EVM params parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseFeeGrant(JsonTextReader reader)
{
    Console.WriteLine("Parsing fee grant...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.feegrant") break;
    } while (reader.Read());

    Console.WriteLine("Fee grant parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseFeeMarket(JsonTextReader reader)
{
    Console.WriteLine("Parsing fee market...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.feemarket") break;
    } while (reader.Read());

    Console.WriteLine("Fee market parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseGenUtil(JsonTextReader reader)
{
    Console.WriteLine("Parsing genutil...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.genutil") break;
    } while (reader.Read());

    Console.WriteLine("Genutil parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseGov(JsonTextReader reader)
{
    Console.WriteLine("Parsing gov...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.gov") break;
    } while (reader.Read());

    Console.WriteLine("Gov parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseIbc(JsonTextReader reader)
{
    Console.WriteLine("Parsing IBC...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.ibc") break;
    } while (reader.Read());

    Console.WriteLine("IBC parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseIncentives(JsonTextReader reader)
{
    Console.WriteLine("Parsing incentives...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.incentives") break;
    } while (reader.Read());

    Console.WriteLine("Incentives parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseInflation(JsonTextReader reader)
{
    Console.WriteLine("Parsing inflation...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.inflation") break;
    } while (reader.Read());

    Console.WriteLine("Inflation parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseParams(JsonTextReader reader)
{
    Console.WriteLine("Parsing params...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.params") break;
    } while (reader.Read());

    Console.WriteLine("Params parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseSlashing(JsonTextReader reader)
{
    Console.WriteLine("Parsing slashing...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.slashing") break;
    } while (reader.Read());

    Console.WriteLine("Slashing parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseStaking(JsonTextReader reader)
{
    Console.WriteLine("Parsing staking...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.staking") break;
    } while (reader.Read());

    Console.WriteLine("Staking parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseTransfer(JsonTextReader reader)
{
    Console.WriteLine("Parsing transfer...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.transfer") break;
    } while (reader.Read());

    Console.WriteLine("Transfer parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseUpgrade(JsonTextReader reader)
{
    Console.WriteLine("Parsing upgrade...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.upgrade") break;
    } while (reader.Read());

    Console.WriteLine("Upgrade parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseVesting(JsonTextReader reader)
{
    Console.WriteLine("Parsing vesting...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.vesting") break;
    } while (reader.Read());

    Console.WriteLine("Vesting parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseRecovery(JsonTextReader reader)
{
    Console.WriteLine("Parsing recovery...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "app_state.recovery") break;
    } while (reader.Read());

    Console.WriteLine("Recovery parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseConsensusParams(JsonTextReader reader)
{
    Console.WriteLine("Parsing consensus_params...");
    do
    {
        if (reader.TokenType == JsonToken.EndObject && reader.Path == "consensus_params") break;
    } while (reader.Read());

    Console.WriteLine("Consensus params parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}

void ParseValidators(JsonTextReader reader)
{
    Console.WriteLine("Parsing validators...");
    do
    {
        if (reader.TokenType == JsonToken.EndArray && reader.Path == "validators") break;
    } while (reader.Read());

    Console.WriteLine("Validators params parsing skipped");
    Console.WriteLine("Press [ENTER] to continue parsing...");
    Console.ReadLine();
}