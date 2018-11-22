/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 80011
Source Host           : localhost:3306
Source Database       : myoracle

Target Server Type    : MYSQL
Target Server Version : 80011
File Encoding         : 65001

Date: 2018-11-11 16:47:39
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for answer
-- ----------------------------
DROP TABLE IF EXISTS `answer`;
CREATE TABLE `answer` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Quesid` int(11) NOT NULL,
  `Replyerid` int(11) NOT NULL,
  `Replyername` varchar(200) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `Replytime` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP,
  `Reply` varchar(1024) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of answer
-- ----------------------------
INSERT INTO `answer` VALUES ('36', '85', '1', '彭老师', '2018-11-11 11:41:00', '你打开CMD输入上面的，然后再一步一步来就行了');

-- ----------------------------
-- Table structure for comment
-- ----------------------------
DROP TABLE IF EXISTS `comment`;
CREATE TABLE `comment` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Answerid` int(11) NOT NULL,
  `Senderid` int(11) NOT NULL,
  `Sendername` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Message` varchar(1024) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of comment
-- ----------------------------
INSERT INTO `comment` VALUES ('14', '23', '111', '张鑫', '嗯嗯，已经解决了，谢谢老师');
INSERT INTO `comment` VALUES ('25', '27', '1', '彭老师', '1');
INSERT INTO `comment` VALUES ('27', '36', '111', '张鑫', '喔喔，谢谢老师');

-- ----------------------------
-- Table structure for news
-- ----------------------------
DROP TABLE IF EXISTS `news`;
CREATE TABLE `news` (
  `Id` int(11) NOT NULL,
  `Title` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `Info` varchar(2048) COLLATE utf8_unicode_ci NOT NULL,
  `Time` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP,
  `Fromid` int(11) NOT NULL,
  `Fromname` varchar(200) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `Class` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of news
-- ----------------------------
INSERT INTO `news` VALUES ('1', '通知一', '这是通知一', '2018-11-10 17:02:44', '1', '彭老师', '1');
INSERT INTO `news` VALUES ('2', '通知二', '这是通知二', '2018-11-10 17:02:47', '1', '彭老师', '1');
INSERT INTO `news` VALUES ('3', '通知三', '这是通知三', '2018-11-10 17:02:52', '1', '彭老师', '1');
INSERT INTO `news` VALUES ('4', '通知四', '这是通知四', '2018-11-10 17:02:55', '1', '彭老师', '1');
INSERT INTO `news` VALUES ('5', '通知五', '这是通知五', '2018-11-10 17:02:58', '1', '彭老师', '1');
INSERT INTO `news` VALUES ('6', '通知六', '这是通知六', '2018-11-10 17:03:00', '1', '彭老师', '1');
INSERT INTO `news` VALUES ('7', '通知七', '这是通知七', '2018-11-10 17:03:02', '1', '彭老师', '1');

-- ----------------------------
-- Table structure for question
-- ----------------------------
DROP TABLE IF EXISTS `question`;
CREATE TABLE `question` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Quesname` varchar(200) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Info` varchar(2048) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `Querid` int(11) NOT NULL,
  `Quername` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `Subtime` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP,
  `Picture` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=86 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of question
-- ----------------------------
INSERT INTO `question` VALUES ('85', '如何卸载Oracle数据库', '卸载显示如图，该怎么做？', '111', '张鑫', '2018-11-11 11:24:00', '/picture/2417db5b-a001-424f-830c-12b887e1d02d.jpg');

-- ----------------------------
-- Table structure for scenetest
-- ----------------------------
DROP TABLE IF EXISTS `scenetest`;
CREATE TABLE `scenetest` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `Info` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of scenetest
-- ----------------------------
INSERT INTO `scenetest` VALUES ('1', '场景一测试', 'Oracle 11g的安装。');
INSERT INTO `scenetest` VALUES ('2', '场景二测试', '启动Oracle 11g数据库。');
INSERT INTO `scenetest` VALUES ('3', '场景三测试', '深入了解Oracle 11g的体系结构。');
INSERT INTO `scenetest` VALUES ('4', '场景四测试', 'Oracle 11g的PL/SQL引擎和SQL引擎。');
INSERT INTO `scenetest` VALUES ('5', '场景五测试', '在数据库中创建用户数据库。');
INSERT INTO `scenetest` VALUES ('6', '场景六测试', '对数据库中的各类对象进行相关权限管理、安全控制。');
INSERT INTO `scenetest` VALUES ('7', '场景七测试', '在数据库中创建存储过程、函数、触发器、程序包。');
INSERT INTO `scenetest` VALUES ('8', '场景八测试', '数据库中的事务处理及备份与恢复。');

-- ----------------------------
-- Table structure for score
-- ----------------------------
DROP TABLE IF EXISTS `score`;
CREATE TABLE `score` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` int(11) NOT NULL,
  `Testscore` int(11) NOT NULL,
  `Testid` int(11) NOT NULL,
  `Testname` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `Testtime` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP,
  `Scene` int(11) DEFAULT NULL,
  `Term` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=63 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of score
