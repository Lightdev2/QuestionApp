<template>
  <div class="nav">
    <div class="nav__content">
      <div class="nav__left">
        <logo class="nav__logo"/>
      </div>
      <top-search-input/>
      <div class="nav__right">
        <div class="nav__right-item nav__user">
          <avatar/>
          <span title="reputation" class="nav__rep">1</span>
        </div>
        <div title="achievements" class="nav__right-item nav__icon">
          <cup-icon/>
        </div>
        <div title="notifications" class="nav__right-item nav__icon">
          <inbox-icon />
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import TopSearchInput from "@/components/TopSearchInput";
import Avatar from "@/components/Avatar";
import Logo from "@/assets/logo";
import CupIcon from "@/assets/cup"
import InboxIcon from "@/assets/inbox";

export default {
  name: "TopAppNav",
  components: {Avatar, TopSearchInput, Logo, CupIcon, InboxIcon}
}
</script>

<style scoped lang="scss">
.nav {
  position: fixed;
  width: 100%;
  background: var(--black25);

  &__content {
    max-width: 1264px;
    display: flex;
    align-items: center;
    justify-content: space-between;
    margin: 0 auto;
  }

  &__left {
    margin-right: 50px;
  }

  &__right {
    display: flex;
    align-items: center;
    margin-left: 50px;
  }

  &__right-item {
    fill: var(--black400);
    cursor: pointer;
    display: flex;
    align-items: center;
    height: 50px;
    &:hover {
      background-color: var(--black75);
    }
    &:not(:last-child) {
      margin-right: 1rem;
    }
  }

  &__icon {
    padding-left: 10px;
    padding-right: 10px;
  }

  &__logo {
    height: 35px;
  }

  &__user {
    display: flex;
    align-items: center;
    cursor: pointer;
    height: 50px;
    padding-left: 1rem;
    padding-right: 1rem;
    &:hover {
      background-color: var(--black75);
    }
  }
  &__rep {
    color: var(--black900);
    margin-left: 1rem;
  }
}
</style>
