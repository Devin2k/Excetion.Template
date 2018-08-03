## 异常XML

### 测试异常1范围业务异常

==StateCode 范围[12000,13000]==

statusCode 值 | 消息内容 | 错误说明 | Exception 类名
---|---|---|---
12001|异常1,无参构造异常|异常1,无参构造异常|Demo1ErrorException
12002|用户:{0}权限不足|该用户没有这个权限|UserAuthorityErrorException

### 测试异常2范围业务异常

==StateCode 范围[13000,14000]==

statusCode 值 | 消息内容 | 错误说明 | Exception 类名
---|---|---|---
12001|异常2,无参构造异常|异常1,无参构造异常|Demo2ErrorException