-- ----------------------------

-- ----------------------------
-- Table structure for test
-- ----------------------------
DROP TABLE IF EXISTS `test`;
CREATE TABLE `test` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Testid` int(11) NOT NULL,
  `Question` varchar(1024) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Info` varchar(1024) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `Op1` varchar(400) COLLATE utf8_unicode_ci NOT NULL,
  `Op2` varchar(400) COLLATE utf8_unicode_ci NOT NULL,
  `Op3` varchar(400) COLLATE utf8_unicode_ci NOT NULL,
  `Op4` varchar(400) COLLATE utf8_unicode_ci NOT NULL,
  `Answ` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `Mark` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=95 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of test
-- ----------------------------
INSERT INTO `test` VALUES ('12', '4', '启动数据库的命令?', null, 'startup', 'startup open', 'shutdown', 'startup database', 'A', '10');
INSERT INTO `test` VALUES ('15', '4', '哪项是启动数据库时用来记录数据文件、联机日志文件的相关信息的二进制文件？', null, '数据文件', '参数文件', '控制文件', '归档文件', 'C', '10');
INSERT INTO `test` VALUES ('16', '4', '用于在启动实例时配置数据库，确定 Oracle 11g 的运行环境文件是？', null, '参数文件', '数据文件', '可执行文件', '控制文件', 'A', '10');
INSERT INTO `test` VALUES ('17', '4', '使用Oracle数据库，必须启动哪个服务？', null, 'OracleHOME_NAMETNSListener', 'OracleServiceSID', 'OracleMTSRecoveryService', 'OracleJobSchedulerSID', 'B', '10');
INSERT INTO `test` VALUES ('18', '4', '在Windows操作系统中，Oracle的（  ）服务监听并接受来自客户端应用程序的连接请求。', null, 'OracleHOME_NAMETNSListener', 'OracleServiceSID', 'OracleHOME_NAMEAgent', 'OracleHOME_NAMEHTTPServer', 'A', '10');
INSERT INTO `test` VALUES ('19', '4', '数据库启动过程中何时读取参数文件？', null, '打开数据库时', '装载数据库时', '实例启动时', '以上所有项', 'C', '10');
INSERT INTO `test` VALUES ('20', '4', '关闭数据库时，首先会', null, '关闭数据库实例', '卸载数据库', '关闭数据库', '关闭操作糸统', 'C', '10');
INSERT INTO `test` VALUES ('21', '4', '数据库启动时，何时会读取控制文件?', null, '打开数据库时', '安装数据库时', '实例启动过程中', '在每个阶段', 'B', '10');
INSERT INTO `test` VALUES ('22', '4', '数据库的默认启动选项', null, 'MOUNT', 'NOMOUNT', 'READ ONLY', 'OPEN', 'D', '10');
INSERT INTO `test` VALUES ('23', '4', '哪项是Oracle服务器在启动期间用来标识物理文件和数据库结构的二进制文件？', null, '控制文件', '参数文件', '数据文件', '日志文件', 'A', '10');
INSERT INTO `test` VALUES ('24', '7', '哪项代表了数据库中最小粒度的逻辑数据存储层次？', null, '盘区', '表空间', '数据块', '数据文件', 'C', '10');
INSERT INTO `test` VALUES ('25', '7', '下列选项中，哪一部分不是 Oracle实例的组成部分？', null, '系统全局区 SGA ', 'PMON后台进程', '控制文件', 'Dnnn 调度进程', 'C', '10');
INSERT INTO `test` VALUES ('26', '7', '在全局存储区 SGA中，哪部分内存区域是循环使用的 ?', null, '数据缓冲区', '日志缓冲区', '共享池', '大池', 'B', '10');
INSERT INTO `test` VALUES ('27', '7', '解析后的 SQL语句在SGA的哪个区域中进行缓存？', null, '数据缓冲区', '日志缓冲区', '共享池', '大池', 'C', '10');
INSERT INTO `test` VALUES ('28', '7', '下面哪个描述是正确的？', null, '表空间由段组成，段由盘区组成，盘区由数据块组成。', '段由表空间组成，表空间由盘区组成，盘区由数据块组成。', '盘区由数据块组成 ,数据块由段组成，段由表空间组成。', '数据块由段组成，段由盘区组成，盘区由表空间组成。', 'A', '10');
INSERT INTO `test` VALUES ('29', '7', '下列哪个部分不是 oracle 实例的组成部分？', null, '系统全局区域', '服务器进程', '数据库作者', '系统监控器', 'C', '10');
INSERT INTO `test` VALUES ('30', '7', '你用DBCA建立了一个数据库而没有保存模版定义。现在你打算用 DBCA拷贝整个数据库和数据，下列哪个是首先要做的？', null, '使用脚本建立新的数据库，使用 DBCA导入数据', '用DBCA模版管理从现有数据库建立一个新的数据库，数据也如此导入', '从模版列表中选择先前建立的数据库模版并建立数据库', '从现有数据库中拷贝数据文件建立新的数据库，然后利用 DBCA拷贝数据', 'D', '10');
INSERT INTO `test` VALUES ('31', '7', '你使用下列命令连接数据库： sqlplus scott/trigger@abc.com:1522/orcl. 目标数据库 是哪一个？', null, 'abc.com', 'tiger', 'orcl', 'scott', 'A', '10');
INSERT INTO `test` VALUES ('32', '7', '下列哪个不是有效的数据库状态？', null, '开机', '关闭', '启动', '装载', 'A', '10');
INSERT INTO `test` VALUES ('33', '7', 'Oracle 数据库由一个或多个称为（）的逻辑存储单元组成。', null, '表', '表空间', '行', '单元', 'B', '10');
INSERT INTO `test` VALUES ('34', '32', '对于系统表的空间， Oracle建议的大小是', null, '100M', '200M ', '300M ', '400M', 'D', '10');
INSERT INTO `test` VALUES ('35', '32', '下列动态视图中，（  ）是从控制文件中得到的所有表空间的名称和数量。', null, 'V$INSTANCE ', 'V$DATABASE ', 'V$TABLESPACE', 'V$DATAFILES', 'C', '10');
INSERT INTO `test` VALUES ('36', '32', 'Oracle 数据库的最小 I/O单位是', null, '表空间 ', '段', '盘区', '数据块', 'D', '10');
INSERT INTO `test` VALUES ('37', '15', '下面哪个参数不能在 STORAGE子句中进行设置', null, 'INITIAL  ', 'PCTUSED', 'MINEXTENTS', 'NEXT', 'B', '10');
INSERT INTO `test` VALUES ('38', '15', 'SQL语言中，删除一个表的命令是', null, 'DELETE ', 'DROP', 'CLEAR', 'REMORE', 'B', '10');
INSERT INTO `test` VALUES ('39', '15', '你定义了一个对象类型 myOBJ，要基于该类型来创建表 tab1，语句为', null, 'CREATE TABLE tab1 OF myOBJ；', 'CREATE TABLE myOBJ OF tab1；', 'CREATE TABLE tab1 AS myOBJ；', 'CREATE TABLE tab1 TYPE OF myOBJ；', 'C', '10');
INSERT INTO `test` VALUES ('40', '15', '下列涉及空值的操作，不正确的是 ', null, ' AGE IS NULL', 'AGE IS NOT NULL', 'AGE = NULL ', 'NOT (AGE IS NULL)', 'C', '10');
INSERT INTO `test` VALUES ('41', '15', '下列中哪个不是 DML命令？', null, 'Insert ', 'Create', 'Update', 'Delete', 'B', '10');
INSERT INTO `test` VALUES ('42', '15', '用于删除表中所有数据行的命令是', null, 'DELETE TABLE ', 'TRUNCATE TABLE', 'DROP TABLE ', ' ALTER TABLE', 'B', '10');
INSERT INTO `test` VALUES ('43', '15', '在表 emp 里，计算员工的年薪 SAL*12 并生成别名 Annual Salary。', null, 'SELECT ename,sal*12, Annual Salary FROM emp; ', 'SELECT ename,sal*12 \"Annual Salary \" FROM emp; ', 'SELECT ename,sal*12 AS Annual Salary FROM emp; ', 'SELECT ename,sql*12 AS INICTAP(\"Annual Salary \") FROM emp; ', 'B', '10');
INSERT INTO `test` VALUES ('44', '15', '下列哪个 CREATE TABLE 语法是有效的？', null, 'CREATE TABLE emp9$# (emp_no NUMBER (4)); ', 'CREATE TABLE 9emp$# (emp_no NUMBER(4)); ', 'CREATE TABLE emp*123 (emp_no NUMBER(4)); ', 'CREATE TABLE emp9$# (emp_no NUMBER(4), date DATE); ', 'A', '10');
INSERT INTO `test` VALUES ('45', '15', '下面查询：SQL> SELECT cust_name AS \"NAME\", cust_credit_limit/2 AS MIDPOINT,MIDPOINT+100 AS \"MAX LOWER LIMIT\" FROM customers; 上面查询在执行时发生错误，这个错误的原因是什么？', null, '一个别名不能使用在表达式中。', ' 一个别名 NAME 没有一个隔开的双引号。', 'MIDPOINT+100 是错误的因为 CUST_CREDIT_LIMIT 包含了 NULL 值。 ', '为 CUST_CREDIT_LIMIT/2 表达式取一个别名 MIDPOINT 应用双引号隔开。 ', 'A', '10');
INSERT INTO `test` VALUES ('46', '15', '你想去生成一个报表显示每个员工从入职以来的总的薪金。 你执行下列查询： SQL>SELECT ename \' joined on \' hiredate \', the total compensation paid is \' TO_CHAR(ROUND(ROUND(SYSDATE-hiredate)/365) * sal + comm) \"COMPENSATION UNTIL DATE\" FROM employees; 输出结果：哪个说法是正确的？', null, '此查询执行错误是因为别名无效的。', '此查询能正确执行并得到正确的结果。 ', '此查询能正确执行但不能得到正确结果。', '此查询执行错误是因为 ROUND 函数是无效的。', 'C', '10');
INSERT INTO `test` VALUES ('47', '16', '当你执行下列查询： SQL> select e.empno, e.ename, d.loc 2 from emp e, dept d 3 where e.deptno = d.deptno 4 and substr(e.ename, 1, 1) = ‘S’; 下列哪个语句是 Oracle 数据库中可用的 ANSI 兼容等价语句？', null, 'select empno, ename, loc from emp join dept on emp.deptno = dept.deptno where substr(emp.ename, 1, 1) = ‘S’; ', 'select empno, ename, loc from emp, dept on emp.deptno = dept.deptno where substr(emp.ename, 1, 1) = ‘S’; ', 'select empno, ename, loc from emp join dept where emp.deptno = dept.deptno and substr(emp.ename, 1, 1) = ‘S’; ', 'select empno, ename, loc from emp left join dept on emp.deptno = dept.deptno andsubstr(emp.ename, 1, 1) = ‘S’; ', 'A', '10');
INSERT INTO `test` VALUES ('48', '16', '你要操纵 Oracle 数据，下列哪个不是 SQL 命令？', null, 'select * from dual; ', 'set define ', 'update emp set ename = 6543 where ename = ‘SMITHERS’;', 'create table employees(empid varchar2(10) primary key); ', 'B', '10');
INSERT INTO `test` VALUES ('49', '16', 'SQL *Plus 中发出的下列语句： SQL> select ceil(-97.342), 2 floor(-97.342), 3 round(-97.342), 4 trunc(-97.342) 5 from dual; 下列哪个函数不返回结果-97？', null, 'ceil() ', 'floor()', 'round() ', 'trunc()', 'B', '10');
INSERT INTO `test` VALUES ('50', '16', '查看下面 PROMOTIONS 表结构： name Null Type PROMO_ID NOT NULL NUMBER(6) PROMO_NAME NOT NULL VARCHAR2(30) PROMO_CATEGORY NOT NULL VARCHAR2(30) PROMO_COST NOT NULL NUMBER(10,2 管理层想看到每种促销种类的唯一促销成本。下面哪个查询得到需要的结果？', null, 'SELECT DISTINCT promo_cost, promo_category FROM promotions; ', 'SELECT promo_category, DISTINCT promo_cost FROM promotions; ', 'SELECT DISTINCT promo_cost, DISTINCT promo_category FROM promotions; ', 'SELECT DISTINCT promo_category, promo_cost FROM promotions ORDER BY 1; ', 'D', '10');
INSERT INTO `test` VALUES ('51', '18', '哪项是进程主要职责是监控服务器进程和注册数据库服务？', null, 'SMON', 'PMON', 'CHKT', 'LGWR', 'B', '10');
INSERT INTO `test` VALUES ('52', '18', '下面（  ）角色允许一个用户创建其他用户', null, 'CONNECT', 'DBA', 'RESOURCE ', 'SYSDBA', 'B', '10');
INSERT INTO `test` VALUES ('53', '18', '如果要启用所有角色，则应该使用（  ）命令', null, 'SET ROLE ALL ', 'SET ROLE ENABLE ALL', 'ALTER SESSION ALL', 'ALTER USER ROLE ALL', 'B', '10');
INSERT INTO `test` VALUES ('54', '18', '如果一个用户不慎删除了一个表，这将被认为是什么故障？', null, '实例', '用户错误', '表述', '用户进程', 'B', '10');
INSERT INTO `test` VALUES ('55', '18', '你使用下列命令连接数据库：sqlplus scott/trigger@abc.com:1522/orcl.目标数据库是哪一个？', null, 'abc.com', 'tiger', 'orcl', 'scott', 'C', '10');
INSERT INTO `test` VALUES ('56', '18', '下列解锁scott账户的命令正确的是', null, 'update user scott account unlock;', 'alter user scott account unlock;', 'alter user scott unlock;', '以上都不对', 'B', '10');
INSERT INTO `test` VALUES ('57', '18', '当删除一个用户的操作时，在什么情况下，应该在DROP USER语句中使用CASCADE选项？', null, '这个模式包含了对象', '这个模式没有包含了对象', '这个用户目前与数据库连接着 ', '这个用户必须保留但是用户的对象需要删除', 'A', '10');
INSERT INTO `test` VALUES ('58', '18', '要截断（TRUNCATE）其他用户拥有的一个表，需要哪一个权限？', null, 'ALTER TABLE ', 'DROP ANY TABLE ', 'DELETE ANY TABLE ', 'TRUNCATE ANY TABLE', 'B', '10');
INSERT INTO `test` VALUES ('59', '18', '手工创建一个新的数据库的时候，首先', null, '启动一个实例 ', '启动SQL*PLUS，以SYSDBA身份连接orcale', '关闭当前实例', '创建一个参数文件', 'D', '10');
INSERT INTO `test` VALUES ('60', '21', '在设置撤消表空间的自动管理功能时， DBA通过使用相关的初始化参数对自动撤消表空间进行配置。下面的 4个参数中，哪一个不是与自动撤消管理功能相关的参数？', null, 'UNDO_MANAGEMENT', 'UNDO_TABLESPACE', 'UNDO_RETENTION', 'TRANSACTIONS', 'D', '10');
INSERT INTO `test` VALUES ('61', '21', 'Oracle 表的唯一键约束与主键约束的一个区别是', null, '唯一键标识的列可以为空', '主键标识的列可以为空', '唯一键标识的列只可以为单列', '主键标识的列只可以为单列', 'A', '10');
INSERT INTO `test` VALUES ('62', '21', '如果希望在激活约束时不验证表中已有的数据是否满足约束的定义，那么可以使用下列哪 个关键字？', null, 'disactive', 'validate ', 'active', 'novalidate', 'D', '10');
INSERT INTO `test` VALUES ('63', '21', '什么权限可以允许被授权者置数据库于 noarchivelog 模式？', null, ' sysdba', 'root', 'dba', 'operator', 'C', '10');
INSERT INTO `test` VALUES ('64', '21', '下列哪个表述将用户 brent和他的模型实体一起从数据库中移动？ ', null, 'drop user brent;', 'delete from dba_uesrs where username= ’brent’;', 'alter system remove user brent cascade;', 'drop user brent cascade;', 'D', '10');
INSERT INTO `test` VALUES ('65', '21', '下列权限中，哪一个不是数据库的访问权限 ?', null, 'Read权限', 'Resource 权限', 'Update 权限', 'Lock 权限', 'D', '10');
INSERT INTO `test` VALUES ('66', '21', '假设用户 USER1的默认表空间为 USERS,他在该空间的配额为 10MB，则USER1在USERS表空间创建基本表时，他应具有（  ）权限', null, 'CREATE TABLE', 'CREATE USER ', 'UNLIMITED TABLESPACE', 'LIMITED TABLESPACE', 'A', '10');
INSERT INTO `test` VALUES ('67', '21', '下列哪一项资源不能在用户配置文件中限定？', null, '各个会话的用户数', '登录失败的次数', '使用CPU时间', '使用SGA区的大小', 'A', '10');
INSERT INTO `test` VALUES ('68', '21', '下面哪一个不是系统权限？', null, 'SELECT TABLE', 'CREATE TABLE', 'SYSDBA', 'CREATE INDEX', 'D', '10');
INSERT INTO `test` VALUES ('69', '21', '想在另一个模式中创建表，用户至少该具有（  ）系统权限', null, 'CREATE TABLE', 'CREATE ANY TABLE', 'RESOURCE', 'DBA', 'B', '10');
INSERT INTO `test` VALUES ('70', '22', '用户查询下列（  ）数据字典视图可以查看他向其他用户授予的对象权限。', null, 'DBA_SYS_PRIVS', 'USER_TAB_PRIVS_MADE', 'USER_TAB_PRIVS ', 'USER_OBJ_PRIVS', 'C', '10');
INSERT INTO `test` VALUES ('71', '24', '关于单行函数，哪一个描述是正确的？', null, '他们只能接受一个参数', '他们只能嵌套两层', '参数只能是字段值或常量', '他们始终为查找表中的每个行返回一个值', 'D', '10');
INSERT INTO `test` VALUES ('72', '24', '如果服务器进程无法在数据缓冲区中找到空闲缓存块， 以添加从数据文件中读取的数据块，则将启动如下哪个进程？', null, 'DBWR', 'LGWR', 'SMON ', 'PMON', 'A', '10');
INSERT INTO `test` VALUES ('73', '24', '如果服务器进程非正常终止， Oracle 系统将使用下列哪一个进程以释放它所占用的资源？', null, 'DBWR', 'LGWR', 'SMON ', 'PMON', 'D', '10');
INSERT INTO `test` VALUES ('74', '24', '下列函数不属于集函数的是', null, 'max', 'avg', 'count', 'substring', 'D', '10');
INSERT INTO `test` VALUES ('75', '24', '哪个函数不能用于日期 /时间类型。', null, 'MAX', 'MIN', 'COUNT ', 'TO_CHAR', 'C', '10');
INSERT INTO `test` VALUES ('76', '24', 'HAVING子句的作用是', null, '查询结果的分组条件', '组的筛选条件', '限定返回的行的判断条件 ', ' 对结果集进行排序', 'A', '10');
INSERT INTO `test` VALUES ('77', '24', '查询一个表的总记录数，可以采用（  ）统计函数。', null, 'AVG(*)', 'SUM(*)', 'COUNT(*)', 'MAX(*)', 'C', '10');
INSERT INTO `test` VALUES ('78', '24', '数据库设计中用关系模型表示实体和实体之间的联系。关系模型的结构是', null, '层次结构', '二维表结构', '网状结构', '封装结构', 'B', '10');
INSERT INTO `test` VALUES ('79', '27', '下列哪个进程用于将修改过的数据从内存保存到磁盘数据文件中？', null, 'DBWR', 'LGWR', 'RECO', 'ARCH', 'A', '10');
INSERT INTO `test` VALUES ('80', '27', '当数据库运行在归档模式下时，如果发生日志切换，为了保证不覆盖旧的日志信息，系统 将启动哪个进程？', null, 'DBWR ', 'LGWR', 'SMON', 'ARCH', 'D', '10');
INSERT INTO `test` VALUES ('81', '27', '你正在你的组织紧急事件处置演习中。几乎没有时间通报用户，你就需要尽快地停止数 据库进程。下列命令哪个是你需要要执行的？', null, ' shutdown abort', 'shutdown transactional', 'shutdown', 'shutdown immediate', 'D', '10');
INSERT INTO `test` VALUES ('82', '27', '你正在用共享服务器管理一个数据库。 Large_pool_size 是 50M。你执行命令 :alter system set  Large_pool_size=100M  scope=memory后然后关闭并重启数据库。现在 Large_pool_size 是多少？', null, '50M', '默认Large_pool_size 大小', '100M', '和使用中的 oracle SPfile 设置的一样', 'A', '10');
INSERT INTO `test` VALUES ('83', '27', '如果一个数据库举例 (instance) 失败，但是没有停止运行，你必须使用哪个命令使实例 恢复能被执行？', null, 'startup nomount', 'shutdown immediate; start force', 'startup mount ', 'shutdown abort; startup', 'B', '10');
INSERT INTO `test` VALUES ('84', '27', '下列哪个不是有效的数据泵导出模式？', null, 'JAVA ', ' SCHEMA ', 'TABLE', 'TABLESPACE', 'A', '10');
INSERT INTO `test` VALUES ('85', '27', '进行数据库闪回时，必须确保数据库是处于（  ）模式', null, '正常启动模式', '用户交互模式', '归档模式', '调试维护模式', 'C', '10');
INSERT INTO `test` VALUES ('86', '27', 'Oracle 支持多种类型的不完全备份，下列 (  ) 不是Oracle所支持的不完全备份？', null, '基于时间的不完全备份', '基于拥护的不完全备份', '基于撤消的不完全备份', '基于更改的不完全备份', 'B', '10');
INSERT INTO `test` VALUES ('87', '27', '在对恢复目录进行 CROSSCHECK 检验时，如果 RMAN不能找到物理存储的备份文件，则备份文件的信息将被标记为', null, '.EXPIRED ', 'DELETE', 'ACAILABLE ', 'UNAVAILABLE', 'A', '10');
INSERT INTO `test` VALUES ('88', '27', '下列哪个命令可以用来确认恢复目录中记录的备份数据文件是否存在？', null, 'CROSS CHECK BACKUP OF DATABASE', 'CROSS CHECK COPY OF DATABASE', 'CROSSCHECK COPY', 'CROSSCHECK BACKUP OF ARCHIVELOG ALL', 'D', '10');
INSERT INTO `test` VALUES ('89', '28', '下面哪一种不完全恢复需要使用 SCN号作为参数？', null, '基于时间的不完全备份', '基于撤消的不完全备份', '基于更改的不完全备份', '基于顺序的不完全备份', 'C', '10');
INSERT INTO `test` VALUES ('90', '28', '下列哪一个命令可以将一个文件的备份还原到数据库原目录中？', null, 'RECOVER', 'BACKUP', 'COPY ', 'RESTORE', 'D', '10');
INSERT INTO `test` VALUES ('91', '28', '使用RMAN进行介质恢复时，执行命令的顺序是什么？', null, 'RESTORE、RECOVER', 'RECOVER 、RESTORE', 'COPY、BACKUP ', 'COPY、RECOVER', 'A', '10');
INSERT INTO `test` VALUES ('92', '28', '下列哪一个操作可以用来为一个备份操作手动分配通道？', null, 'ALLOCATE CHANNEL', 'CREATE CHANNEL', 'CHANNEL ALLOCATE ', 'CREATE LINK', 'A', '10');
INSERT INTO `test` VALUES ('93', '28', '下列哪一个命令用来显示 RMAN通道的配置信息？', null, 'LIST', 'DISPLAY', 'SHOW ', '都可以', 'A', '10');
INSERT INTO `test` VALUES ('94', '28', '下列哪一个命令可以用来执行不完全恢复？ ', null, 'RESTORE DATABASE UNTIL', 'RECOVER DATABASE UNTIL', 'RECOVER DATA UNTIL', 'RESTORE DATA UNTIL', 'B', '10');

-- ----------------------------
-- Table structure for testlist
-- ----------------------------
DROP TABLE IF EXISTS `testlist`;
CREATE TABLE `testlist` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Testname` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `Class` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `Info` varchar(1024) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `Scene` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of testlist
-- ----------------------------
INSERT INTO `testlist` VALUES ('1', '测试一', '1', '这是测试一', '1');
INSERT INTO `testlist` VALUES ('4', '测试一', '1', '这是测试一', '2');
INSERT INTO `testlist` VALUES ('7', '测试一', '1', '这是测试一', '3');
INSERT INTO `testlist` VALUES ('15', '测试一', '1', '这是测试一', '4');
INSERT INTO `testlist` VALUES ('16', '测试二', '1', '这是测试二', '4');
INSERT INTO `testlist` VALUES ('18', '测试一', '1', '这是测试一', '5');
INSERT INTO `testlist` VALUES ('21', '测试一', '1', '这是测试一', '6');
INSERT INTO `testlist` VALUES ('22', '测试二', '1', '这是测试二', '6');
INSERT INTO `testlist` VALUES ('24', '测试一', '1', '这是测试一', '7');
INSERT INTO `testlist` VALUES ('27', '测试一', '1', '这是测试一', '8');
INSERT INTO `testlist` VALUES ('28', '测试二', '1', '这是测试二', '8');
INSERT INTO `testlist` VALUES ('32', '测试二', '1', '这是测试二', '3');

-- ----------------------------
-- Table structure for upload
-- ----------------------------
DROP TABLE IF EXISTS `upload`;
CREATE TABLE `upload` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `Info` varchar(1024) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Path` varchar(400) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Size` varchar(200) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Class` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of upload
-- ----------------------------
INSERT INTO `upload` VALUES ('22', '课件一', '这是课件一', 'C:\\Users\\DELL\\Desktop\\Oracle.Net\\Oracle.Net\\wwwroot/upload/aca3ec2d-be50-4781-bb6d-fd0d3fa05668.jpg', '128KB', '1');
INSERT INTO `upload` VALUES ('23', '课件二', '这是课件二', 'C:\\Users\\DELL\\Desktop\\Oracle.Net\\Oracle.Net\\wwwroot/upload/f1595c95-1d18-4926-aa5f-05d6472cd1ea.jpg', '128KB', '1');
INSERT INTO `upload` VALUES ('24', '课件三', '这是课件三', 'C:\\Users\\DELL\\Desktop\\Oracle.Net\\Oracle.Net\\wwwroot/upload/c6c054cc-fc1d-4770-908f-b20f8f7613d0.jpg', '128KB', '1');
INSERT INTO `upload` VALUES ('25', '课件四', '这是课件四', 'C:\\Users\\DELL\\Desktop\\Oracle.Net\\Oracle.Net\\wwwroot/upload/d9fa2ad8-4d5d-4ca6-a907-de8ffe8508c7.jpg', '128KB', '1');
INSERT INTO `upload` VALUES ('26', '课件五', '这是课件五', 'C:\\Users\\DELL\\Desktop\\Oracle.Net\\Oracle.Net\\wwwroot/upload/de8e4347-cc68-4952-9c5c-8815d723cd2b.jpg', '128KB', '1');

-- ----------------------------
-- Table structure for user
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `Id` int(11) NOT NULL,
  `Name` varchar(200) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `PhoneNumber` varchar(200) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Password` varchar(200) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Class` varchar(200) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Term` int(11) DEFAULT NULL,
  `Role` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO `user` VALUES ('1', '彭老师', '1', '1', '1', null, 'teacher');
INSERT INTO `user` VALUES ('2', '曾老师', '2', '2', '2', null, 'teacher');
INSERT INTO `user` VALUES ('111', '张鑫', '111', '111', '1', '201809', 'student');
INSERT INTO `user` VALUES ('222', '尚珂', '222', '222', '1', '201803', 'student');
INSERT INTO `user` VALUES ('333', '白佳才', '333', '333', '1', '201809', 'student');
INSERT INTO `user` VALUES ('444', '顾求实', '444', '444', '2', '201809', 'student');
